#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecurityClientTLSPolicy is the Schema for the NetworkSecurityClientTLSPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkSecurityClientTLSPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkSecurityClientTLSPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkSecurityClientTLSPolicyList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityclienttlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityClientTLSPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NetworkSecurityClientTLSPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NetworkSecurityClientTLSPolicy> Items { get; set; }
}

/// <summary>Optional. The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecClientCertificateCertificateProviderInstance
{
    /// <summary>Required. Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public required string PluginInstance { get; set; }
}

/// <summary>Optional. gRPC specific configuration to access the gRPC server to obtain the cert and private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecClientCertificateGrpcEndpoint
{
    /// <summary>Required. The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public required string TargetUri { get; set; }
}

/// <summary>Optional. Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecClientCertificate
{
    /// <summary>Optional. The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1NetworkSecurityClientTLSPolicySpecClientCertificateCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>Optional. gRPC specific configuration to access the gRPC server to obtain the cert and private key.</summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1NetworkSecurityClientTLSPolicySpecClientCertificateGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecServerValidationCaCertificateProviderInstance
{
    /// <summary>Required. Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &quot;google_cloud_private_spiffe&quot; to use Certificate Authority Service certificate provider instance.</summary>
    [JsonPropertyName("pluginInstance")]
    public required string PluginInstance { get; set; }
}

/// <summary>Optional. gRPC specific configuration to access the gRPC server to obtain the CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecServerValidationCaGrpcEndpoint
{
    /// <summary>Required. The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &quot;unix:&quot;.</summary>
    [JsonPropertyName("targetUri")]
    public required string TargetUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpecServerValidationCa
{
    /// <summary>Optional. The certificate provider instance specification that will be passed to the data plane, which will be used to load necessary credential information.</summary>
    [JsonPropertyName("certificateProviderInstance")]
    public V1beta1NetworkSecurityClientTLSPolicySpecServerValidationCaCertificateProviderInstance? CertificateProviderInstance { get; set; }

    /// <summary>Optional. gRPC specific configuration to access the gRPC server to obtain the CA certificate.</summary>
    [JsonPropertyName("grpcEndpoint")]
    public V1beta1NetworkSecurityClientTLSPolicySpecServerValidationCaGrpcEndpoint? GrpcEndpoint { get; set; }
}

/// <summary>NetworkSecurityClientTLSPolicySpec defines the desired state of NetworkSecurityClientTLSPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicySpec
{
    /// <summary>Optional. Defines a mechanism to provision client identity (public and private keys) for peer to peer authentication. The presence of this dictates mTLS.</summary>
    [JsonPropertyName("clientCertificate")]
    public V1beta1NetworkSecurityClientTLSPolicySpecClientCertificate? ClientCertificate { get; set; }

    /// <summary>Optional. Free-text description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1NetworkSecurityClientTLSPolicySpecProjectRef? ProjectRef { get; set; }

    /// <summary>The NetworkSecurityClientTLSPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Defines the mechanism to obtain the Certificate Authority certificate to validate the server certificate. If empty, client does not validate the server certificate.</summary>
    [JsonPropertyName("serverValidationCa")]
    public IList<V1beta1NetworkSecurityClientTLSPolicySpecServerValidationCa>? ServerValidationCa { get; set; }

    /// <summary>Optional. Server Name Indication string to present to the server during TLS handshake. E.g: &quot;secure.example.com&quot;.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>NetworkSecurityClientTLSPolicyStatus defines the config connector machine state of NetworkSecurityClientTLSPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityClientTLSPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkSecurityClientTLSPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityClientTLSPolicy is the Schema for the NetworkSecurityClientTLSPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkSecurityClientTLSPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkSecurityClientTLSPolicySpec>, IStatus<V1beta1NetworkSecurityClientTLSPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkSecurityClientTLSPolicy";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityclienttlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityClientTLSPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityClientTLSPolicySpec defines the desired state of NetworkSecurityClientTLSPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NetworkSecurityClientTLSPolicySpec Spec { get; set; }

    /// <summary>NetworkSecurityClientTLSPolicyStatus defines the config connector machine state of NetworkSecurityClientTLSPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkSecurityClientTLSPolicyStatus? Status { get; set; }
}