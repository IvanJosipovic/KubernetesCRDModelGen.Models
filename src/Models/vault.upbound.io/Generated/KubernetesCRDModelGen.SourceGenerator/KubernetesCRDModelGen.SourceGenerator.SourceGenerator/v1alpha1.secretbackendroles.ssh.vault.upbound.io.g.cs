#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssh.vault.upbound.io;
/// <summary>SecretBackendRole is the Schema for the SecretBackendRoles API. Managing roles in an SSH secret backend in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRoleList";
    public const string KubeGroup = "ssh.vault.upbound.io";
    public const string KubePluralName = "secretbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssh.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendRole> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretBackendRoleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderAllowedUserKeyConfig
{
    /// <summary>
    /// A list of allowed key lengths as integers.
    /// For key types that do not support setting the length a value of [0] should be used.
    /// Setting multiple lengths is only supported on Vault 1.10+. For prior releases length
    /// must be set to a single element list.
    /// List of allowed key lengths, vault-1.10 and above
    /// </summary>
    [JsonPropertyName("lengths")]
    public IList<double>? Lengths { get; set; }

    /// <summary>
    /// The SSH public key type.
    /// Supported key types are:
    /// rsa, ecdsa, ec, dsa, ed25519, ssh-rsa, ssh-dss, ssh-ed25519,
    /// ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521
    /// Key type, choices:
    /// rsa, ecdsa, ec, dsa, ed25519, ssh-rsa, ssh-dss, ssh-ed25519, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendSelector
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
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProvider
{
    /// <summary>When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512.</summary>
    [JsonPropertyName("algorithmSigner")]
    public string? AlgorithmSigner { get; set; }

    /// <summary>Specifies if host certificates that are requested are allowed to use the base domains listed in allowed_domains.</summary>
    [JsonPropertyName("allowBareDomains")]
    public bool? AllowBareDomains { get; set; }

    /// <summary>
    /// Allow signing certificates with no
    /// valid principals (e.g. any valid principal). For backwards compatibility
    /// only. The default of false is highly recommended.
    /// </summary>
    [JsonPropertyName("allowEmptyPrincipals")]
    public bool? AllowEmptyPrincipals { get; set; }

    /// <summary>Specifies if certificates are allowed to be signed for use as a &apos;host&apos;.</summary>
    [JsonPropertyName("allowHostCertificates")]
    public bool? AllowHostCertificates { get; set; }

    /// <summary>Specifies if host certificates that are requested are allowed to be subdomains of those listed in allowed_domains.</summary>
    [JsonPropertyName("allowSubdomains")]
    public bool? AllowSubdomains { get; set; }

    /// <summary>Specifies if certificates are allowed to be signed for use as a &apos;user&apos;.</summary>
    [JsonPropertyName("allowUserCertificates")]
    public bool? AllowUserCertificates { get; set; }

    /// <summary>Specifies if users can override the key ID for a signed certificate with the key_id field.</summary>
    [JsonPropertyName("allowUserKeyIds")]
    public bool? AllowUserKeyIds { get; set; }

    /// <summary>Specifies a comma-separated list of critical options that certificates can have when signed.</summary>
    [JsonPropertyName("allowedCriticalOptions")]
    public string? AllowedCriticalOptions { get; set; }

    /// <summary>The list of domains for which a client can request a host certificate.</summary>
    [JsonPropertyName("allowedDomains")]
    public string? AllowedDomains { get; set; }

    /// <summary>
    /// Specifies if allowed_domains can be declared using
    /// identity template policies. Non-templated domains are also permitted.
    /// </summary>
    [JsonPropertyName("allowedDomainsTemplate")]
    public bool? AllowedDomainsTemplate { get; set; }

    /// <summary>Specifies a comma-separated list of extensions that certificates can have when signed.</summary>
    [JsonPropertyName("allowedExtensions")]
    public string? AllowedExtensions { get; set; }

    /// <summary>
    /// Set of configuration blocks to define allowed
    /// user key configuration, like key type and their lengths. Can be specified multiple times.
    /// See
    /// Set of allowed public key types and their relevant configuration
    /// </summary>
    [JsonPropertyName("allowedUserKeyConfig")]
    public IList<V1alpha1SecretBackendRoleSpecForProviderAllowedUserKeyConfig>? AllowedUserKeyConfig { get; set; }

    /// <summary>Specifies a comma-separated list of usernames that are to be allowed, only if certain usernames are to be allowed.</summary>
    [JsonPropertyName("allowedUsers")]
    public string? AllowedUsers { get; set; }

    /// <summary>Specifies if allowed_users can be declared using identity template policies. Non-templated users are also permitted.</summary>
    [JsonPropertyName("allowedUsersTemplate")]
    public bool? AllowedUsersTemplate { get; set; }

    /// <summary>The path where the SSH secret backend is mounted.</summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>The comma-separated string of CIDR blocks for which this role is applicable.</summary>
    [JsonPropertyName("cidrList")]
    public string? CidrList { get; set; }

    /// <summary>Specifies a map of critical options that certificates have when signed.</summary>
    [JsonPropertyName("defaultCriticalOptions")]
    public IDictionary<string, string>? DefaultCriticalOptions { get; set; }

    /// <summary>
    /// Specifies a map of extensions that certificates have when signed.
    /// Default extensions to include in SSH certificates. Only applicable for CA key type.
    /// </summary>
    [JsonPropertyName("defaultExtensions")]
    public IDictionary<string, string>? DefaultExtensions { get; set; }

    /// <summary>
    /// Specifies if the default_extensions field supports templating.
    /// When set to true, the extension values can use identity template policies. Defaults to false.
    /// Specifies if the default_extensions field supports templating. Only applicable for CA key type.
    /// </summary>
    [JsonPropertyName("defaultExtensionsTemplate")]
    public bool? DefaultExtensionsTemplate { get; set; }

    /// <summary>Specifies the default username for which a credential will be generated.</summary>
    [JsonPropertyName("defaultUser")]
    public string? DefaultUser { get; set; }

    /// <summary>If set, default_users can be specified using identity template values. A non-templated user is also permitted.</summary>
    [JsonPropertyName("defaultUserTemplate")]
    public bool? DefaultUserTemplate { get; set; }

    /// <summary>
    /// Specifies a comma-separated list of CIDR blocks for which credentials cannot be created.
    /// This is particularly useful for OTP key types to restrict credential generation to specific network ranges.
    /// List of CIDR blocks for which credentials cannot be created. Applicable for OTP and dynamic key types.
    /// </summary>
    [JsonPropertyName("excludeCidrList")]
    public IList<string>? ExcludeCidrList { get; set; }

    /// <summary>Specifies a custom format for the key id of a signed certificate.</summary>
    [JsonPropertyName("keyIdFormat")]
    public string? KeyIdFormat { get; set; }

    /// <summary>Specifies the type of credentials generated by this role. This can be either otp, dynamic or ca.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Specifies the maximum Time To Live value.</summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// Specifies the name of the role to create.
    /// Unique name for the role.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specifies the duration by which to backdate the ValidAfter property.
    /// Uses duration format strings.
    /// Specifies the duration by which to backdate the ValidAfter property. Uses duration format strings.
    /// </summary>
    [JsonPropertyName("notBeforeDuration")]
    public string? NotBeforeDuration { get; set; }

    /// <summary>
    /// Specifies the port number for SSH connections. Defaults to 22.
    /// This is primarily used with OTP key types to specify the SSH port on target hosts.
    /// Specifies the port number for SSH connections (default 22). Applicable for OTP and dynamic key types.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specifies the Time To Live value.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderAllowedUserKeyConfig
{
    /// <summary>
    /// A list of allowed key lengths as integers.
    /// For key types that do not support setting the length a value of [0] should be used.
    /// Setting multiple lengths is only supported on Vault 1.10+. For prior releases length
    /// must be set to a single element list.
    /// List of allowed key lengths, vault-1.10 and above
    /// </summary>
    [JsonPropertyName("lengths")]
    public IList<double>? Lengths { get; set; }

    /// <summary>
    /// The SSH public key type.
    /// Supported key types are:
    /// rsa, ecdsa, ec, dsa, ed25519, ssh-rsa, ssh-dss, ssh-ed25519,
    /// ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521
    /// Key type, choices:
    /// rsa, ecdsa, ec, dsa, ed25519, ssh-rsa, ssh-dss, ssh-ed25519, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretBackendRoleSpecInitProvider
{
    /// <summary>When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512.</summary>
    [JsonPropertyName("algorithmSigner")]
    public string? AlgorithmSigner { get; set; }

    /// <summary>Specifies if host certificates that are requested are allowed to use the base domains listed in allowed_domains.</summary>
    [JsonPropertyName("allowBareDomains")]
    public bool? AllowBareDomains { get; set; }

    /// <summary>
    /// Allow signing certificates with no
    /// valid principals (e.g. any valid principal). For backwards compatibility
    /// only. The default of false is highly recommended.
    /// </summary>
    [JsonPropertyName("allowEmptyPrincipals")]
    public bool? AllowEmptyPrincipals { get; set; }

    /// <summary>Specifies if certificates are allowed to be signed for use as a &apos;host&apos;.</summary>
    [JsonPropertyName("allowHostCertificates")]
    public bool? AllowHostCertificates { get; set; }

    /// <summary>Specifies if host certificates that are requested are allowed to be subdomains of those listed in allowed_domains.</summary>
    [JsonPropertyName("allowSubdomains")]
    public bool? AllowSubdomains { get; set; }

    /// <summary>Specifies if certificates are allowed to be signed for use as a &apos;user&apos;.</summary>
    [JsonPropertyName("allowUserCertificates")]
    public bool? AllowUserCertificates { get; set; }

    /// <summary>Specifies if users can override the key ID for a signed certificate with the key_id field.</summary>
    [JsonPropertyName("allowUserKeyIds")]
    public bool? AllowUserKeyIds { get; set; }

    /// <summary>Specifies a comma-separated list of critical options that certificates can have when signed.</summary>
    [JsonPropertyName("allowedCriticalOptions")]
    public string? AllowedCriticalOptions { get; set; }

    /// <summary>The list of domains for which a client can request a host certificate.</summary>
    [JsonPropertyName("allowedDomains")]
    public string? AllowedDomains { get; set; }

    /// <summary>
    /// Specifies if allowed_domains can be declared using
    /// identity template policies. Non-templated domains are also permitted.
    /// </summary>
    [JsonPropertyName("allowedDomainsTemplate")]
    public bool? AllowedDomainsTemplate { get; set; }

    /// <summary>Specifies a comma-separated list of extensions that certificates can have when signed.</summary>
    [JsonPropertyName("allowedExtensions")]
    public string? AllowedExtensions { get; set; }

    /// <summary>
    /// Set of configuration blocks to define allowed
    /// user key configuration, like key type and their lengths. Can be specified multiple times.
    /// See
    /// Set of allowed public key types and their relevant configuration
    /// </summary>
    [JsonPropertyName("allowedUserKeyConfig")]
    public IList<V1alpha1SecretBackendRoleSpecInitProviderAllowedUserKeyConfig>? AllowedUserKeyConfig { get; set; }

    /// <summary>Specifies a comma-separated list of usernames that are to be allowed, only if certain usernames are to be allowed.</summary>
    [JsonPropertyName("allowedUsers")]
    public string? AllowedUsers { get; set; }

    /// <summary>Specifies if allowed_users can be declared using identity template policies. Non-templated users are also permitted.</summary>
    [JsonPropertyName("allowedUsersTemplate")]
    public bool? AllowedUsersTemplate { get; set; }

    /// <summary>The path where the SSH secret backend is mounted.</summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>The comma-separated string of CIDR blocks for which this role is applicable.</summary>
    [JsonPropertyName("cidrList")]
    public string? CidrList { get; set; }

    /// <summary>Specifies a map of critical options that certificates have when signed.</summary>
    [JsonPropertyName("defaultCriticalOptions")]
    public IDictionary<string, string>? DefaultCriticalOptions { get; set; }

    /// <summary>
    /// Specifies a map of extensions that certificates have when signed.
    /// Default extensions to include in SSH certificates. Only applicable for CA key type.
    /// </summary>
    [JsonPropertyName("defaultExtensions")]
    public IDictionary<string, string>? DefaultExtensions { get; set; }

    /// <summary>
    /// Specifies if the default_extensions field supports templating.
    /// When set to true, the extension values can use identity template policies. Defaults to false.
    /// Specifies if the default_extensions field supports templating. Only applicable for CA key type.
    /// </summary>
    [JsonPropertyName("defaultExtensionsTemplate")]
    public bool? DefaultExtensionsTemplate { get; set; }

    /// <summary>Specifies the default username for which a credential will be generated.</summary>
    [JsonPropertyName("defaultUser")]
    public string? DefaultUser { get; set; }

    /// <summary>If set, default_users can be specified using identity template values. A non-templated user is also permitted.</summary>
    [JsonPropertyName("defaultUserTemplate")]
    public bool? DefaultUserTemplate { get; set; }

    /// <summary>
    /// Specifies a comma-separated list of CIDR blocks for which credentials cannot be created.
    /// This is particularly useful for OTP key types to restrict credential generation to specific network ranges.
    /// List of CIDR blocks for which credentials cannot be created. Applicable for OTP and dynamic key types.
    /// </summary>
    [JsonPropertyName("excludeCidrList")]
    public IList<string>? ExcludeCidrList { get; set; }

    /// <summary>Specifies a custom format for the key id of a signed certificate.</summary>
    [JsonPropertyName("keyIdFormat")]
    public string? KeyIdFormat { get; set; }

    /// <summary>Specifies the type of credentials generated by this role. This can be either otp, dynamic or ca.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Specifies the maximum Time To Live value.</summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// Specifies the name of the role to create.
    /// Unique name for the role.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specifies the duration by which to backdate the ValidAfter property.
    /// Uses duration format strings.
    /// Specifies the duration by which to backdate the ValidAfter property. Uses duration format strings.
    /// </summary>
    [JsonPropertyName("notBeforeDuration")]
    public string? NotBeforeDuration { get; set; }

    /// <summary>
    /// Specifies the port number for SSH connections. Defaults to 22.
    /// This is primarily used with OTP key types to specify the SSH port on target hosts.
    /// Specifies the port number for SSH connections (default 22). Applicable for OTP and dynamic key types.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specifies the Time To Live value.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendRoleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretBackendRoleSpec defines the desired state of SecretBackendRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpec
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
    public V1alpha1SecretBackendRoleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendRoleSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendRoleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretBackendRoleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusAtProviderAllowedUserKeyConfig
{
    /// <summary>
    /// A list of allowed key lengths as integers.
    /// For key types that do not support setting the length a value of [0] should be used.
    /// Setting multiple lengths is only supported on Vault 1.10+. For prior releases length
    /// must be set to a single element list.
    /// List of allowed key lengths, vault-1.10 and above
    /// </summary>
    [JsonPropertyName("lengths")]
    public IList<double>? Lengths { get; set; }

    /// <summary>
    /// The SSH public key type.
    /// Supported key types are:
    /// rsa, ecdsa, ec, dsa, ed25519, ssh-rsa, ssh-dss, ssh-ed25519,
    /// ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521
    /// Key type, choices:
    /// rsa, ecdsa, ec, dsa, ed25519, ssh-rsa, ssh-dss, ssh-ed25519, ecdsa-sha2-nistp256, ecdsa-sha2-nistp384, ecdsa-sha2-nistp521
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusAtProvider
{
    /// <summary>When supplied, this value specifies a signing algorithm for the key. Possible values: ssh-rsa, rsa-sha2-256, rsa-sha2-512.</summary>
    [JsonPropertyName("algorithmSigner")]
    public string? AlgorithmSigner { get; set; }

    /// <summary>Specifies if host certificates that are requested are allowed to use the base domains listed in allowed_domains.</summary>
    [JsonPropertyName("allowBareDomains")]
    public bool? AllowBareDomains { get; set; }

    /// <summary>
    /// Allow signing certificates with no
    /// valid principals (e.g. any valid principal). For backwards compatibility
    /// only. The default of false is highly recommended.
    /// </summary>
    [JsonPropertyName("allowEmptyPrincipals")]
    public bool? AllowEmptyPrincipals { get; set; }

    /// <summary>Specifies if certificates are allowed to be signed for use as a &apos;host&apos;.</summary>
    [JsonPropertyName("allowHostCertificates")]
    public bool? AllowHostCertificates { get; set; }

    /// <summary>Specifies if host certificates that are requested are allowed to be subdomains of those listed in allowed_domains.</summary>
    [JsonPropertyName("allowSubdomains")]
    public bool? AllowSubdomains { get; set; }

    /// <summary>Specifies if certificates are allowed to be signed for use as a &apos;user&apos;.</summary>
    [JsonPropertyName("allowUserCertificates")]
    public bool? AllowUserCertificates { get; set; }

    /// <summary>Specifies if users can override the key ID for a signed certificate with the key_id field.</summary>
    [JsonPropertyName("allowUserKeyIds")]
    public bool? AllowUserKeyIds { get; set; }

    /// <summary>Specifies a comma-separated list of critical options that certificates can have when signed.</summary>
    [JsonPropertyName("allowedCriticalOptions")]
    public string? AllowedCriticalOptions { get; set; }

    /// <summary>The list of domains for which a client can request a host certificate.</summary>
    [JsonPropertyName("allowedDomains")]
    public string? AllowedDomains { get; set; }

    /// <summary>
    /// Specifies if allowed_domains can be declared using
    /// identity template policies. Non-templated domains are also permitted.
    /// </summary>
    [JsonPropertyName("allowedDomainsTemplate")]
    public bool? AllowedDomainsTemplate { get; set; }

    /// <summary>Specifies a comma-separated list of extensions that certificates can have when signed.</summary>
    [JsonPropertyName("allowedExtensions")]
    public string? AllowedExtensions { get; set; }

    /// <summary>
    /// Set of configuration blocks to define allowed
    /// user key configuration, like key type and their lengths. Can be specified multiple times.
    /// See
    /// Set of allowed public key types and their relevant configuration
    /// </summary>
    [JsonPropertyName("allowedUserKeyConfig")]
    public IList<V1alpha1SecretBackendRoleStatusAtProviderAllowedUserKeyConfig>? AllowedUserKeyConfig { get; set; }

    /// <summary>Specifies a comma-separated list of usernames that are to be allowed, only if certain usernames are to be allowed.</summary>
    [JsonPropertyName("allowedUsers")]
    public string? AllowedUsers { get; set; }

    /// <summary>Specifies if allowed_users can be declared using identity template policies. Non-templated users are also permitted.</summary>
    [JsonPropertyName("allowedUsersTemplate")]
    public bool? AllowedUsersTemplate { get; set; }

    /// <summary>The path where the SSH secret backend is mounted.</summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>The comma-separated string of CIDR blocks for which this role is applicable.</summary>
    [JsonPropertyName("cidrList")]
    public string? CidrList { get; set; }

    /// <summary>Specifies a map of critical options that certificates have when signed.</summary>
    [JsonPropertyName("defaultCriticalOptions")]
    public IDictionary<string, string>? DefaultCriticalOptions { get; set; }

    /// <summary>
    /// Specifies a map of extensions that certificates have when signed.
    /// Default extensions to include in SSH certificates. Only applicable for CA key type.
    /// </summary>
    [JsonPropertyName("defaultExtensions")]
    public IDictionary<string, string>? DefaultExtensions { get; set; }

    /// <summary>
    /// Specifies if the default_extensions field supports templating.
    /// When set to true, the extension values can use identity template policies. Defaults to false.
    /// Specifies if the default_extensions field supports templating. Only applicable for CA key type.
    /// </summary>
    [JsonPropertyName("defaultExtensionsTemplate")]
    public bool? DefaultExtensionsTemplate { get; set; }

    /// <summary>Specifies the default username for which a credential will be generated.</summary>
    [JsonPropertyName("defaultUser")]
    public string? DefaultUser { get; set; }

    /// <summary>If set, default_users can be specified using identity template values. A non-templated user is also permitted.</summary>
    [JsonPropertyName("defaultUserTemplate")]
    public bool? DefaultUserTemplate { get; set; }

    /// <summary>
    /// Specifies a comma-separated list of CIDR blocks for which credentials cannot be created.
    /// This is particularly useful for OTP key types to restrict credential generation to specific network ranges.
    /// List of CIDR blocks for which credentials cannot be created. Applicable for OTP and dynamic key types.
    /// </summary>
    [JsonPropertyName("excludeCidrList")]
    public IList<string>? ExcludeCidrList { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies a custom format for the key id of a signed certificate.</summary>
    [JsonPropertyName("keyIdFormat")]
    public string? KeyIdFormat { get; set; }

    /// <summary>Specifies the type of credentials generated by this role. This can be either otp, dynamic or ca.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Specifies the maximum Time To Live value.</summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// Specifies the name of the role to create.
    /// Unique name for the role.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specifies the duration by which to backdate the ValidAfter property.
    /// Uses duration format strings.
    /// Specifies the duration by which to backdate the ValidAfter property. Uses duration format strings.
    /// </summary>
    [JsonPropertyName("notBeforeDuration")]
    public string? NotBeforeDuration { get; set; }

    /// <summary>
    /// Specifies the port number for SSH connections. Defaults to 22.
    /// This is primarily used with OTP key types to specify the SSH port on target hosts.
    /// Specifies the port number for SSH connections (default 22). Applicable for OTP and dynamic key types.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specifies the Time To Live value.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusConditions
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

/// <summary>SecretBackendRoleStatus defines the observed state of SecretBackendRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendRoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendRole is the Schema for the SecretBackendRoles API. Managing roles in an SSH secret backend in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendRoleSpec>, IStatus<V1alpha1SecretBackendRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRole";
    public const string KubeGroup = "ssh.vault.upbound.io";
    public const string KubePluralName = "secretbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ssh.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendRoleSpec defines the desired state of SecretBackendRole</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendRoleSpec Spec { get; set; }

    /// <summary>SecretBackendRoleStatus defines the observed state of SecretBackendRole.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendRoleStatus? Status { get; set; }
}