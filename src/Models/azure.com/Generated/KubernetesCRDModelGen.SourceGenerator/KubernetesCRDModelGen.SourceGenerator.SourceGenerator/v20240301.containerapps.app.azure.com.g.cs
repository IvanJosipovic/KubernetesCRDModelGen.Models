#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.app.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/ContainerApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240301ContainerAppList : IKubernetesObject<V1ListMeta>, IItems<V20240301ContainerApp>
{
    public const string KubeApiVersion = "v20240301";
    public const string KubeKind = "ContainerAppList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "containerapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerAppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240301ContainerApp objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240301ContainerApp> Items { get; set; }
}

/// <summary>
/// ActiveRevisionsMode: ActiveRevisionsMode controls how active revisions are handled for the Container app:
/// &lt;list&gt; &lt;item&gt;Multiple: multiple revisions can be active.&lt;/item&gt; &lt;item&gt;Single: Only one revision can be active at a time.
/// Revision weights can not be used in this mode. If no value if provided, this is the default.&lt;/item&gt; &lt;/list&gt;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationActiveRevisionsModeEnum>))]
public enum V20240301ContainerAppSpecConfigurationActiveRevisionsModeEnum
{
    [EnumMember(Value = "Multiple"), JsonStringEnumMemberName("Multiple")]
    Multiple,
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    Single
}

/// <summary>AppProtocol: Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationDaprAppProtocolEnum>))]
public enum V20240301ContainerAppSpecConfigurationDaprAppProtocolEnum
{
    [EnumMember(Value = "grpc"), JsonStringEnumMemberName("grpc")]
    Grpc,
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http
}

/// <summary>LogLevel: Sets the log level for the Dapr sidecar. Allowed values are debug, info, warn, error. Default is info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationDaprLogLevelEnum>))]
public enum V20240301ContainerAppSpecConfigurationDaprLogLevelEnum
{
    [EnumMember(Value = "debug"), JsonStringEnumMemberName("debug")]
    Debug,
    [EnumMember(Value = "error"), JsonStringEnumMemberName("error")]
    Error,
    [EnumMember(Value = "info"), JsonStringEnumMemberName("info")]
    Info,
    [EnumMember(Value = "warn"), JsonStringEnumMemberName("warn")]
    Warn
}

/// <summary>Dapr: Dapr configuration for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationDapr
{
    /// <summary>AppId: Dapr application identifier</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>AppPort: Tells Dapr which port your application is listening on</summary>
    [JsonPropertyName("appPort")]
    public int? AppPort { get; set; }

    /// <summary>AppProtocol: Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http</summary>
    [JsonPropertyName("appProtocol")]
    public V20240301ContainerAppSpecConfigurationDaprAppProtocolEnum? AppProtocol { get; set; }

    /// <summary>EnableApiLogging: Enables API logging for the Dapr sidecar</summary>
    [JsonPropertyName("enableApiLogging")]
    public bool? EnableApiLogging { get; set; }

    /// <summary>Enabled: Boolean indicating if the Dapr side car is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// HttpMaxRequestSize: Increasing max size of request body http and grpc servers parameter in MB to handle uploading of big
    /// files. Default is 4 MB.
    /// </summary>
    [JsonPropertyName("httpMaxRequestSize")]
    public int? HttpMaxRequestSize { get; set; }

    /// <summary>
    /// HttpReadBufferSize: Dapr max size of http header read buffer in KB to handle when sending multi-KB headers. Default is
    /// 65KB.
    /// </summary>
    [JsonPropertyName("httpReadBufferSize")]
    public int? HttpReadBufferSize { get; set; }

    /// <summary>LogLevel: Sets the log level for the Dapr sidecar. Allowed values are debug, info, warn, error. Default is info.</summary>
    [JsonPropertyName("logLevel")]
    public V20240301ContainerAppSpecConfigurationDaprLogLevelEnum? LogLevel { get; set; }
}

/// <summary>Port mappings of container app ingress</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressAdditionalPortMappings
{
    /// <summary>ExposedPort: Specifies the exposed port for the target port. If not specified, it defaults to target port</summary>
    [JsonPropertyName("exposedPort")]
    public int? ExposedPort { get; set; }

    /// <summary>External: Specifies whether the app port is accessible outside of the environment</summary>
    [JsonPropertyName("external")]
    public required bool External { get; set; }

    /// <summary>TargetPort: Specifies the port user&apos;s container listens on</summary>
    [JsonPropertyName("targetPort")]
    public required int TargetPort { get; set; }
}

/// <summary>
/// ClientCertificateMode: Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate
/// on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require
/// indicates server requires a client certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationIngressClientCertificateModeEnum>))]
public enum V20240301ContainerAppSpecConfigurationIngressClientCertificateModeEnum
{
    [EnumMember(Value = "accept"), JsonStringEnumMemberName("accept")]
    Accept,
    [EnumMember(Value = "ignore"), JsonStringEnumMemberName("ignore")]
    Ignore,
    [EnumMember(Value = "require"), JsonStringEnumMemberName("require")]
    Require
}

/// <summary>CorsPolicy: CORS policy for container app</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressCorsPolicy
{
    /// <summary>AllowCredentials: Specifies whether the resource allows credentials</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>AllowedHeaders: Specifies the content for the access-control-allow-headers header</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>AllowedMethods: Specifies the content for the access-control-allow-methods header</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>AllowedOrigins: Specifies the content for the access-control-allow-origins header</summary>
    [JsonPropertyName("allowedOrigins")]
    public required IList<string> AllowedOrigins { get; set; }

    /// <summary>ExposeHeaders: Specifies the content for the access-control-expose-headers header</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>MaxAge: Specifies the content for the access-control-max-age header</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>BindingType: Custom Domain binding type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationIngressCustomDomainsBindingTypeEnum>))]
public enum V20240301ContainerAppSpecConfigurationIngressCustomDomainsBindingTypeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SniEnabled"), JsonStringEnumMemberName("SniEnabled")]
    SniEnabled
}

