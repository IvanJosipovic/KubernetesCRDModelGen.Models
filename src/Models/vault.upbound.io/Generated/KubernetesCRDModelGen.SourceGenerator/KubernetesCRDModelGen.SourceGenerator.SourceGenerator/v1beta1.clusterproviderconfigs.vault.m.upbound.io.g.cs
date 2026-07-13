#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vault.m.upbound.io;
/// <summary>A ClusterProviderConfig configures a Vault provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterProviderConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ClusterProviderConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterProviderConfigList";
    public const string KubeGroup = "vault.m.upbound.io";
    public const string KubePluralName = "clusterproviderconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vault.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterProviderConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ClusterProviderConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ClusterProviderConfig> Items { get; set; }
}

/// <summary>
/// Env is a reference to an environment variable that contains credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Fs is a reference to a filesystem location that contains credentials that
/// must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>
/// A SecretRef is a reference to a secret key that contains the credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentialsSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterProviderConfigSpecCredentialsSourceEnum>))]
public enum V1beta1ClusterProviderConfigSpecCredentialsSourceEnum
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
    Filesystem,
    [EnumMember(Value = "Kubernetes"), JsonStringEnumMemberName("Kubernetes")]
    Kubernetes
}

/// <summary>
/// Credentials required to authenticate to this provider.
/// There are many options to authenticate. They include
/// - token - (Optional) Vault token that will be used
/// by Terraform to authenticate. May be set via the
/// VAULT_TOKEN environment variable. If none is otherwise
/// supplied, Terraform will attempt to read it from
/// ~/.vault-token (where the vault command stores its
/// current token). Terraform will issue itself a new token
/// that is a child of the one given, with a short TTL to
/// limit the exposure of any requested secrets, unless
/// skip_child_token is set to true (see below). Note
/// that the given token must have the update capability
/// on the auth/token/create path in Vault in order to create
/// child tokens. A token is required for the provider. A
/// token can explicitly set via token argument, alternatively
/// a token can be dynamically set via an auth_login* block.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecCredentials
{
    /// <summary>
    /// Env is a reference to an environment variable that contains credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("env")]
    public V1beta1ClusterProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>
    /// Fs is a reference to a filesystem location that contains credentials that
    /// must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("fs")]
    public V1beta1ClusterProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret key that contains the credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ClusterProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    public required V1beta1ClusterProviderConfigSpecCredentialsSourceEnum Source { get; set; }
}

/// <summary>
/// A configuration block, described below,
/// that provides headers to be sent along with all
/// requests to the Vault server. This block can be
/// specified multiple times.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpecHeaders
{
    /// <summary>Required header name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Required header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigSpec
{
    /// <summary>
    /// If true the environment variable
    /// VAULT_ADDR in the Terraform process environment
    /// will be set to the value of the address argument
    /// from this provider. By default, this is false.
    /// </summary>
    [JsonPropertyName("add_address_to_env")]
    public bool? AddAddressToEnv { get; set; }

    /// <summary>
    /// Required origin URL of the Vault server.
    /// This is a URL with a scheme, a hostname
    /// and a port but with no path.
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>
    /// Credentials required to authenticate to this provider.
    /// There are many options to authenticate. They include
    /// - token - (Optional) Vault token that will be used
    /// by Terraform to authenticate. May be set via the
    /// VAULT_TOKEN environment variable. If none is otherwise
    /// supplied, Terraform will attempt to read it from
    /// ~/.vault-token (where the vault command stores its
    /// current token). Terraform will issue itself a new token
    /// that is a child of the one given, with a short TTL to
    /// limit the exposure of any requested secrets, unless
    /// skip_child_token is set to true (see below). Note
    /// that the given token must have the update capability
    /// on the auth/token/create path in Vault in order to create
    /// child tokens. A token is required for the provider. A
    /// token can explicitly set via token argument, alternatively
    /// a token can be dynamically set via an auth_login* block.
    /// </summary>
    [JsonPropertyName("credentials")]
    public V1beta1ClusterProviderConfigSpecCredentials? Credentials { get; set; }

    /// <summary>
    /// A configuration block, described below,
    /// that provides headers to be sent along with all
    /// requests to the Vault server. This block can be
    /// specified multiple times.
    /// </summary>
    [JsonPropertyName("headers")]
    public V1beta1ClusterProviderConfigSpecHeaders? Headers { get; set; }

    /// <summary>
    /// Used as the duration for the intermediate Vault
    /// token Terraform issues itself, which in turn limits the
    /// duration of secret leases issued by Vault. Defaults to
    /// 20 minutes.
    /// </summary>
    [JsonPropertyName("max_lease_ttl_seconds")]
    public int? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// Used as the maximum number of retries when a
    /// 5xx error code is encountered. Defaults to 2 retries.
    /// </summary>
    [JsonPropertyName("max_retries")]
    public int? MaxRetries { get; set; }

    /// <summary>
    /// Maximum number of retries for Client Controlled
    /// Consistency related operations. Defaults to 10 retries.
    /// </summary>
    [JsonPropertyName("max_retries_ccc")]
    public int? MaxRetriesCcc { get; set; }

    /// <summary>Mount path of the auth method.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Set the namespace to use.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Name of the role against which to login.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// Set this to true to disable creation of an
    /// intermediate ephemeral Vault token for Terraform to use.
    /// Enabling this is strongly discouraged since it increases
    /// the potential for a renewable Vault token being exposed
    /// in clear text. Only change this setting when the provided
    /// token cannot be permitted to create child tokens and there
    /// is no risk of exposure from the output of Terraform.
    /// </summary>
    [JsonPropertyName("skip_child_token")]
    public bool? SkipChildToken { get; set; }

    /// <summary>
    /// Skip the dynamic fetching of the Vault server
    /// version. Set to true when the /sys/seal-status API
    /// endpoint is not available.
    /// </summary>
    [JsonPropertyName("skip_get_vault_version")]
    public bool? SkipGetVaultVersion { get; set; }

    /// <summary>
    /// Set this to true to disable verification
    /// of the Vault server&apos;s TLS certificate. This is
    /// strongly discouraged except in prototype or
    /// development environments, since it exposes the
    /// possibility that Terraform can be tricked into
    /// writing secrets to a server controlled by an intruder.
    /// </summary>
    [JsonPropertyName("skip_tls_verify")]
    public bool? SkipTlsVerify { get; set; }

    /// <summary>
    /// Name to use as the SNI host when connecting
    /// via TLS.
    /// </summary>
    [JsonPropertyName("tls_server_name")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// Override the target Vault server semantic
    /// version. Normally the version is dynamically set
    /// from the /sys/seal-status API endpoint. In the case
    /// where this endpoint is not available an override can
    /// be specified here.
    /// </summary>
    [JsonPropertyName("vault_version_override")]
    public string? VaultVersionOverride { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ClusterProviderConfig configures a Vault provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterProviderConfigSpec>, IStatus<V1beta1ClusterProviderConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterProviderConfig";
    public const string KubeGroup = "vault.m.upbound.io";
    public const string KubePluralName = "clusterproviderconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vault.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterProviderConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ClusterProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterProviderConfigStatus? Status { get; set; }
}