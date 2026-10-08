#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.gcp.m.upbound.io;
/// <summary>ClientTLSPolicy is the Schema for the ClientTLSPolicys API. ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClientTLSPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ClientTLSPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClientTLSPolicyList";
    public const string KubeGroup = "networksecurity.gcp.m.upbound.io";
    public const string KubePluralName = "clienttlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClientTLSPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ClientTLSPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ClientTLSPolicy> Items { get; set; }
}

/// <summary>
/// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecForProviderClientCertificateCertificateProviderInstance
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
public partial class V1beta1ClientTLSPolicySpecForProviderClientCertificateGrpcEndpoint
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
public partial class V1beta1ClientTLSPolicySpecForProviderClientCertificate
{
    /// <summary>
    /// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ClientTLSPolicySpecForProviderClientCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ClientTLSPolicySpecForProviderClientCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>
/// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecForProviderServerValidationCaCertificateProviderInstance
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
public partial class V1beta1ClientTLSPolicySpecForProviderServerValidationCaGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecForProviderServerValidationCa
{
    /// <summary>
    /// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ClientTLSPolicySpecForProviderServerValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ClientTLSPolicySpecForProviderServerValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecForProvider
{
    /// <summary>
    /// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientCertificate")]
    public V1beta1ClientTLSPolicySpecForProviderClientCertificate? ClientCertificate { get; set; }

    /// <summary>A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Set of label tags associated with the ClientTlsPolicy resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The location of the client tls policy.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Defines the mechanism to obtain the Certificate Authority certificate to validate the server certificate. If empty, client does not validate the server certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serverValidationCa")]
    public IList<V1beta1ClientTLSPolicySpecForProviderServerValidationCa>? ServerValidationCa { get; set; }

    /// <summary>Server Name Indication string to present to the server during TLS handshake. E.g: &quot;secure.example.com&quot;.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }
}

/// <summary>
/// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecInitProviderClientCertificateCertificateProviderInstance
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
public partial class V1beta1ClientTLSPolicySpecInitProviderClientCertificateGrpcEndpoint
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
public partial class V1beta1ClientTLSPolicySpecInitProviderClientCertificate
{
    /// <summary>
    /// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ClientTLSPolicySpecInitProviderClientCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ClientTLSPolicySpecInitProviderClientCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>
/// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecInitProviderServerValidationCaCertificateProviderInstance
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
public partial class V1beta1ClientTLSPolicySpecInitProviderServerValidationCaGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecInitProviderServerValidationCa
{
    /// <summary>
    /// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ClientTLSPolicySpecInitProviderServerValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ClientTLSPolicySpecInitProviderServerValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
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
public partial class V1beta1ClientTLSPolicySpecInitProvider
{
    /// <summary>
    /// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientCertificate")]
    public V1beta1ClientTLSPolicySpecInitProviderClientCertificate? ClientCertificate { get; set; }

    /// <summary>A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Set of label tags associated with the ClientTlsPolicy resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Defines the mechanism to obtain the Certificate Authority certificate to validate the server certificate. If empty, client does not validate the server certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serverValidationCa")]
    public IList<V1beta1ClientTLSPolicySpecInitProviderServerValidationCa>? ServerValidationCa { get; set; }

    /// <summary>Server Name Indication string to present to the server during TLS handshake. E.g: &quot;secure.example.com&quot;.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClientTLSPolicySpecManagementPoliciesEnum>))]
public enum V1beta1ClientTLSPolicySpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ClientTLSPolicySpec defines the desired state of ClientTLSPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ClientTLSPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1ClientTLSPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClientTLSPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClientTLSPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClientTLSPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicyStatusAtProviderClientCertificateCertificateProviderInstance
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
public partial class V1beta1ClientTLSPolicyStatusAtProviderClientCertificateGrpcEndpoint
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
public partial class V1beta1ClientTLSPolicyStatusAtProviderClientCertificate
{
    /// <summary>
    /// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ClientTLSPolicyStatusAtProviderClientCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ClientTLSPolicyStatusAtProviderClientCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>
/// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicyStatusAtProviderServerValidationCaCertificateProviderInstance
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
public partial class V1beta1ClientTLSPolicyStatusAtProviderServerValidationCaGrpcEndpoint
{
    /// <summary>The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public string? TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicyStatusAtProviderServerValidationCa
{
    /// <summary>
    /// The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1ClientTLSPolicyStatusAtProviderServerValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>
    /// gRPC specific configuration to access the gRPC server to obtain the cert and private key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1ClientTLSPolicyStatusAtProviderServerValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicyStatusAtProvider
{
    /// <summary>
    /// Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("clientCertificate")]
    public V1beta1ClientTLSPolicyStatusAtProviderClientCertificate? ClientCertificate { get; set; }

    /// <summary>Time the ClientTlsPolicy was created in UTC.</summary>
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

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/clientTlsPolicies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Set of label tags associated with the ClientTlsPolicy resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The location of the client tls policy.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Defines the mechanism to obtain the Certificate Authority certificate to validate the server certificate. If empty, client does not validate the server certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serverValidationCa")]
    public IList<V1beta1ClientTLSPolicyStatusAtProviderServerValidationCa>? ServerValidationCa { get; set; }

    /// <summary>Server Name Indication string to present to the server during TLS handshake. E.g: &quot;secure.example.com&quot;.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Time the ClientTlsPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicyStatusConditions
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

/// <summary>ClientTLSPolicyStatus defines the observed state of ClientTLSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClientTLSPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ClientTLSPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClientTLSPolicyStatusConditions>? Conditions { get; set; }

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

/// <summary>ClientTLSPolicy is the Schema for the ClientTLSPolicys API. ClientTlsPolicy is a resource that specifies how a client should authenticate connections to backends of a service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClientTLSPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClientTLSPolicySpec>, IStatus<V1beta1ClientTLSPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClientTLSPolicy";
    public const string KubeGroup = "networksecurity.gcp.m.upbound.io";
    public const string KubePluralName = "clienttlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClientTLSPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClientTLSPolicySpec defines the desired state of ClientTLSPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ClientTLSPolicySpec Spec { get; set; }

    /// <summary>ClientTLSPolicyStatus defines the observed state of ClientTLSPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClientTLSPolicyStatus? Status { get; set; }
}