/// <summary>CertificateReference: Resource Id of the Certificate to be bound to this hostname. Must exist in the Managed Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressCustomDomainsCertificateReference
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

/// <summary>Custom Domain of a Container App</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressCustomDomains
{
    /// <summary>BindingType: Custom Domain binding type.</summary>
    [JsonPropertyName("bindingType")]
    public V20240301ContainerAppSpecConfigurationIngressCustomDomainsBindingTypeEnum? BindingType { get; set; }

    /// <summary>CertificateReference: Resource Id of the Certificate to be bound to this hostname. Must exist in the Managed Environment.</summary>
    [JsonPropertyName("certificateReference")]
    public V20240301ContainerAppSpecConfigurationIngressCustomDomainsCertificateReference? CertificateReference { get; set; }

    /// <summary>Name: Hostname.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Action: Allow or Deny rules to determine for incoming IP. Note: Rules can only consist of ALL Allow or ALL Deny</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationIngressIpSecurityRestrictionsActionEnum>))]
public enum V20240301ContainerAppSpecConfigurationIngressIpSecurityRestrictionsActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Rule to restrict incoming IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressIpSecurityRestrictions
{
    /// <summary>Action: Allow or Deny rules to determine for incoming IP. Note: Rules can only consist of ALL Allow or ALL Deny</summary>
    [JsonPropertyName("action")]
    public required V20240301ContainerAppSpecConfigurationIngressIpSecurityRestrictionsActionEnum Action { get; set; }

    /// <summary>Description: Describe the IP restriction rule that is being sent to the container-app. This is an optional field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IpAddressRange: CIDR notation to match incoming IP address</summary>
    [JsonPropertyName("ipAddressRange")]
    public required string IpAddressRange { get; set; }

    /// <summary>Name: Name for the IP restriction rule.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Affinity: Sticky Session Affinity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationIngressStickySessionsAffinityEnum>))]
public enum V20240301ContainerAppSpecConfigurationIngressStickySessionsAffinityEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "sticky"), JsonStringEnumMemberName("sticky")]
    Sticky
}

/// <summary>StickySessions: Sticky Sessions for Single Revision Mode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressStickySessions
{
    /// <summary>Affinity: Sticky Session Affinity</summary>
    [JsonPropertyName("affinity")]
    public V20240301ContainerAppSpecConfigurationIngressStickySessionsAffinityEnum? Affinity { get; set; }
}

/// <summary>Traffic weight assigned to a revision</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngressTraffic
{
    /// <summary>Label: Associates a traffic label with a revision</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>LatestRevision: Indicates that the traffic weight belongs to a latest stable revision</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>RevisionName: Name of a revision</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Weight: Traffic weight assigned to a revision</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Transport: Ingress transport protocol</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecConfigurationIngressTransportEnum>))]
public enum V20240301ContainerAppSpecConfigurationIngressTransportEnum
{
    [EnumMember(Value = "auto"), JsonStringEnumMemberName("auto")]
    Auto,
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "http2"), JsonStringEnumMemberName("http2")]
    Http2,
    [EnumMember(Value = "tcp"), JsonStringEnumMemberName("tcp")]
    Tcp
}

/// <summary>Ingress: Ingress configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationIngress
{
    /// <summary>AdditionalPortMappings: Settings to expose additional ports on container app</summary>
    [JsonPropertyName("additionalPortMappings")]
    public IList<V20240301ContainerAppSpecConfigurationIngressAdditionalPortMappings>? AdditionalPortMappings { get; set; }

    /// <summary>
    /// AllowInsecure: Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically
    /// redirected to HTTPS connections
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// ClientCertificateMode: Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate
    /// on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require
    /// indicates server requires a client certificate.
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public V20240301ContainerAppSpecConfigurationIngressClientCertificateModeEnum? ClientCertificateMode { get; set; }

    /// <summary>CorsPolicy: CORS policy for container app</summary>
    [JsonPropertyName("corsPolicy")]
    public V20240301ContainerAppSpecConfigurationIngressCorsPolicy? CorsPolicy { get; set; }

    /// <summary>CustomDomains: custom domain bindings for Container Apps&apos; hostnames.</summary>
    [JsonPropertyName("customDomains")]
    public IList<V20240301ContainerAppSpecConfigurationIngressCustomDomains>? CustomDomains { get; set; }

    /// <summary>ExposedPort: Exposed Port in containers for TCP traffic from ingress</summary>
    [JsonPropertyName("exposedPort")]
    public int? ExposedPort { get; set; }

    /// <summary>External: Bool indicating if app exposes an external http endpoint</summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>IpSecurityRestrictions: Rules to restrict incoming IP address.</summary>
    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V20240301ContainerAppSpecConfigurationIngressIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    /// <summary>StickySessions: Sticky Sessions for Single Revision Mode</summary>
    [JsonPropertyName("stickySessions")]
    public V20240301ContainerAppSpecConfigurationIngressStickySessions? StickySessions { get; set; }

    /// <summary>TargetPort: Target Port in containers for traffic from ingress</summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }

    /// <summary>Traffic: Traffic weights for app&apos;s revisions</summary>
    [JsonPropertyName("traffic")]
    public IList<V20240301ContainerAppSpecConfigurationIngressTraffic>? Traffic { get; set; }

    /// <summary>Transport: Ingress transport protocol</summary>
    [JsonPropertyName("transport")]
    public V20240301ContainerAppSpecConfigurationIngressTransportEnum? Transport { get; set; }
}

/// <summary>
/// IdentityReference: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned
/// identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationRegistriesIdentityReference
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

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

