#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.gcp.upbound.io;
/// <summary>ServerTLSPolicy is the Schema for the ServerTLSPolicys API. ServerTlsPolicy is a resource that specifies how a server should authenticate incoming requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServerTLSPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServerTLSPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServerTLSPolicyList";
    public const string KubeGroup = "networksecurity.gcp.upbound.io";
    public const string KubePluralName = "servertlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerTLSPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ServerTLSPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ServerTLSPolicy> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServerTLSPolicySpecDeletionPolicyEnum>))]
public enum V1beta1ServerTLSPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
/// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderMtlsPolicyClientValidationCaCertificateProviderInstance
{
    /// <summary>Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string? PluginInstance { get; set; }
}

/// <summary>
/// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderMtlsPolicyClientValidationCaGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderMtlsPolicyClientValidationCa
{
    /// <summary>
    /// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
    /// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ServerTLSPolicySpecForProviderMtlsPolicyClientValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ServerTLSPolicySpecForProviderMtlsPolicyClientValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>
/// This field is required if the policy is used with external HTTPS load balancers. This field can be empty for Traffic Director.
/// Defines a mechanism to provision peer validation certificates for peer to peer authentication (Mutual TLS - mTLS). If not specified, client certificate will not be requested. The connection is treated as TLS and not mTLS. If allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderMtlsPolicy
{
    /// <summary>
    /// Required if the policy is to be used with Traffic Director. For external HTTPS load balancers it must be empty.
    /// Defines the mechanism to obtain the Certificate Authority certificate to validate the client certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientValidationCa")]
    public IList<V1beta1ServerTLSPolicySpecForProviderMtlsPolicyClientValidationCa>? ClientValidationCa { get; set; }

    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty.
    /// Possible values are: CLIENT_VALIDATION_MODE_UNSPECIFIED, ALLOW_INVALID_OR_MISSING_CLIENT_CERT, REJECT_INVALID.
    /// </summary>
    [JsonPropertyName("clientValidationMode")]
    public string? ClientValidationMode { get; set; }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    [JsonPropertyName("clientValidationTrustConfig")]
    public string? ClientValidationTrustConfig { get; set; }
}

/// <summary>
/// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
/// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderServerCertificateCertificateProviderInstance
{
    /// <summary>Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string? PluginInstance { get; set; }
}

/// <summary>
/// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderServerCertificateGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

/// <summary>
/// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProviderServerCertificate
{
    /// <summary>
    /// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
    /// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ServerTLSPolicySpecForProviderServerCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ServerTLSPolicySpecForProviderServerCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecForProvider
{
    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    [JsonPropertyName("allowOpen")]
    public bool? AllowOpen { get; set; }

    /// <summary>A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Set of label tags associated with the ServerTlsPolicy resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The location of the server tls policy.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// This field is required if the policy is used with external HTTPS load balancers. This field can be empty for Traffic Director.
    /// Defines a mechanism to provision peer validation certificates for peer to peer authentication (Mutual TLS - mTLS). If not specified, client certificate will not be requested. The connection is treated as TLS and not mTLS. If allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mtlsPolicy")]
    public V1beta1ServerTLSPolicySpecForProviderMtlsPolicy? MtlsPolicy { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serverCertificate")]
    public V1beta1ServerTLSPolicySpecForProviderServerCertificate? ServerCertificate { get; set; }
}

/// <summary>
/// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
/// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderMtlsPolicyClientValidationCaCertificateProviderInstance
{
    /// <summary>Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string? PluginInstance { get; set; }
}

/// <summary>
/// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderMtlsPolicyClientValidationCaGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderMtlsPolicyClientValidationCa
{
    /// <summary>
    /// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
    /// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ServerTLSPolicySpecInitProviderMtlsPolicyClientValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ServerTLSPolicySpecInitProviderMtlsPolicyClientValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>
/// This field is required if the policy is used with external HTTPS load balancers. This field can be empty for Traffic Director.
/// Defines a mechanism to provision peer validation certificates for peer to peer authentication (Mutual TLS - mTLS). If not specified, client certificate will not be requested. The connection is treated as TLS and not mTLS. If allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderMtlsPolicy
{
    /// <summary>
    /// Required if the policy is to be used with Traffic Director. For external HTTPS load balancers it must be empty.
    /// Defines the mechanism to obtain the Certificate Authority certificate to validate the client certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientValidationCa")]
    public IList<V1beta1ServerTLSPolicySpecInitProviderMtlsPolicyClientValidationCa>? ClientValidationCa { get; set; }

    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty.
    /// Possible values are: CLIENT_VALIDATION_MODE_UNSPECIFIED, ALLOW_INVALID_OR_MISSING_CLIENT_CERT, REJECT_INVALID.
    /// </summary>
    [JsonPropertyName("clientValidationMode")]
    public string? ClientValidationMode { get; set; }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    [JsonPropertyName("clientValidationTrustConfig")]
    public string? ClientValidationTrustConfig { get; set; }
}

/// <summary>
/// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
/// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderServerCertificateCertificateProviderInstance
{
    /// <summary>Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string? PluginInstance { get; set; }
}

/// <summary>
/// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderServerCertificateGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

/// <summary>
/// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProviderServerCertificate
{
    /// <summary>
    /// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
    /// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ServerTLSPolicySpecInitProviderServerCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ServerTLSPolicySpecInitProviderServerCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecInitProvider
{
    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    [JsonPropertyName("allowOpen")]
    public bool? AllowOpen { get; set; }

    /// <summary>A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Set of label tags associated with the ServerTlsPolicy resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// This field is required if the policy is used with external HTTPS load balancers. This field can be empty for Traffic Director.
    /// Defines a mechanism to provision peer validation certificates for peer to peer authentication (Mutual TLS - mTLS). If not specified, client certificate will not be requested. The connection is treated as TLS and not mTLS. If allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mtlsPolicy")]
    public V1beta1ServerTLSPolicySpecInitProviderMtlsPolicy? MtlsPolicy { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serverCertificate")]
    public V1beta1ServerTLSPolicySpecInitProviderServerCertificate? ServerCertificate { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServerTLSPolicySpecManagementPoliciesEnum>))]
public enum V1beta1ServerTLSPolicySpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServerTLSPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ServerTLSPolicySpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServerTLSPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ServerTLSPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ServerTLSPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ServerTLSPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServerTLSPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ServerTLSPolicySpec defines the desired state of ServerTLSPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicySpec
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
    public V1beta1ServerTLSPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ServerTLSPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1ServerTLSPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ServerTLSPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServerTLSPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServerTLSPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
/// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicyClientValidationCaCertificateProviderInstance
{
    /// <summary>Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string? PluginInstance { get; set; }
}

/// <summary>
/// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicyClientValidationCaGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicyClientValidationCa
{
    /// <summary>
    /// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
    /// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicyClientValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicyClientValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>
/// This field is required if the policy is used with external HTTPS load balancers. This field can be empty for Traffic Director.
/// Defines a mechanism to provision peer validation certificates for peer to peer authentication (Mutual TLS - mTLS). If not specified, client certificate will not be requested. The connection is treated as TLS and not mTLS. If allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicy
{
    /// <summary>
    /// Required if the policy is to be used with Traffic Director. For external HTTPS load balancers it must be empty.
    /// Defines the mechanism to obtain the Certificate Authority certificate to validate the client certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientValidationCa")]
    public IList<V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicyClientValidationCa>? ClientValidationCa { get; set; }

    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty.
    /// Possible values are: CLIENT_VALIDATION_MODE_UNSPECIFIED, ALLOW_INVALID_OR_MISSING_CLIENT_CERT, REJECT_INVALID.
    /// </summary>
    [JsonPropertyName("clientValidationMode")]
    public string? ClientValidationMode { get; set; }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    [JsonPropertyName("clientValidationTrustConfig")]
    public string? ClientValidationTrustConfig { get; set; }
}

/// <summary>
/// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
/// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderServerCertificateCertificateProviderInstance
{
    /// <summary>Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public string? PluginInstance { get; set; }
}

/// <summary>
/// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderServerCertificateGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

/// <summary>
/// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProviderServerCertificate
{
    /// <summary>
    /// Optional if policy is to be used with Traffic Director. For external HTTPS load balancer must be empty.
    /// Defines a mechanism to provision server identity (public and private keys). Cannot be combined with allowOpen as a permissive mode that allows both plain text and TLS is not supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ServerTLSPolicyStatusAtProviderServerCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ServerTLSPolicyStatusAtProviderServerCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusAtProvider
{
    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    [JsonPropertyName("allowOpen")]
    public bool? AllowOpen { get; set; }

    /// <summary>Time the ServerTlsPolicy was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/serverTlsPolicies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Set of label tags associated with the ServerTlsPolicy resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The location of the server tls policy.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// This field is required if the policy is used with external HTTPS load balancers. This field can be empty for Traffic Director.
    /// Defines a mechanism to provision peer validation certificates for peer to peer authentication (Mutual TLS - mTLS). If not specified, client certificate will not be requested. The connection is treated as TLS and not mTLS. If allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mtlsPolicy")]
    public V1beta1ServerTLSPolicyStatusAtProviderMtlsPolicy? MtlsPolicy { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serverCertificate")]
    public V1beta1ServerTLSPolicyStatusAtProviderServerCertificate? ServerCertificate { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Time the ServerTlsPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatusConditions
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

/// <summary>ServerTLSPolicyStatus defines the observed state of ServerTLSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServerTLSPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ServerTLSPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServerTLSPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ServerTLSPolicy is the Schema for the ServerTLSPolicys API. ServerTlsPolicy is a resource that specifies how a server should authenticate incoming requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServerTLSPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServerTLSPolicySpec>, IStatus<V1beta1ServerTLSPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServerTLSPolicy";
    public const string KubeGroup = "networksecurity.gcp.upbound.io";
    public const string KubePluralName = "servertlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerTLSPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServerTLSPolicySpec defines the desired state of ServerTLSPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ServerTLSPolicySpec Spec { get; set; }

    /// <summary>ServerTLSPolicyStatus defines the observed state of ServerTLSPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServerTLSPolicyStatus? Status { get; set; }
}