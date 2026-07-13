#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notification.toolkit.fluxcd.io;
/// <summary>Provider is the Schema for the providers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3ProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta3Provider>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "ProviderList";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "providers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta3Provider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta3Provider> Items { get; set; }
}

/// <summary>
/// CertSecretRef specifies the Secret containing TLS certificates
/// for secure communication.
/// 
/// Supported configurations:
/// - CA-only: Server authentication (provide ca.crt only)
/// - mTLS: Mutual authentication (provide ca.crt + tls.crt + tls.key)
/// - Client-only: Client authentication with system CA (provide tls.crt + tls.key only)
/// 
/// Legacy keys &quot;caFile&quot;, &quot;certFile&quot;, &quot;keyFile&quot; are supported but deprecated. Use &quot;ca.crt&quot;, &quot;tls.crt&quot;, &quot;tls.key&quot; instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ProxySecretRef specifies the Secret containing the proxy configuration
/// for this Provider. The Secret should contain an &apos;address&apos; key with the
/// HTTP/S address of the proxy server. Optional &apos;username&apos; and &apos;password&apos;
/// keys can be provided for proxy authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpecProxySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretRef specifies the Secret containing the authentication
/// credentials for this Provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Type specifies which Provider implementation to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3ProviderSpecTypeEnum>))]
public enum V1beta3ProviderSpecTypeEnum
{
    [EnumMember(Value = "slack"), JsonStringEnumMemberName("slack")]
    Slack,
    [EnumMember(Value = "discord"), JsonStringEnumMemberName("discord")]
    Discord,
    [EnumMember(Value = "msteams"), JsonStringEnumMemberName("msteams")]
    Msteams,
    [EnumMember(Value = "rocket"), JsonStringEnumMemberName("rocket")]
    Rocket,
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    Generic,
    [EnumMember(Value = "generic-hmac"), JsonStringEnumMemberName("generic-hmac")]
    GenericHmac,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github,
    [EnumMember(Value = "gitlab"), JsonStringEnumMemberName("gitlab")]
    Gitlab,
    [EnumMember(Value = "gitea"), JsonStringEnumMemberName("gitea")]
    Gitea,
    [EnumMember(Value = "giteapullrequestcomment"), JsonStringEnumMemberName("giteapullrequestcomment")]
    Giteapullrequestcomment,
    [EnumMember(Value = "bitbucketserver"), JsonStringEnumMemberName("bitbucketserver")]
    Bitbucketserver,
    [EnumMember(Value = "bitbucket"), JsonStringEnumMemberName("bitbucket")]
    Bitbucket,
    [EnumMember(Value = "azuredevops"), JsonStringEnumMemberName("azuredevops")]
    Azuredevops,
    [EnumMember(Value = "googlechat"), JsonStringEnumMemberName("googlechat")]
    Googlechat,
    [EnumMember(Value = "googlepubsub"), JsonStringEnumMemberName("googlepubsub")]
    Googlepubsub,
    [EnumMember(Value = "webex"), JsonStringEnumMemberName("webex")]
    Webex,
    [EnumMember(Value = "sentry"), JsonStringEnumMemberName("sentry")]
    Sentry,
    [EnumMember(Value = "azureeventhub"), JsonStringEnumMemberName("azureeventhub")]
    Azureeventhub,
    [EnumMember(Value = "telegram"), JsonStringEnumMemberName("telegram")]
    Telegram,
    [EnumMember(Value = "lark"), JsonStringEnumMemberName("lark")]
    Lark,
    [EnumMember(Value = "matrix"), JsonStringEnumMemberName("matrix")]
    Matrix,
    [EnumMember(Value = "opsgenie"), JsonStringEnumMemberName("opsgenie")]
    Opsgenie,
    [EnumMember(Value = "alertmanager"), JsonStringEnumMemberName("alertmanager")]
    Alertmanager,
    [EnumMember(Value = "grafana"), JsonStringEnumMemberName("grafana")]
    Grafana,
    [EnumMember(Value = "githubdispatch"), JsonStringEnumMemberName("githubdispatch")]
    Githubdispatch,
    [EnumMember(Value = "githubpullrequestcomment"), JsonStringEnumMemberName("githubpullrequestcomment")]
    Githubpullrequestcomment,
    [EnumMember(Value = "gitlabmergerequestcomment"), JsonStringEnumMemberName("gitlabmergerequestcomment")]
    Gitlabmergerequestcomment,
    [EnumMember(Value = "pagerduty"), JsonStringEnumMemberName("pagerduty")]
    Pagerduty,
    [EnumMember(Value = "datadog"), JsonStringEnumMemberName("datadog")]
    Datadog,
    [EnumMember(Value = "nats"), JsonStringEnumMemberName("nats")]
    Nats,
    [EnumMember(Value = "zulip"), JsonStringEnumMemberName("zulip")]
    Zulip,
    [EnumMember(Value = "otel"), JsonStringEnumMemberName("otel")]
    Otel
}