/// <summary>Container App Private Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationRegistries
{
    /// <summary>
    /// IdentityReference: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned
    /// identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20240301ContainerAppSpecConfigurationRegistriesIdentityReference? IdentityReference { get; set; }

    /// <summary>PasswordSecretRef: The name of the Secret that contains the registry login password</summary>
    [JsonPropertyName("passwordSecretRef")]
    public string? PasswordSecretRef { get; set; }

    /// <summary>Server: Container Registry Server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Username: Container Registry Username</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
/// system-assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationSecretsIdentityReference
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

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

/// <summary>Value: Secret Value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationSecretsValue
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

/// <summary>Secret definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationSecrets
{
    /// <summary>
    /// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
    /// system-assigned identity.
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20240301ContainerAppSpecConfigurationSecretsIdentityReference? IdentityReference { get; set; }

    /// <summary>KeyVaultUrl: Azure Key Vault URL pointing to the secret referenced by the container app.</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary>Name: Secret Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Secret Value.</summary>
    [JsonPropertyName("value")]
    public V20240301ContainerAppSpecConfigurationSecretsValue? Value { get; set; }
}

/// <summary>Service: Container App to be a dev Container App Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfigurationService
{
    /// <summary>Type: Dev ContainerApp service type</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Configuration: Non versioned Container App configuration properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecConfiguration
{
    /// <summary>
    /// ActiveRevisionsMode: ActiveRevisionsMode controls how active revisions are handled for the Container app:
    /// &lt;list&gt; &lt;item&gt;Multiple: multiple revisions can be active.&lt;/item&gt; &lt;item&gt;Single: Only one revision can be active at a time.
    /// Revision weights can not be used in this mode. If no value if provided, this is the default.&lt;/item&gt; &lt;/list&gt;
    /// </summary>
    [JsonPropertyName("activeRevisionsMode")]
    public V20240301ContainerAppSpecConfigurationActiveRevisionsModeEnum? ActiveRevisionsMode { get; set; }

    /// <summary>Dapr: Dapr configuration for the Container App.</summary>
    [JsonPropertyName("dapr")]
    public V20240301ContainerAppSpecConfigurationDapr? Dapr { get; set; }

    /// <summary>Ingress: Ingress configurations.</summary>
    [JsonPropertyName("ingress")]
    public V20240301ContainerAppSpecConfigurationIngress? Ingress { get; set; }

    /// <summary>MaxInactiveRevisions: Optional. Max inactive revisions a Container App can have.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public int? MaxInactiveRevisions { get; set; }

    /// <summary>Registries: Collection of private container registry credentials for containers used by the Container app</summary>
    [JsonPropertyName("registries")]
    public IList<V20240301ContainerAppSpecConfigurationRegistries>? Registries { get; set; }

    /// <summary>Secrets: Collection of secrets used by a Container app</summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301ContainerAppSpecConfigurationSecrets>? Secrets { get; set; }

    /// <summary>Service: Container App to be a dev Container App Service</summary>
    [JsonPropertyName("service")]
    public V20240301ContainerAppSpecConfigurationService? Service { get; set; }
}

/// <summary>EnvironmentReference: Resource ID of environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecEnvironmentReference
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

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecExtendedLocationTypeEnum>))]
public enum V20240301ContainerAppSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "CustomLocation"), JsonStringEnumMemberName("CustomLocation")]
    CustomLocation
}

/// <summary>ExtendedLocation: The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20240301ContainerAppSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecIdentityTypeEnum>))]
public enum V20240301ContainerAppSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20240301ContainerAppSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20240301ContainerAppSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Identity: managed identities for the Container App to interact with other Azure services without maintaining any secrets
/// or credentials in code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V20240301ContainerAppSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20240301ContainerAppSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// ManagedByReference: The fully qualified resource ID of the resource that manages this resource. Indicates if this
/// resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource
/// if it is removed from the template since it is managed by another resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecManagedByReference
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

/// <summary>ManagedEnvironmentReference: Deprecated. Resource ID of the Container App&apos;s environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecManagedEnvironmentReference
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

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecOperatorSpecConfigMapExpressions
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
/// EventStreamEndpoint: indicates where the EventStreamEndpoint config map should be placed. If omitted, no config map will
/// be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecOperatorSpecConfigMapsEventStreamEndpoint
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

