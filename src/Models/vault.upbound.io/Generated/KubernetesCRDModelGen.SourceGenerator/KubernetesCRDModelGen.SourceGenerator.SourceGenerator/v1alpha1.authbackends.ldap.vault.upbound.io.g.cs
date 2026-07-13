#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ldap.vault.upbound.io;
/// <summary>AuthBackend is the Schema for the AuthBackends API. &lt;no value&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackend>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendList";
    public const string KubeGroup = "ldap.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ldap.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AuthBackend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AuthBackend> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecDeletionPolicyEnum>))]
public enum V1alpha1AuthBackendSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderBindpassSecretRef
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

/// <summary>Write-only bind password to use for LDAP authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderBindpassWoSecretRef
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

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderClientTlsKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderTune
{
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProvider
{
    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>Allows anonymous group searches.</summary>
    [JsonPropertyName("anonymousGroupSearch")]
    public bool? AnonymousGroupSearch { get; set; }

    [JsonPropertyName("binddn")]
    public string? Binddn { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("bindpassSecretRef")]
    public V1alpha1AuthBackendSpecForProviderBindpassSecretRef? BindpassSecretRef { get; set; }

    /// <summary>Write-only bind password to use for LDAP authentication.</summary>
    [JsonPropertyName("bindpassWoSecretRef")]
    public V1alpha1AuthBackendSpecForProviderBindpassWoSecretRef? BindpassWoSecretRef { get; set; }

    /// <summary>Version counter for write-only bind password.</summary>
    [JsonPropertyName("bindpassWoVersion")]
    public double? BindpassWoVersion { get; set; }

    [JsonPropertyName("caseSensitiveNames")]
    public bool? CaseSensitiveNames { get; set; }

    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    [JsonPropertyName("clientTlsCert")]
    public string? ClientTlsCert { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("clientTlsKeySecretRef")]
    public V1alpha1AuthBackendSpecForProviderClientTlsKeySecretRef? ClientTlsKeySecretRef { get; set; }

    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    [JsonPropertyName("denyNullBind")]
    public bool? DenyNullBind { get; set; }

    /// <summary>Specifies how aliases are dereferenced during LDAP searches. Valid values are &apos;never&apos;,&apos;searching&apos;,&apos;finding&apos;, and &apos;always&apos;.</summary>
    [JsonPropertyName("dereferenceAliases")]
    public string? DereferenceAliases { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Stops rotation of the root credential until set to false.</summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>If set, opts out of mount migration on path updates.</summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("discoverdn")]
    public bool? Discoverdn { get; set; }

    /// <summary>Enables login using the sAMAccountName attribute.</summary>
    [JsonPropertyName("enableSamaccountnameLogin")]
    public bool? EnableSamaccountnameLogin { get; set; }

    [JsonPropertyName("groupattr")]
    public string? Groupattr { get; set; }

    [JsonPropertyName("groupdn")]
    public string? Groupdn { get; set; }

    [JsonPropertyName("groupfilter")]
    public string? Groupfilter { get; set; }

    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>Specifies if the auth method is local only</summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The timeout(in sec) for requests to the LDAP server.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.</summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.</summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.</summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    [JsonPropertyName("starttls")]
    public bool? Starttls { get; set; }

    [JsonPropertyName("tlsMaxVersion")]
    public string? TlsMaxVersion { get; set; }

    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }

    /// <summary>Specifies the blocks of IP addresses which are allowed to use the generated token</summary>
    [JsonPropertyName("tokenBoundCidrs")]
    public IList<string>? TokenBoundCidrs { get; set; }

    /// <summary>Generated Token&apos;s Explicit Maximum TTL in seconds</summary>
    [JsonPropertyName("tokenExplicitMaxTtl")]
    public double? TokenExplicitMaxTtl { get; set; }

    /// <summary>The maximum lifetime of the generated token</summary>
    [JsonPropertyName("tokenMaxTtl")]
    public double? TokenMaxTtl { get; set; }

    /// <summary>If true, the &apos;default&apos; policy will not automatically be added to generated tokens</summary>
    [JsonPropertyName("tokenNoDefaultPolicy")]
    public bool? TokenNoDefaultPolicy { get; set; }

    /// <summary>The maximum number of times a token may be used, a value of zero means unlimited</summary>
    [JsonPropertyName("tokenNumUses")]
    public double? TokenNumUses { get; set; }

    /// <summary>Generated Token&apos;s Period</summary>
    [JsonPropertyName("tokenPeriod")]
    public double? TokenPeriod { get; set; }

    /// <summary>Generated Token&apos;s Policies</summary>
    [JsonPropertyName("tokenPolicies")]
    public IList<string>? TokenPolicies { get; set; }

    /// <summary>The initial ttl of the token to generate in seconds</summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>The type of token to generate, service or batch</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecForProviderTune>? Tune { get; set; }

    [JsonPropertyName("upndomain")]
    public string? Upndomain { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("useTokenGroups")]
    public bool? UseTokenGroups { get; set; }

    [JsonPropertyName("userattr")]
    public string? Userattr { get; set; }

    [JsonPropertyName("userdn")]
    public string? Userdn { get; set; }

    [JsonPropertyName("userfilter")]
    public string? Userfilter { get; set; }

    /// <summary>Force the auth method to use the username passed by the user as the alias name.</summary>
    [JsonPropertyName("usernameAsAlias")]
    public bool? UsernameAsAlias { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderBindpassSecretRef
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

/// <summary>Write-only bind password to use for LDAP authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderBindpassWoSecretRef
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

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderClientTlsKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderTune
{
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
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
public partial class V1alpha1AuthBackendSpecInitProvider
{
    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>Allows anonymous group searches.</summary>
    [JsonPropertyName("anonymousGroupSearch")]
    public bool? AnonymousGroupSearch { get; set; }

    [JsonPropertyName("binddn")]
    public string? Binddn { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("bindpassSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderBindpassSecretRef? BindpassSecretRef { get; set; }

    /// <summary>Write-only bind password to use for LDAP authentication.</summary>
    [JsonPropertyName("bindpassWoSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderBindpassWoSecretRef? BindpassWoSecretRef { get; set; }

    /// <summary>Version counter for write-only bind password.</summary>
    [JsonPropertyName("bindpassWoVersion")]
    public double? BindpassWoVersion { get; set; }

    [JsonPropertyName("caseSensitiveNames")]
    public bool? CaseSensitiveNames { get; set; }

    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    [JsonPropertyName("clientTlsCert")]
    public string? ClientTlsCert { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("clientTlsKeySecretRef")]
    public V1alpha1AuthBackendSpecInitProviderClientTlsKeySecretRef? ClientTlsKeySecretRef { get; set; }

    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    [JsonPropertyName("denyNullBind")]
    public bool? DenyNullBind { get; set; }

    /// <summary>Specifies how aliases are dereferenced during LDAP searches. Valid values are &apos;never&apos;,&apos;searching&apos;,&apos;finding&apos;, and &apos;always&apos;.</summary>
    [JsonPropertyName("dereferenceAliases")]
    public string? DereferenceAliases { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Stops rotation of the root credential until set to false.</summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>If set, opts out of mount migration on path updates.</summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("discoverdn")]
    public bool? Discoverdn { get; set; }

    /// <summary>Enables login using the sAMAccountName attribute.</summary>
    [JsonPropertyName("enableSamaccountnameLogin")]
    public bool? EnableSamaccountnameLogin { get; set; }

    [JsonPropertyName("groupattr")]
    public string? Groupattr { get; set; }

    [JsonPropertyName("groupdn")]
    public string? Groupdn { get; set; }

    [JsonPropertyName("groupfilter")]
    public string? Groupfilter { get; set; }

    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>Specifies if the auth method is local only</summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The timeout(in sec) for requests to the LDAP server.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.</summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.</summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.</summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    [JsonPropertyName("starttls")]
    public bool? Starttls { get; set; }

    [JsonPropertyName("tlsMaxVersion")]
    public string? TlsMaxVersion { get; set; }

    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }

    /// <summary>Specifies the blocks of IP addresses which are allowed to use the generated token</summary>
    [JsonPropertyName("tokenBoundCidrs")]
    public IList<string>? TokenBoundCidrs { get; set; }

    /// <summary>Generated Token&apos;s Explicit Maximum TTL in seconds</summary>
    [JsonPropertyName("tokenExplicitMaxTtl")]
    public double? TokenExplicitMaxTtl { get; set; }

    /// <summary>The maximum lifetime of the generated token</summary>
    [JsonPropertyName("tokenMaxTtl")]
    public double? TokenMaxTtl { get; set; }

    /// <summary>If true, the &apos;default&apos; policy will not automatically be added to generated tokens</summary>
    [JsonPropertyName("tokenNoDefaultPolicy")]
    public bool? TokenNoDefaultPolicy { get; set; }

    /// <summary>The maximum number of times a token may be used, a value of zero means unlimited</summary>
    [JsonPropertyName("tokenNumUses")]
    public double? TokenNumUses { get; set; }

    /// <summary>Generated Token&apos;s Period</summary>
    [JsonPropertyName("tokenPeriod")]
    public double? TokenPeriod { get; set; }

    /// <summary>Generated Token&apos;s Policies</summary>
    [JsonPropertyName("tokenPolicies")]
    public IList<string>? TokenPolicies { get; set; }

    /// <summary>The initial ttl of the token to generate in seconds</summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>The type of token to generate, service or batch</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecInitProviderTune>? Tune { get; set; }

    [JsonPropertyName("upndomain")]
    public string? Upndomain { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("useTokenGroups")]
    public bool? UseTokenGroups { get; set; }

    [JsonPropertyName("userattr")]
    public string? Userattr { get; set; }

    [JsonPropertyName("userdn")]
    public string? Userdn { get; set; }

    [JsonPropertyName("userfilter")]
    public string? Userfilter { get; set; }

    /// <summary>Force the auth method to use the username passed by the user as the alias name.</summary>
    [JsonPropertyName("usernameAsAlias")]
    public bool? UsernameAsAlias { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecManagementPoliciesEnum>))]
public enum V1alpha1AuthBackendSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AuthBackendSpec defines the desired state of AuthBackend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpec
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
    public V1alpha1AuthBackendSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1AuthBackendSpecForProvider ForProvider { get; set; }

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
    public V1alpha1AuthBackendSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1AuthBackendSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1AuthBackendSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1AuthBackendSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusAtProviderTune
{
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusAtProvider
{
    /// <summary>The accessor of the LDAP auth backend</summary>
    [JsonPropertyName("accessor")]
    public string? Accessor { get; set; }

    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>Allows anonymous group searches.</summary>
    [JsonPropertyName("anonymousGroupSearch")]
    public bool? AnonymousGroupSearch { get; set; }

    [JsonPropertyName("binddn")]
    public string? Binddn { get; set; }

    /// <summary>Version counter for write-only bind password.</summary>
    [JsonPropertyName("bindpassWoVersion")]
    public double? BindpassWoVersion { get; set; }

    [JsonPropertyName("caseSensitiveNames")]
    public bool? CaseSensitiveNames { get; set; }

    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    [JsonPropertyName("clientTlsCert")]
    public string? ClientTlsCert { get; set; }

    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    [JsonPropertyName("denyNullBind")]
    public bool? DenyNullBind { get; set; }

    /// <summary>Specifies how aliases are dereferenced during LDAP searches. Valid values are &apos;never&apos;,&apos;searching&apos;,&apos;finding&apos;, and &apos;always&apos;.</summary>
    [JsonPropertyName("dereferenceAliases")]
    public string? DereferenceAliases { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Stops rotation of the root credential until set to false.</summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>If set, opts out of mount migration on path updates.</summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("discoverdn")]
    public bool? Discoverdn { get; set; }

    /// <summary>Enables login using the sAMAccountName attribute.</summary>
    [JsonPropertyName("enableSamaccountnameLogin")]
    public bool? EnableSamaccountnameLogin { get; set; }

    [JsonPropertyName("groupattr")]
    public string? Groupattr { get; set; }

    [JsonPropertyName("groupdn")]
    public string? Groupdn { get; set; }

    [JsonPropertyName("groupfilter")]
    public string? Groupfilter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>Specifies if the auth method is local only</summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    [JsonPropertyName("maxPageSize")]
    public double? MaxPageSize { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The timeout(in sec) for requests to the LDAP server.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.</summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.</summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.</summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    [JsonPropertyName("starttls")]
    public bool? Starttls { get; set; }

    [JsonPropertyName("tlsMaxVersion")]
    public string? TlsMaxVersion { get; set; }

    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }

    /// <summary>Specifies the blocks of IP addresses which are allowed to use the generated token</summary>
    [JsonPropertyName("tokenBoundCidrs")]
    public IList<string>? TokenBoundCidrs { get; set; }

    /// <summary>Generated Token&apos;s Explicit Maximum TTL in seconds</summary>
    [JsonPropertyName("tokenExplicitMaxTtl")]
    public double? TokenExplicitMaxTtl { get; set; }

    /// <summary>The maximum lifetime of the generated token</summary>
    [JsonPropertyName("tokenMaxTtl")]
    public double? TokenMaxTtl { get; set; }

    /// <summary>If true, the &apos;default&apos; policy will not automatically be added to generated tokens</summary>
    [JsonPropertyName("tokenNoDefaultPolicy")]
    public bool? TokenNoDefaultPolicy { get; set; }

    /// <summary>The maximum number of times a token may be used, a value of zero means unlimited</summary>
    [JsonPropertyName("tokenNumUses")]
    public double? TokenNumUses { get; set; }

    /// <summary>Generated Token&apos;s Period</summary>
    [JsonPropertyName("tokenPeriod")]
    public double? TokenPeriod { get; set; }

    /// <summary>Generated Token&apos;s Policies</summary>
    [JsonPropertyName("tokenPolicies")]
    public IList<string>? TokenPolicies { get; set; }

    /// <summary>The initial ttl of the token to generate in seconds</summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>The type of token to generate, service or batch</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendStatusAtProviderTune>? Tune { get; set; }

    [JsonPropertyName("upndomain")]
    public string? Upndomain { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("useTokenGroups")]
    public bool? UseTokenGroups { get; set; }

    [JsonPropertyName("userattr")]
    public string? Userattr { get; set; }

    [JsonPropertyName("userdn")]
    public string? Userdn { get; set; }

    [JsonPropertyName("userfilter")]
    public string? Userfilter { get; set; }

    /// <summary>Force the auth method to use the username passed by the user as the alias name.</summary>
    [JsonPropertyName("usernameAsAlias")]
    public bool? UsernameAsAlias { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusConditions
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

/// <summary>AuthBackendStatus defines the observed state of AuthBackend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1AuthBackendStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthBackendStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AuthBackend is the Schema for the AuthBackends API. &lt;no value&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendSpec>, IStatus<V1alpha1AuthBackendStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackend";
    public const string KubeGroup = "ldap.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ldap.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthBackendSpec defines the desired state of AuthBackend</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AuthBackendSpec Spec { get; set; }

    /// <summary>AuthBackendStatus defines the observed state of AuthBackend.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthBackendStatus? Status { get; set; }
}