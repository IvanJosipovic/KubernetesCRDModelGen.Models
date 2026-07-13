#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.upbound.io;
/// <summary>VirtualGateway is the Schema for the VirtualGateways API. Provides an AWS App Mesh virtual gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VirtualGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta2VirtualGateway>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VirtualGatewayList";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2VirtualGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2VirtualGateway> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecDeletionPolicyEnum>))]
public enum V1beta2VirtualGatewaySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Default client policy for virtual gateway backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicyTls? Tls { get; set; }
}

/// <summary>Defaults for backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecBackendDefaults
{
    /// <summary>Default client policy for virtual gateway backends.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaultsClientPolicy? ClientPolicy { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary>Connection pool information for HTTP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

/// <summary>Connection pool information for HTTP2 listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary>Connection pool information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPoolGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPoolHttp2? Http2 { get; set; }
}

/// <summary>Health check information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual gateway unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>Port mapping information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolutionEnum>))]
public enum V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolveEnum>))]
public enum V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcmCertificateArnSelector? CertificateArnSelector { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListenerTls
{
    /// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsCertificate? Certificate { get; set; }

    /// <summary>Listener&apos;s TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerConnectionPool? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerHealthCheck? HealthCheck { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerPortMapping? PortMapping { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualGatewaySpecForProviderSpecListenerTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The specified format for the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLogFileFormat? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Access log configuration for a virtual gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLogFile? File { get; set; }
}

/// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual gateway.</summary>
    [JsonPropertyName("accessLog")]
    public V1beta2VirtualGatewaySpecForProviderSpecLoggingAccessLog? AccessLog { get; set; }
}

/// <summary>Virtual gateway specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProviderSpec
{
    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public V1beta2VirtualGatewaySpecForProviderSpecBackendDefaults? BackendDefaults { get; set; }

    /// <summary>Listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify one listener.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2VirtualGatewaySpecForProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
    [JsonPropertyName("logging")]
    public V1beta2VirtualGatewaySpecForProviderSpecLogging? Logging { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecForProvider
{
    /// <summary>Name of the service mesh in which to create the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Virtual gateway specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2VirtualGatewaySpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Default client policy for virtual gateway backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicyTls? Tls { get; set; }
}

/// <summary>Defaults for backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaults
{
    /// <summary>Default client policy for virtual gateway backends.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaultsClientPolicy? ClientPolicy { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary>Connection pool information for HTTP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

/// <summary>Connection pool information for HTTP2 listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary>Connection pool information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPoolGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPoolHttp2? Http2 { get; set; }
}

/// <summary>Health check information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual gateway unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>Port mapping information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolutionEnum>))]
public enum V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolveEnum>))]
public enum V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcmCertificateArnSelector? CertificateArnSelector { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListenerTls
{
    /// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsCertificate? Certificate { get; set; }

    /// <summary>Listener&apos;s TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerConnectionPool? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerHealthCheck? HealthCheck { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerPortMapping? PortMapping { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualGatewaySpecInitProviderSpecListenerTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The specified format for the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLogFileFormat? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Access log configuration for a virtual gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLogFile? File { get; set; }
}

/// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual gateway.</summary>
    [JsonPropertyName("accessLog")]
    public V1beta2VirtualGatewaySpecInitProviderSpecLoggingAccessLog? AccessLog { get; set; }
}

/// <summary>Virtual gateway specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProviderSpec
{
    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public V1beta2VirtualGatewaySpecInitProviderSpecBackendDefaults? BackendDefaults { get; set; }

    /// <summary>Listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify one listener.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2VirtualGatewaySpecInitProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
    [JsonPropertyName("logging")]
    public V1beta2VirtualGatewaySpecInitProviderSpecLogging? Logging { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Virtual gateway specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2VirtualGatewaySpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecManagementPoliciesEnum>))]
public enum V1beta2VirtualGatewaySpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2VirtualGatewaySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualGatewaySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2VirtualGatewaySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualGatewaySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualGatewaySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>VirtualGatewaySpec defines the desired state of VirtualGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewaySpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2VirtualGatewaySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2VirtualGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2VirtualGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2VirtualGatewaySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2VirtualGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2VirtualGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Default client policy for virtual gateway backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicyTls? Tls { get; set; }
}

/// <summary>Defaults for backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaults
{
    /// <summary>Default client policy for virtual gateway backends.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaultsClientPolicy? ClientPolicy { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary>Connection pool information for HTTP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

/// <summary>Connection pool information for HTTP2 listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

/// <summary>Connection pool information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPoolGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPoolHttp2? Http2 { get; set; }
}

/// <summary>Health check information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual gateway unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>Port mapping information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificateAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a virtual gateway&apos;s listener&apos;s Transport Layer Security (TLS) validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListenerTls
{
    /// <summary>Virtual gateway&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsCertificate? Certificate { get; set; }

    /// <summary>Listener&apos;s TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerConnectionPool? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerHealthCheck? HealthCheck { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerPortMapping? PortMapping { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualGatewayStatusAtProviderSpecListenerTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The specified format for the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLogFileFormat? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Access log configuration for a virtual gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLogFile? File { get; set; }
}

/// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual gateway.</summary>
    [JsonPropertyName("accessLog")]
    public V1beta2VirtualGatewayStatusAtProviderSpecLoggingAccessLog? AccessLog { get; set; }
}

/// <summary>Virtual gateway specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProviderSpec
{
    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public V1beta2VirtualGatewayStatusAtProviderSpecBackendDefaults? BackendDefaults { get; set; }

    /// <summary>Listeners that the mesh endpoint is expected to receive inbound traffic from. You can specify one listener.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2VirtualGatewayStatusAtProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual gateway.</summary>
    [JsonPropertyName("logging")]
    public V1beta2VirtualGatewayStatusAtProviderSpecLogging? Logging { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusAtProvider
{
    /// <summary>ARN of the virtual gateway.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the virtual gateway.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the virtual gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the virtual gateway.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual gateway. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner&apos;s AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Virtual gateway specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2VirtualGatewayStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>VirtualGatewayStatus defines the observed state of VirtualGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualGatewayStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2VirtualGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2VirtualGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualGateway is the Schema for the VirtualGateways API. Provides an AWS App Mesh virtual gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VirtualGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2VirtualGatewaySpec>, IStatus<V1beta2VirtualGatewayStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VirtualGateway";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualGatewaySpec defines the desired state of VirtualGateway</summary>
    [JsonPropertyName("spec")]
    public required V1beta2VirtualGatewaySpec Spec { get; set; }

    /// <summary>VirtualGatewayStatus defines the observed state of VirtualGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta2VirtualGatewayStatus? Status { get; set; }
}