/// <summary>Fqdn: indicates where the Fqdn config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecOperatorSpecConfigMapsFqdn
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
public partial class V20240301ContainerAppSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// EventStreamEndpoint: indicates where the EventStreamEndpoint config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("eventStreamEndpoint")]
    public V20240301ContainerAppSpecOperatorSpecConfigMapsEventStreamEndpoint? EventStreamEndpoint { get; set; }

    /// <summary>Fqdn: indicates where the Fqdn config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("fqdn")]
    public V20240301ContainerAppSpecOperatorSpecConfigMapsFqdn? Fqdn { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecOperatorSpecSecretExpressions
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
public partial class V20240301ContainerAppSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240301ContainerAppSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20240301ContainerAppSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240301ContainerAppSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersProbesHttpGetHttpHeaders
{
    /// <summary>Name: The header field name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value: The header field value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Scheme: Scheme to use for connecting to the host. Defaults to HTTP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecTemplateContainersProbesHttpGetSchemeEnum>))]
public enum V20240301ContainerAppSpecTemplateContainersProbesHttpGetSchemeEnum
{
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    HTTP,
    [EnumMember(Value = "HTTPS"), JsonStringEnumMemberName("HTTPS")]
    HTTPS
}

/// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersProbesHttpGet
{
    /// <summary>Host: Host name to connect to, defaults to the pod IP. You probably want to set &quot;Host&quot; in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>HttpHeaders: Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V20240301ContainerAppSpecTemplateContainersProbesHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port: Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Scheme: Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public V20240301ContainerAppSpecTemplateContainersProbesHttpGetSchemeEnum? Scheme { get; set; }
}

/// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersProbesTcpSocket
{
    /// <summary>Host: Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Port: Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }
}

/// <summary>Type: The type of probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecTemplateContainersProbesTypeEnum>))]
public enum V20240301ContainerAppSpecTemplateContainersProbesTypeEnum
{
    [EnumMember(Value = "Liveness"), JsonStringEnumMemberName("Liveness")]
    Liveness,
    [EnumMember(Value = "Readiness"), JsonStringEnumMemberName("Readiness")]
    Readiness,
    [EnumMember(Value = "Startup"), JsonStringEnumMemberName("Startup")]
    Startup
}

/// <summary>
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersProbes
{
    /// <summary>
    /// FailureThreshold: Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to
    /// 3. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V20240301ContainerAppSpecTemplateContainersProbesHttpGet? HttpGet { get; set; }

    /// <summary>
    /// InitialDelaySeconds: Number of seconds after the container has started before liveness probes are initiated. Minimum
    /// value is 1. Maximum value is 60.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>
    /// PeriodSeconds: How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is
    /// 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// SuccessThreshold: Minimum consecutive successes for the probe to be considered successful after having failed. Defaults
    /// to 1. Must be 1 for liveness and startup. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
    [JsonPropertyName("tcpSocket")]
    public V20240301ContainerAppSpecTemplateContainersProbesTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// TerminationGracePeriodSeconds: Optional duration in seconds the pod needs to terminate gracefully upon probe failure.
    /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the
    /// time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for
    /// your process. If this value is nil, the pod&apos;s terminationGracePeriodSeconds will be used. Otherwise, this value
    /// overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop
    /// immediately via the kill signal (no opportunity to shut down). This is an alpha field and requires enabling
    /// ProbeTerminationGracePeriod feature gate. Maximum value is 3600 seconds (1 hour)
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// TimeoutSeconds: Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum
    /// value is 240.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>Type: The type of probe.</summary>
    [JsonPropertyName("type")]
    public V20240301ContainerAppSpecTemplateContainersProbesTypeEnum? Type { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App container definition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301ContainerAppSpecTemplateContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probes: List of probes for the container.</summary>
    [JsonPropertyName("probes")]
    public IList<V20240301ContainerAppSpecTemplateContainersProbes>? Probes { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301ContainerAppSpecTemplateContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301ContainerAppSpecTemplateContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateInitContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateInitContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateInitContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App base container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateInitContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301ContainerAppSpecTemplateInitContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301ContainerAppSpecTemplateInitContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301ContainerAppSpecTemplateInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesAzureQueueAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>AzureQueue: Azure Queue based scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesAzureQueue
{
    /// <summary>Auth: Authentication secrets for the queue scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppSpecTemplateScaleRulesAzureQueueAuth>? Auth { get; set; }

    /// <summary>QueueLength: Queue length.</summary>
    [JsonPropertyName("queueLength")]
    public int? QueueLength { get; set; }

    /// <summary>QueueName: Queue name.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesCustomAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Custom: Custom scale rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesCustom
{
    /// <summary>Auth: Authentication secrets for the custom scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppSpecTemplateScaleRulesCustomAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe custom scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Type: Type of the custom scale rule
    /// eg: azure-servicebus, redis etc.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesHttpAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Http: HTTP requests based scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesHttp
{
    /// <summary>Auth: Authentication secrets for the custom scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppSpecTemplateScaleRulesHttpAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe http scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesTcpAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Tcp: Tcp requests based scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRulesTcp
{
    /// <summary>Auth: Authentication secrets for the tcp scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppSpecTemplateScaleRulesTcpAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe tcp scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Container App container scaling rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScaleRules
{
    /// <summary>AzureQueue: Azure Queue based scaling.</summary>
    [JsonPropertyName("azureQueue")]
    public V20240301ContainerAppSpecTemplateScaleRulesAzureQueue? AzureQueue { get; set; }

    /// <summary>Custom: Custom scale rule.</summary>
    [JsonPropertyName("custom")]
    public V20240301ContainerAppSpecTemplateScaleRulesCustom? Custom { get; set; }

    /// <summary>Http: HTTP requests based scaling.</summary>
    [JsonPropertyName("http")]
    public V20240301ContainerAppSpecTemplateScaleRulesHttp? Http { get; set; }

    /// <summary>Name: Scale Rule Name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tcp: Tcp requests based scaling.</summary>
    [JsonPropertyName("tcp")]
    public V20240301ContainerAppSpecTemplateScaleRulesTcp? Tcp { get; set; }
}

/// <summary>Scale: Scaling properties for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateScale
{
    /// <summary>MaxReplicas: Optional. Maximum number of container replicas. Defaults to 10 if not set.</summary>
    [JsonPropertyName("maxReplicas")]
    public int? MaxReplicas { get; set; }

    /// <summary>MinReplicas: Optional. Minimum number of container replicas.</summary>
    [JsonPropertyName("minReplicas")]
    public int? MinReplicas { get; set; }

    /// <summary>Rules: Scaling rules.</summary>
    [JsonPropertyName("rules")]
    public IList<V20240301ContainerAppSpecTemplateScaleRules>? Rules { get; set; }
}

/// <summary>ServiceReference: Resource id of the target service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateServiceBindsServiceReference
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

/// <summary>Configuration to bind a ContainerApp to a dev ContainerApp Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateServiceBinds
{
    /// <summary>Name: Name of the service bind</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ServiceReference: Resource id of the target service</summary>
    [JsonPropertyName("serviceReference")]
    public V20240301ContainerAppSpecTemplateServiceBindsServiceReference? ServiceReference { get; set; }
}

/// <summary>Secret to be added to volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateVolumesSecrets
{
    /// <summary>Path: Path to project secret to. If no path is provided, path defaults to name of secret listed in secretRef.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the secret value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }
}

/// <summary>StorageType: Storage type for the volume. If not provided, use EmptyDir.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301ContainerAppSpecTemplateVolumesStorageTypeEnum>))]
public enum V20240301ContainerAppSpecTemplateVolumesStorageTypeEnum
{
    [EnumMember(Value = "AzureFile"), JsonStringEnumMemberName("AzureFile")]
    AzureFile,
    [EnumMember(Value = "EmptyDir"), JsonStringEnumMemberName("EmptyDir")]
    EmptyDir,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret
}

/// <summary>Volume definitions for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplateVolumes
{
    /// <summary>MountOptions: Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>Name: Volume name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Secrets: List of secrets to be added in volume. If no secrets are provided, all secrets in collection will be added to
    /// volume.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301ContainerAppSpecTemplateVolumesSecrets>? Secrets { get; set; }

    /// <summary>StorageName: Name of storage resource. No need to provide for EmptyDir and Secret.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>StorageType: Storage type for the volume. If not provided, use EmptyDir.</summary>
    [JsonPropertyName("storageType")]
    public V20240301ContainerAppSpecTemplateVolumesStorageTypeEnum? StorageType { get; set; }
}

/// <summary>Template: Container App versioned application definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpecTemplate
{
    /// <summary>Containers: List of container definitions for the Container App.</summary>
    [JsonPropertyName("containers")]
    public IList<V20240301ContainerAppSpecTemplateContainers>? Containers { get; set; }

    /// <summary>InitContainers: List of specialized containers that run before app containers.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V20240301ContainerAppSpecTemplateInitContainers>? InitContainers { get; set; }

    /// <summary>RevisionSuffix: User friendly suffix that is appended to the revision name</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>Scale: Scaling properties for the Container App.</summary>
    [JsonPropertyName("scale")]
    public V20240301ContainerAppSpecTemplateScale? Scale { get; set; }

    /// <summary>ServiceBinds: List of container app services bound to the app</summary>
    [JsonPropertyName("serviceBinds")]
    public IList<V20240301ContainerAppSpecTemplateServiceBinds>? ServiceBinds { get; set; }

    /// <summary>
    /// TerminationGracePeriodSeconds: Optional duration in seconds the Container App Instance needs to terminate gracefully.
    /// Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to
    /// shut down). If this value is nil, the default grace period will be used instead. Set this value longer than the expected
    /// cleanup time for your process. Defaults to 30 seconds.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Volumes: List of volume definitions for the Container App.</summary>
    [JsonPropertyName("volumes")]
    public IList<V20240301ContainerAppSpecTemplateVolumes>? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Configuration: Non versioned Container App configuration properties.</summary>
    [JsonPropertyName("configuration")]
    public V20240301ContainerAppSpecConfiguration? Configuration { get; set; }

    /// <summary>EnvironmentReference: Resource ID of environment.</summary>
    [JsonPropertyName("environmentReference")]
    public V20240301ContainerAppSpecEnvironmentReference? EnvironmentReference { get; set; }

    /// <summary>ExtendedLocation: The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20240301ContainerAppSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Identity: managed identities for the Container App to interact with other Azure services without maintaining any secrets
    /// or credentials in code.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20240301ContainerAppSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// ManagedByReference: The fully qualified resource ID of the resource that manages this resource. Indicates if this
    /// resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource
    /// if it is removed from the template since it is managed by another resource.
    /// </summary>
    [JsonPropertyName("managedByReference")]
    public V20240301ContainerAppSpecManagedByReference? ManagedByReference { get; set; }

    /// <summary>ManagedEnvironmentReference: Deprecated. Resource ID of the Container App&apos;s environment.</summary>
    [JsonPropertyName("managedEnvironmentReference")]
    public V20240301ContainerAppSpecManagedEnvironmentReference? ManagedEnvironmentReference { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240301ContainerAppSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240301ContainerAppSpecOwner Owner { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Template: Container App versioned application definition.</summary>
    [JsonPropertyName("template")]
    public V20240301ContainerAppSpecTemplate? Template { get; set; }

    /// <summary>WorkloadProfileName: Workload profile name to pin for container app execution.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConditions
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

/// <summary>Dapr: Dapr configuration for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationDapr
{
    /// <summary>AppId: Dapr application identifier</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>AppPort: Tells Dapr which port your application is listening on</summary>
    [JsonPropertyName("appPort")]
    public int? AppPort { get; set; }

    /// <summary>AppProtocol: Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http</summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }

    /// <summary>EnableApiLogging: Enables API logging for the Dapr sidecar</summary>
    [JsonPropertyName("enableApiLogging")]
    public bool? EnableApiLogging { get; set; }

    /// <summary>Enabled: Boolean indicating if the Dapr side car is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// HttpMaxRequestSize: Increasing max size of request body http and grpc servers parameter in MB to handle uploading of big
    /// files. Default is 4 MB.
    /// </summary>
    [JsonPropertyName("httpMaxRequestSize")]
    public int? HttpMaxRequestSize { get; set; }

    /// <summary>
    /// HttpReadBufferSize: Dapr max size of http header read buffer in KB to handle when sending multi-KB headers. Default is
    /// 65KB.
    /// </summary>
    [JsonPropertyName("httpReadBufferSize")]
    public int? HttpReadBufferSize { get; set; }

    /// <summary>LogLevel: Sets the log level for the Dapr sidecar. Allowed values are debug, info, warn, error. Default is info.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }
}

/// <summary>Port mappings of container app ingress</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngressAdditionalPortMappings
{
    /// <summary>ExposedPort: Specifies the exposed port for the target port. If not specified, it defaults to target port</summary>
    [JsonPropertyName("exposedPort")]
    public int? ExposedPort { get; set; }

    /// <summary>External: Specifies whether the app port is accessible outside of the environment</summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>TargetPort: Specifies the port user&apos;s container listens on</summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

/// <summary>CorsPolicy: CORS policy for container app</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngressCorsPolicy
{
    /// <summary>AllowCredentials: Specifies whether the resource allows credentials</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>AllowedHeaders: Specifies the content for the access-control-allow-headers header</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>AllowedMethods: Specifies the content for the access-control-allow-methods header</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>AllowedOrigins: Specifies the content for the access-control-allow-origins header</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>ExposeHeaders: Specifies the content for the access-control-expose-headers header</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>MaxAge: Specifies the content for the access-control-max-age header</summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>Custom Domain of a Container App</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngressCustomDomains
{
    /// <summary>BindingType: Custom Domain binding type.</summary>
    [JsonPropertyName("bindingType")]
    public string? BindingType { get; set; }

    /// <summary>CertificateId: Resource Id of the Certificate to be bound to this hostname. Must exist in the Managed Environment.</summary>
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; set; }

    /// <summary>Name: Hostname.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Rule to restrict incoming IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngressIpSecurityRestrictions
{
    /// <summary>Action: Allow or Deny rules to determine for incoming IP. Note: Rules can only consist of ALL Allow or ALL Deny</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description: Describe the IP restriction rule that is being sent to the container-app. This is an optional field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IpAddressRange: CIDR notation to match incoming IP address</summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>Name: Name for the IP restriction rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>StickySessions: Sticky Sessions for Single Revision Mode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngressStickySessions
{
    /// <summary>Affinity: Sticky Session Affinity</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }
}

/// <summary>Traffic weight assigned to a revision</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngressTraffic
{
    /// <summary>Label: Associates a traffic label with a revision</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>LatestRevision: Indicates that the traffic weight belongs to a latest stable revision</summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>RevisionName: Name of a revision</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Weight: Traffic weight assigned to a revision</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Ingress: Ingress configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationIngress
{
    /// <summary>AdditionalPortMappings: Settings to expose additional ports on container app</summary>
    [JsonPropertyName("additionalPortMappings")]
    public IList<V20240301ContainerAppStatusConfigurationIngressAdditionalPortMappings>? AdditionalPortMappings { get; set; }

    /// <summary>
    /// AllowInsecure: Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically
    /// redirected to HTTPS connections
    /// </summary>
    [JsonPropertyName("allowInsecure")]
    public bool? AllowInsecure { get; set; }

    /// <summary>
    /// ClientCertificateMode: Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate
    /// on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require
    /// indicates server requires a client certificate.
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>CorsPolicy: CORS policy for container app</summary>
    [JsonPropertyName("corsPolicy")]
    public V20240301ContainerAppStatusConfigurationIngressCorsPolicy? CorsPolicy { get; set; }

    /// <summary>CustomDomains: custom domain bindings for Container Apps&apos; hostnames.</summary>
    [JsonPropertyName("customDomains")]
    public IList<V20240301ContainerAppStatusConfigurationIngressCustomDomains>? CustomDomains { get; set; }

    /// <summary>ExposedPort: Exposed Port in containers for TCP traffic from ingress</summary>
    [JsonPropertyName("exposedPort")]
    public int? ExposedPort { get; set; }

    /// <summary>External: Bool indicating if app exposes an external http endpoint</summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>Fqdn: Hostname.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>IpSecurityRestrictions: Rules to restrict incoming IP address.</summary>
    [JsonPropertyName("ipSecurityRestrictions")]
    public IList<V20240301ContainerAppStatusConfigurationIngressIpSecurityRestrictions>? IpSecurityRestrictions { get; set; }

    /// <summary>StickySessions: Sticky Sessions for Single Revision Mode</summary>
    [JsonPropertyName("stickySessions")]
    public V20240301ContainerAppStatusConfigurationIngressStickySessions? StickySessions { get; set; }

    /// <summary>TargetPort: Target Port in containers for traffic from ingress</summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }

    /// <summary>Traffic: Traffic weights for app&apos;s revisions</summary>
    [JsonPropertyName("traffic")]
    public IList<V20240301ContainerAppStatusConfigurationIngressTraffic>? Traffic { get; set; }

    /// <summary>Transport: Ingress transport protocol</summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

/// <summary>Container App Private Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationRegistries
{
    /// <summary>
    /// Identity: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned identities, use the
    /// full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>PasswordSecretRef: The name of the Secret that contains the registry login password</summary>
    [JsonPropertyName("passwordSecretRef")]
    public string? PasswordSecretRef { get; set; }

    /// <summary>Server: Container Registry Server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Username: Container Registry Username</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Secret definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationSecrets
{
    /// <summary>
    /// Identity: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>KeyVaultUrl: Azure Key Vault URL pointing to the secret referenced by the container app.</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary>Name: Secret Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Service: Container App to be a dev Container App Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfigurationService
{
    /// <summary>Type: Dev ContainerApp service type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration: Non versioned Container App configuration properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusConfiguration
{
    /// <summary>
    /// ActiveRevisionsMode: ActiveRevisionsMode controls how active revisions are handled for the Container app:
    /// &lt;list&gt; &lt;item&gt;Multiple: multiple revisions can be active.&lt;/item&gt; &lt;item&gt;Single: Only one revision can be active at a time.
    /// Revision weights can not be used in this mode. If no value if provided, this is the default.&lt;/item&gt; &lt;/list&gt;
    /// </summary>
    [JsonPropertyName("activeRevisionsMode")]
    public string? ActiveRevisionsMode { get; set; }

    /// <summary>Dapr: Dapr configuration for the Container App.</summary>
    [JsonPropertyName("dapr")]
    public V20240301ContainerAppStatusConfigurationDapr? Dapr { get; set; }

    /// <summary>Ingress: Ingress configurations.</summary>
    [JsonPropertyName("ingress")]
    public V20240301ContainerAppStatusConfigurationIngress? Ingress { get; set; }

    /// <summary>MaxInactiveRevisions: Optional. Max inactive revisions a Container App can have.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public int? MaxInactiveRevisions { get; set; }

    /// <summary>Registries: Collection of private container registry credentials for containers used by the Container app</summary>
    [JsonPropertyName("registries")]
    public IList<V20240301ContainerAppStatusConfigurationRegistries>? Registries { get; set; }

    /// <summary>Secrets: Collection of secrets used by a Container app</summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301ContainerAppStatusConfigurationSecrets>? Secrets { get; set; }

    /// <summary>Service: Container App to be a dev Container App Service</summary>
    [JsonPropertyName("service")]
    public V20240301ContainerAppStatusConfigurationService? Service { get; set; }
}

/// <summary>ExtendedLocation: The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Identity: managed identities for the Container App to interact with other Azure services without maintaining any secrets
/// or credentials in code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20240301ContainerAppStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusSystemData
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

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersProbesHttpGetHttpHeaders
{
    /// <summary>Name: The header field name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersProbesHttpGet
{
    /// <summary>Host: Host name to connect to, defaults to the pod IP. You probably want to set &quot;Host&quot; in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>HttpHeaders: Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V20240301ContainerAppStatusTemplateContainersProbesHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port: Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme: Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersProbesTcpSocket
{
    /// <summary>Host: Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Port: Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersProbes
{
    /// <summary>
    /// FailureThreshold: Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to
    /// 3. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V20240301ContainerAppStatusTemplateContainersProbesHttpGet? HttpGet { get; set; }

    /// <summary>
    /// InitialDelaySeconds: Number of seconds after the container has started before liveness probes are initiated. Minimum
    /// value is 1. Maximum value is 60.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>
    /// PeriodSeconds: How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is
    /// 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// SuccessThreshold: Minimum consecutive successes for the probe to be considered successful after having failed. Defaults
    /// to 1. Must be 1 for liveness and startup. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
    [JsonPropertyName("tcpSocket")]
    public V20240301ContainerAppStatusTemplateContainersProbesTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// TerminationGracePeriodSeconds: Optional duration in seconds the pod needs to terminate gracefully upon probe failure.
    /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the
    /// time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for
    /// your process. If this value is nil, the pod&apos;s terminationGracePeriodSeconds will be used. Otherwise, this value
    /// overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop
    /// immediately via the kill signal (no opportunity to shut down). This is an alpha field and requires enabling
    /// ProbeTerminationGracePeriod feature gate. Maximum value is 3600 seconds (1 hour)
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// TimeoutSeconds: Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum
    /// value is 240.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>Type: The type of probe.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>EphemeralStorage: Ephemeral Storage, e.g. &quot;1Gi&quot;</summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App container definition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301ContainerAppStatusTemplateContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probes: List of probes for the container.</summary>
    [JsonPropertyName("probes")]
    public IList<V20240301ContainerAppStatusTemplateContainersProbes>? Probes { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301ContainerAppStatusTemplateContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301ContainerAppStatusTemplateContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateInitContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateInitContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>EphemeralStorage: Ephemeral Storage, e.g. &quot;1Gi&quot;</summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateInitContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App base container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateInitContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301ContainerAppStatusTemplateInitContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301ContainerAppStatusTemplateInitContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301ContainerAppStatusTemplateInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesAzureQueueAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>AzureQueue: Azure Queue based scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesAzureQueue
{
    /// <summary>Auth: Authentication secrets for the queue scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppStatusTemplateScaleRulesAzureQueueAuth>? Auth { get; set; }

    /// <summary>QueueLength: Queue length.</summary>
    [JsonPropertyName("queueLength")]
    public int? QueueLength { get; set; }

    /// <summary>QueueName: Queue name.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesCustomAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Custom: Custom scale rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesCustom
{
    /// <summary>Auth: Authentication secrets for the custom scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppStatusTemplateScaleRulesCustomAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe custom scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Type: Type of the custom scale rule
    /// eg: azure-servicebus, redis etc.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesHttpAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Http: HTTP requests based scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesHttp
{
    /// <summary>Auth: Authentication secrets for the custom scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppStatusTemplateScaleRulesHttpAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe http scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesTcpAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Tcp: Tcp requests based scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRulesTcp
{
    /// <summary>Auth: Authentication secrets for the tcp scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301ContainerAppStatusTemplateScaleRulesTcpAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe tcp scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }
}

/// <summary>Container App container scaling rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScaleRules
{
    /// <summary>AzureQueue: Azure Queue based scaling.</summary>
    [JsonPropertyName("azureQueue")]
    public V20240301ContainerAppStatusTemplateScaleRulesAzureQueue? AzureQueue { get; set; }

    /// <summary>Custom: Custom scale rule.</summary>
    [JsonPropertyName("custom")]
    public V20240301ContainerAppStatusTemplateScaleRulesCustom? Custom { get; set; }

    /// <summary>Http: HTTP requests based scaling.</summary>
    [JsonPropertyName("http")]
    public V20240301ContainerAppStatusTemplateScaleRulesHttp? Http { get; set; }

    /// <summary>Name: Scale Rule Name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tcp: Tcp requests based scaling.</summary>
    [JsonPropertyName("tcp")]
    public V20240301ContainerAppStatusTemplateScaleRulesTcp? Tcp { get; set; }
}

/// <summary>Scale: Scaling properties for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateScale
{
    /// <summary>MaxReplicas: Optional. Maximum number of container replicas. Defaults to 10 if not set.</summary>
    [JsonPropertyName("maxReplicas")]
    public int? MaxReplicas { get; set; }

    /// <summary>MinReplicas: Optional. Minimum number of container replicas.</summary>
    [JsonPropertyName("minReplicas")]
    public int? MinReplicas { get; set; }

    /// <summary>Rules: Scaling rules.</summary>
    [JsonPropertyName("rules")]
    public IList<V20240301ContainerAppStatusTemplateScaleRules>? Rules { get; set; }
}

/// <summary>Configuration to bind a ContainerApp to a dev ContainerApp Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateServiceBinds
{
    /// <summary>Name: Name of the service bind</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ServiceId: Resource id of the target service</summary>
    [JsonPropertyName("serviceId")]
    public string? ServiceId { get; set; }
}

/// <summary>Secret to be added to volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateVolumesSecrets
{
    /// <summary>Path: Path to project secret to. If no path is provided, path defaults to name of secret listed in secretRef.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the secret value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }
}

/// <summary>Volume definitions for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplateVolumes
{
    /// <summary>MountOptions: Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>Name: Volume name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Secrets: List of secrets to be added in volume. If no secrets are provided, all secrets in collection will be added to
    /// volume.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301ContainerAppStatusTemplateVolumesSecrets>? Secrets { get; set; }

    /// <summary>StorageName: Name of storage resource. No need to provide for EmptyDir and Secret.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>StorageType: Storage type for the volume. If not provided, use EmptyDir.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>Template: Container App versioned application definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatusTemplate
{
    /// <summary>Containers: List of container definitions for the Container App.</summary>
    [JsonPropertyName("containers")]
    public IList<V20240301ContainerAppStatusTemplateContainers>? Containers { get; set; }

    /// <summary>InitContainers: List of specialized containers that run before app containers.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V20240301ContainerAppStatusTemplateInitContainers>? InitContainers { get; set; }

    /// <summary>RevisionSuffix: User friendly suffix that is appended to the revision name</summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>Scale: Scaling properties for the Container App.</summary>
    [JsonPropertyName("scale")]
    public V20240301ContainerAppStatusTemplateScale? Scale { get; set; }

    /// <summary>ServiceBinds: List of container app services bound to the app</summary>
    [JsonPropertyName("serviceBinds")]
    public IList<V20240301ContainerAppStatusTemplateServiceBinds>? ServiceBinds { get; set; }

    /// <summary>
    /// TerminationGracePeriodSeconds: Optional duration in seconds the Container App Instance needs to terminate gracefully.
    /// Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to
    /// shut down). If this value is nil, the default grace period will be used instead. Set this value longer than the expected
    /// cleanup time for your process. Defaults to 30 seconds.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>Volumes: List of volume definitions for the Container App.</summary>
    [JsonPropertyName("volumes")]
    public IList<V20240301ContainerAppStatusTemplateVolumes>? Volumes { get; set; }
}

/// <summary>Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301ContainerAppStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240301ContainerAppStatusConditions>? Conditions { get; set; }

    /// <summary>Configuration: Non versioned Container App configuration properties.</summary>
    [JsonPropertyName("configuration")]
    public V20240301ContainerAppStatusConfiguration? Configuration { get; set; }

    /// <summary>CustomDomainVerificationId: Id used to verify domain name ownership</summary>
    [JsonPropertyName("customDomainVerificationId")]
    public string? CustomDomainVerificationId { get; set; }

    /// <summary>EnvironmentId: Resource ID of environment.</summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>EventStreamEndpoint: The endpoint of the eventstream of the container app.</summary>
    [JsonPropertyName("eventStreamEndpoint")]
    public string? EventStreamEndpoint { get; set; }

    /// <summary>ExtendedLocation: The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20240301ContainerAppStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Identity: managed identities for the Container App to interact with other Azure services without maintaining any secrets
    /// or credentials in code.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20240301ContainerAppStatusIdentity? Identity { get; set; }

    /// <summary>LatestReadyRevisionName: Name of the latest ready revision of the Container App.</summary>
    [JsonPropertyName("latestReadyRevisionName")]
    public string? LatestReadyRevisionName { get; set; }

    /// <summary>LatestRevisionFqdn: Fully Qualified Domain Name of the latest revision of the Container App.</summary>
    [JsonPropertyName("latestRevisionFqdn")]
    public string? LatestRevisionFqdn { get; set; }

    /// <summary>LatestRevisionName: Name of the latest revision of the Container App.</summary>
    [JsonPropertyName("latestRevisionName")]
    public string? LatestRevisionName { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedBy: The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is
    /// managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is
    /// removed from the template since it is managed by another resource.
    /// </summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    /// <summary>ManagedEnvironmentId: Deprecated. Resource ID of the Container App&apos;s environment.</summary>
    [JsonPropertyName("managedEnvironmentId")]
    public string? ManagedEnvironmentId { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundIpAddresses: Outbound IP Addresses for container app.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public IList<string>? OutboundIpAddresses { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the Container App.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20240301ContainerAppStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Template: Container App versioned application definition.</summary>
    [JsonPropertyName("template")]
    public V20240301ContainerAppStatusTemplate? Template { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkloadProfileName: Workload profile name to pin for container app execution.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/ContainerApps.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240301ContainerApp : IKubernetesObject<V1ObjectMeta>, ISpec<V20240301ContainerAppSpec?>, IStatus<V20240301ContainerAppStatus?>
{
    public const string KubeApiVersion = "v20240301";
    public const string KubeKind = "ContainerApp";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "containerapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerApp";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240301ContainerAppSpec? Spec { get; set; }

    /// <summary>Container App.</summary>
    [JsonPropertyName("status")]
    public V20240301ContainerAppStatus? Status { get; set; }
}