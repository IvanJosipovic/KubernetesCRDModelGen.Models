#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>
/// TLSOption is the CRD implementation of a Traefik TLS Option, allowing to configure some parameters of the TLS connection.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#tls-options
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TLSOptionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TLSOption>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TLSOptionList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "tlsoptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TLSOptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TLSOption objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TLSOption> Items { get; set; }
}

/// <summary>ClientAuthType defines the client authentication type to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TLSOptionSpecClientAuthClientAuthTypeEnum>))]
public enum V1alpha1TLSOptionSpecClientAuthClientAuthTypeEnum
{
    [EnumMember(Value = "NoClientCert"), JsonStringEnumMemberName("NoClientCert")]
    NoClientCert,
    [EnumMember(Value = "RequestClientCert"), JsonStringEnumMemberName("RequestClientCert")]
    RequestClientCert,
    [EnumMember(Value = "RequireAnyClientCert"), JsonStringEnumMemberName("RequireAnyClientCert")]
    RequireAnyClientCert,
    [EnumMember(Value = "VerifyClientCertIfGiven"), JsonStringEnumMemberName("VerifyClientCertIfGiven")]
    VerifyClientCertIfGiven,
    [EnumMember(Value = "RequireAndVerifyClientCert"), JsonStringEnumMemberName("RequireAndVerifyClientCert")]
    RequireAndVerifyClientCert
}

/// <summary>ClientAuth defines the server&apos;s policy for TLS Client Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSOptionSpecClientAuth
{
    /// <summary>ClientAuthType defines the client authentication type to apply.</summary>
    [JsonPropertyName("clientAuthType")]
    public V1alpha1TLSOptionSpecClientAuthClientAuthTypeEnum? ClientAuthType { get; set; }

    /// <summary>SecretNames defines the names of the referenced Kubernetes Secret storing certificate details.</summary>
    [JsonPropertyName("secretNames")]
    public IList<string>? SecretNames { get; set; }
}

/// <summary>TLSOptionSpec defines the desired state of a TLSOption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSOptionSpec
{
    /// <summary>
    /// ALPNProtocols defines the list of supported application level protocols for the TLS handshake, in order of preference.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#alpn-protocols
    /// </summary>
    [JsonPropertyName("alpnProtocols")]
    public IList<string>? AlpnProtocols { get; set; }

    /// <summary>
    /// CipherSuites defines the list of supported cipher suites for TLS versions up to TLS 1.2.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#cipher-suites
    /// </summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>ClientAuth defines the server&apos;s policy for TLS Client Authentication.</summary>
    [JsonPropertyName("clientAuth")]
    public V1alpha1TLSOptionSpecClientAuth? ClientAuth { get; set; }

    /// <summary>
    /// CurvePreferences defines the preferred elliptic curves.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#curve-preferences
    /// </summary>
    [JsonPropertyName("curvePreferences")]
    public IList<string>? CurvePreferences { get; set; }

    /// <summary>DisableSessionTickets disables TLS session resumption via session tickets.</summary>
    [JsonPropertyName("disableSessionTickets")]
    public bool? DisableSessionTickets { get; set; }

    /// <summary>
    /// MaxVersion defines the maximum TLS version that Traefik will accept.
    /// Possible values: VersionTLS10, VersionTLS11, VersionTLS12, VersionTLS13.
    /// Default: None.
    /// </summary>
    [JsonPropertyName("maxVersion")]
    public string? MaxVersion { get; set; }

    /// <summary>
    /// MinVersion defines the minimum TLS version that Traefik will accept.
    /// Possible values: VersionTLS10, VersionTLS11, VersionTLS12, VersionTLS13.
    /// Default: VersionTLS10.
    /// </summary>
    [JsonPropertyName("minVersion")]
    public string? MinVersion { get; set; }

    /// <summary>
    /// PreferServerCipherSuites defines whether the server chooses a cipher suite among his own instead of among the client&apos;s.
    /// It is enabled automatically when minVersion or maxVersion is set.
    /// 
    /// Deprecated: https://github.com/golang/go/issues/45430
    /// </summary>
    [JsonPropertyName("preferServerCipherSuites")]
    public bool? PreferServerCipherSuites { get; set; }

    /// <summary>SniStrict defines whether Traefik allows connections from clients connections that do not specify a server_name extension.</summary>
    [JsonPropertyName("sniStrict")]
    public bool? SniStrict { get; set; }
}

/// <summary>
/// TLSOption is the CRD implementation of a Traefik TLS Option, allowing to configure some parameters of the TLS connection.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#tls-options
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TLSOption : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TLSOptionSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TLSOption";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "tlsoptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TLSOption";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TLSOptionSpec defines the desired state of a TLSOption.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1TLSOptionSpec Spec { get; set; }
}