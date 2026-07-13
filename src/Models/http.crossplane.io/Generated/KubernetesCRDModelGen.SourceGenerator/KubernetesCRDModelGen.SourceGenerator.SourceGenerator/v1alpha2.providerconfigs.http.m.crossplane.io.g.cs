#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.http.m.crossplane.io;
/// <summary>A ProviderConfig configures a Http provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2ProviderConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha2ProviderConfig>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "ProviderConfigList";
    public const string KubeGroup = "http.m.crossplane.io";
    public const string KubePluralName = "providerconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "http.m.crossplane.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProviderConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha2ProviderConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha2ProviderConfig> Items { get; set; }
}

/// <summary>
/// Env is a reference to an environment variable that contains credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Fs is a reference to a filesystem location that contains credentials that
/// must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>
/// A SecretRef is a reference to a secret key that contains the credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Source of the provider credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2ProviderConfigSpecCredentialsSourceEnum>))]
public enum V1alpha2ProviderConfigSpecCredentialsSourceEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret,
    [EnumMember(Value = "InjectedIdentity"), JsonStringEnumMemberName("InjectedIdentity")]
    InjectedIdentity,
    [EnumMember(Value = "Environment"), JsonStringEnumMemberName("Environment")]
    Environment,
    [EnumMember(Value = "Filesystem"), JsonStringEnumMemberName("Filesystem")]
    Filesystem
}

/// <summary>Credentials required to authenticate to this provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecCredentials
{
    /// <summary>
    /// Env is a reference to an environment variable that contains credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("env")]
    public V1alpha2ProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>
    /// Fs is a reference to a filesystem location that contains credentials that
    /// must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("fs")]
    public V1alpha2ProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret key that contains the credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1alpha2ProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    public required V1alpha2ProviderConfigSpecCredentialsSourceEnum Source { get; set; }
}

/// <summary>
/// CACertSecretRef is a reference to a secret containing the CA certificate(s).
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecTlsCaCertSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// ClientCertSecretRef is a reference to a secret containing the client certificate.
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecTlsClientCertSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// ClientKeySecretRef is a reference to a secret containing the client private key.
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecTlsClientKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>TLS configuration for HTTPS requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpecTls
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate the server certificate.
    /// If empty, system root CAs will be used.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public byte[]? CaBundle { get; set; }

    /// <summary>
    /// CACertSecretRef is a reference to a secret containing the CA certificate(s).
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("caCertSecretRef")]
    public V1alpha2ProviderConfigSpecTlsCaCertSecretRef? CaCertSecretRef { get; set; }

    /// <summary>
    /// ClientCertSecretRef is a reference to a secret containing the client certificate.
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("clientCertSecretRef")]
    public V1alpha2ProviderConfigSpecTlsClientCertSecretRef? ClientCertSecretRef { get; set; }

    /// <summary>
    /// ClientKeySecretRef is a reference to a secret containing the client private key.
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1alpha2ProviderConfigSpecTlsClientKeySecretRef? ClientKeySecretRef { get; set; }

    /// <summary>
    /// InsecureSkipVerify controls whether the client verifies the server&apos;s certificate chain and host name.
    /// If true, any certificate presented by the server and any host name in that certificate is accepted.
    /// </summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigSpec
{
    /// <summary>Credentials required to authenticate to this provider.</summary>
    [JsonPropertyName("credentials")]
    public required V1alpha2ProviderConfigSpecCredentials Credentials { get; set; }

    /// <summary>TLS configuration for HTTPS requests.</summary>
    [JsonPropertyName("tls")]
    public V1alpha2ProviderConfigSpecTls? Tls { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigStatusConditions
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

/// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha2ProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ProviderConfig configures a Http provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2ProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha2ProviderConfigSpec>, IStatus<V1alpha2ProviderConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "ProviderConfig";
    public const string KubeGroup = "http.m.crossplane.io";
    public const string KubePluralName = "providerconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "http.m.crossplane.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProviderConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha2ProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha2ProviderConfigStatus? Status { get; set; }
}