/// <summary>ProviderSpec defines the desired state of the Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3ProviderSpec
{
    /// <summary>
    /// Address specifies the endpoint, in a generic sense, to where alerts are sent.
    /// What kind of endpoint depends on the specific Provider type being used.
    /// For the generic Provider, for example, this is an HTTP/S address.
    /// For other Provider types this could be a project ID or a namespace.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// CertSecretRef specifies the Secret containing TLS certificates
    /// for secure communication.
    /// 
    /// Supported configurations:
    /// - CA-only: Server authentication (provide ca.crt only)
    /// - mTLS: Mutual authentication (provide ca.crt + tls.crt + tls.key)
    /// - Client-only: Client authentication with system CA (provide tls.crt + tls.key only)
    /// 
    /// Legacy keys &quot;caFile&quot;, &quot;certFile&quot;, &quot;keyFile&quot; are supported but deprecated. Use &quot;ca.crt&quot;, &quot;tls.crt&quot;, &quot;tls.key&quot; instead.
    /// </summary>
    [JsonPropertyName("certSecretRef")]
    public V1beta3ProviderSpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>Channel specifies the destination channel where events should be posted.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// CommitStatusExpr is a CEL expression that evaluates to a string value
    /// that can be used to generate a custom commit status message for use
    /// with eligible Provider types (github, gitlab, gitea, bitbucketserver,
    /// bitbucket, azuredevops). Supported variables are: event, provider,
    /// and alert.
    /// </summary>
    [JsonPropertyName("commitStatusExpr")]
    public string? CommitStatusExpr { get; set; }

    /// <summary>
    /// Interval at which to reconcile the Provider with its Secret references.
    /// Deprecated and not used in v1beta3.
    /// </summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>
    /// Proxy the HTTP/S address of the proxy server.
    /// Deprecated: Use ProxySecretRef instead. Will be removed in v1.
    /// </summary>
    [JsonPropertyName("proxy")]
    public string? Proxy { get; set; }

    /// <summary>
    /// ProxySecretRef specifies the Secret containing the proxy configuration
    /// for this Provider. The Secret should contain an &apos;address&apos; key with the
    /// HTTP/S address of the proxy server. Optional &apos;username&apos; and &apos;password&apos;
    /// keys can be provided for proxy authentication.
    /// </summary>
    [JsonPropertyName("proxySecretRef")]
    public V1beta3ProviderSpecProxySecretRef? ProxySecretRef { get; set; }

    /// <summary>
    /// SecretRef specifies the Secret containing the authentication
    /// credentials for this Provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta3ProviderSpecSecretRef? SecretRef { get; set; }

    /// <summary>
    /// ServiceAccountName is the name of the Kubernetes ServiceAccount used to
    /// authenticate with cloud provider services through workload identity.
    /// This enables multi-tenant authentication without storing static credentials.
    /// 
    /// Supported provider types: azureeventhub, azuredevops, googlepubsub
    /// 
    /// When specified, the controller will:
    /// 1. Create an OIDC token for the specified ServiceAccount
    /// 2. Exchange it for cloud provider credentials via STS
    /// 3. Use the obtained credentials for API authentication
    /// 
    /// When unspecified, controller-level authentication is used (single-tenant).
    /// 
    /// An error is thrown if static credentials are also defined in SecretRef.
    /// This field requires the ObjectLevelWorkloadIdentity feature gate to be enabled.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend subsequent
    /// events handling for this Provider.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>Timeout for sending alerts to the Provider.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Type specifies which Provider implementation to use.</summary>
    [JsonPropertyName("type")]
    public required V1beta3ProviderSpecTypeEnum Type { get; set; }

    /// <summary>Username specifies the name under which events are posted.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Provider is the Schema for the providers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3Provider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta3ProviderSpec?>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "Provider";
    public const string KubeGroup = "notification.toolkit.fluxcd.io";
    public const string KubePluralName = "providers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notification.toolkit.fluxcd.io/v1beta3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Provider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProviderSpec defines the desired state of the Provider.</summary>
    [JsonPropertyName("spec")]
    public V1beta3ProviderSpec? Spec { get; set; }
}