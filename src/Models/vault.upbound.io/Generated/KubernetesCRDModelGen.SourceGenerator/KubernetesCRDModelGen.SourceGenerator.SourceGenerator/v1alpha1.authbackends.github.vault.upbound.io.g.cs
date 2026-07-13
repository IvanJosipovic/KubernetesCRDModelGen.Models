#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.github.vault.upbound.io;
/// <summary>AuthBackend is the Schema for the AuthBackends API. Manages GitHub Auth mounts in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackend>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendList";
    public const string KubeGroup = "github.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "github.vault.upbound.io/v1alpha1";

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderTune
{
    /// <summary>
    /// List of headers to whitelist and allowing
    /// a plugin to include them in the response.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Specifies the default time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in
    /// the UI-specific listing endpoint. Valid values are &quot;unauth&quot; or &quot;hidden&quot;.
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Specifies the maximum time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    /// <summary>
    /// List of headers to whitelist and
    /// pass from the request to the backend.
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Specifies the type of tokens that should be returned by
    /// the mount. Valid values are &quot;default-service&quot;, &quot;default-batch&quot;, &quot;service&quot;, &quot;batch&quot;.
    /// </summary>
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
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// The API endpoint to use. Useful if you
    /// are running GitHub Enterprise or an API-compatible authentication server.
    /// The API endpoint to use. Useful if you are running GitHub Enterprise or an API-compatible authentication server.
    /// </summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>
    /// Specifies the description of the mount.
    /// This overrides the current stored value, if any.
    /// Specifies the description of the mount. This overrides the current stored value, if any.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If set, opts out of mount migration on path updates.
    /// See here for more info on Mount Migration
    /// If set, opts out of mount migration on path updates.
    /// </summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

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
    /// The organization configured users must be part of.
    /// The organization users must be part of.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// The ID of the organization users must be part of.
    /// Vault will attempt to fetch and set this value if it is not provided. (Vault 1.10+)
    /// The ID of the organization users must be part of. Vault will attempt to fetch and set this value if it is not provided (vault-1.10+)
    /// </summary>
    [JsonPropertyName("organizationId")]
    public double? OrganizationId { get; set; }

    /// <summary>
    /// Path where the auth backend is mounted. Defaults to auth/github
    /// if not specified.
    /// Path where the auth backend is mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// List of CIDR blocks; if set, specifies blocks of IP
    /// addresses which can authenticate successfully, and ties the resulting token to these blocks
    /// as well.
    /// Specifies the blocks of IP addresses which are allowed to use the generated token
    /// </summary>
    [JsonPropertyName("tokenBoundCidrs")]
    public IList<string>? TokenBoundCidrs { get; set; }

    /// <summary>
    /// If set, will encode an
    /// explicit max TTL
    /// onto the token in number of seconds. This is a hard cap even if token_ttl and
    /// token_max_ttl would otherwise allow a renewal.
    /// Generated Token&apos;s Explicit Maximum TTL in seconds
    /// </summary>
    [JsonPropertyName("tokenExplicitMaxTtl")]
    public double? TokenExplicitMaxTtl { get; set; }

    /// <summary>
    /// The maximum lifetime for generated tokens in number of seconds.
    /// Its current value will be referenced at renewal time.
    /// The maximum lifetime of the generated token
    /// </summary>
    [JsonPropertyName("tokenMaxTtl")]
    public double? TokenMaxTtl { get; set; }

    /// <summary>
    /// If set, the default policy will not be set on
    /// generated tokens; otherwise it will be added to the policies set in token_policies.
    /// If true, the &apos;default&apos; policy will not automatically be added to generated tokens
    /// </summary>
    [JsonPropertyName("tokenNoDefaultPolicy")]
    public bool? TokenNoDefaultPolicy { get; set; }

    /// <summary>
    /// The maximum number
    /// of times a generated token may be used (within its lifetime); 0 means unlimited.
    /// The maximum number of times a token may be used, a value of zero means unlimited
    /// </summary>
    [JsonPropertyName("tokenNumUses")]
    public double? TokenNumUses { get; set; }

    /// <summary>
    /// If set, indicates that the
    /// token generated using this role should never expire. The token should be renewed within the
    /// duration specified by this value. At each renewal, the token&apos;s TTL will be set to the
    /// value of this field. Specified in seconds.
    /// Generated Token&apos;s Period
    /// </summary>
    [JsonPropertyName("tokenPeriod")]
    public double? TokenPeriod { get; set; }

    /// <summary>
    /// List of policies to encode onto generated tokens. Depending
    /// on the auth method, this list may be supplemented by user/group/other values.
    /// Generated Token&apos;s Policies
    /// </summary>
    [JsonPropertyName("tokenPolicies")]
    public IList<string>? TokenPolicies { get; set; }

    /// <summary>
    /// The incremental lifetime for generated tokens in number of seconds.
    /// Its current value will be referenced at renewal time.
    /// The initial ttl of the token to generate in seconds
    /// </summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>
    /// The type of token that should be generated. Can be service,
    /// batch, or default to use the mount&apos;s tuned default (which unless changed will be
    /// service tokens). For token store roles, there are two additional possibilities:
    /// default-service and default-batch which specify the type to return unless the client
    /// requests a different type at generation time.
    /// The type of token to generate, service or batch
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    /// <summary>Extra configuration block. Structure is documented below.</summary>
    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecForProviderTune>? Tune { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderTune
{
    /// <summary>
    /// List of headers to whitelist and allowing
    /// a plugin to include them in the response.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Specifies the default time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in
    /// the UI-specific listing endpoint. Valid values are &quot;unauth&quot; or &quot;hidden&quot;.
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Specifies the maximum time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    /// <summary>
    /// List of headers to whitelist and
    /// pass from the request to the backend.
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Specifies the type of tokens that should be returned by
    /// the mount. Valid values are &quot;default-service&quot;, &quot;default-batch&quot;, &quot;service&quot;, &quot;batch&quot;.
    /// </summary>
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
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// The API endpoint to use. Useful if you
    /// are running GitHub Enterprise or an API-compatible authentication server.
    /// The API endpoint to use. Useful if you are running GitHub Enterprise or an API-compatible authentication server.
    /// </summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>
    /// Specifies the description of the mount.
    /// This overrides the current stored value, if any.
    /// Specifies the description of the mount. This overrides the current stored value, if any.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If set, opts out of mount migration on path updates.
    /// See here for more info on Mount Migration
    /// If set, opts out of mount migration on path updates.
    /// </summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

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
    /// The organization configured users must be part of.
    /// The organization users must be part of.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// The ID of the organization users must be part of.
    /// Vault will attempt to fetch and set this value if it is not provided. (Vault 1.10+)
    /// The ID of the organization users must be part of. Vault will attempt to fetch and set this value if it is not provided (vault-1.10+)
    /// </summary>
    [JsonPropertyName("organizationId")]
    public double? OrganizationId { get; set; }

    /// <summary>
    /// Path where the auth backend is mounted. Defaults to auth/github
    /// if not specified.
    /// Path where the auth backend is mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// List of CIDR blocks; if set, specifies blocks of IP
    /// addresses which can authenticate successfully, and ties the resulting token to these blocks
    /// as well.
    /// Specifies the blocks of IP addresses which are allowed to use the generated token
    /// </summary>
    [JsonPropertyName("tokenBoundCidrs")]
    public IList<string>? TokenBoundCidrs { get; set; }

    /// <summary>
    /// If set, will encode an
    /// explicit max TTL
    /// onto the token in number of seconds. This is a hard cap even if token_ttl and
    /// token_max_ttl would otherwise allow a renewal.
    /// Generated Token&apos;s Explicit Maximum TTL in seconds
    /// </summary>
    [JsonPropertyName("tokenExplicitMaxTtl")]
    public double? TokenExplicitMaxTtl { get; set; }

    /// <summary>
    /// The maximum lifetime for generated tokens in number of seconds.
    /// Its current value will be referenced at renewal time.
    /// The maximum lifetime of the generated token
    /// </summary>
    [JsonPropertyName("tokenMaxTtl")]
    public double? TokenMaxTtl { get; set; }

    /// <summary>
    /// If set, the default policy will not be set on
    /// generated tokens; otherwise it will be added to the policies set in token_policies.
    /// If true, the &apos;default&apos; policy will not automatically be added to generated tokens
    /// </summary>
    [JsonPropertyName("tokenNoDefaultPolicy")]
    public bool? TokenNoDefaultPolicy { get; set; }

    /// <summary>
    /// The maximum number
    /// of times a generated token may be used (within its lifetime); 0 means unlimited.
    /// The maximum number of times a token may be used, a value of zero means unlimited
    /// </summary>
    [JsonPropertyName("tokenNumUses")]
    public double? TokenNumUses { get; set; }

    /// <summary>
    /// If set, indicates that the
    /// token generated using this role should never expire. The token should be renewed within the
    /// duration specified by this value. At each renewal, the token&apos;s TTL will be set to the
    /// value of this field. Specified in seconds.
    /// Generated Token&apos;s Period
    /// </summary>
    [JsonPropertyName("tokenPeriod")]
    public double? TokenPeriod { get; set; }

    /// <summary>
    /// List of policies to encode onto generated tokens. Depending
    /// on the auth method, this list may be supplemented by user/group/other values.
    /// Generated Token&apos;s Policies
    /// </summary>
    [JsonPropertyName("tokenPolicies")]
    public IList<string>? TokenPolicies { get; set; }

    /// <summary>
    /// The incremental lifetime for generated tokens in number of seconds.
    /// Its current value will be referenced at renewal time.
    /// The initial ttl of the token to generate in seconds
    /// </summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>
    /// The type of token that should be generated. Can be service,
    /// batch, or default to use the mount&apos;s tuned default (which unless changed will be
    /// service tokens). For token store roles, there are two additional possibilities:
    /// default-service and default-batch which specify the type to return unless the client
    /// requests a different type at generation time.
    /// The type of token to generate, service or batch
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    /// <summary>Extra configuration block. Structure is documented below.</summary>
    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecInitProviderTune>? Tune { get; set; }
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
    /// <summary>
    /// List of headers to whitelist and allowing
    /// a plugin to include them in the response.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Specifies the default time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in
    /// the UI-specific listing endpoint. Valid values are &quot;unauth&quot; or &quot;hidden&quot;.
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Specifies the maximum time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    /// <summary>
    /// List of headers to whitelist and
    /// pass from the request to the backend.
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Specifies the type of tokens that should be returned by
    /// the mount. Valid values are &quot;default-service&quot;, &quot;default-batch&quot;, &quot;service&quot;, &quot;batch&quot;.
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusAtProvider
{
    /// <summary>
    /// The mount accessor related to the auth mount. It is useful for integration with Identity Secrets Engine.
    /// The mount accessor related to the auth mount.
    /// </summary>
    [JsonPropertyName("accessor")]
    public string? Accessor { get; set; }

    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// The API endpoint to use. Useful if you
    /// are running GitHub Enterprise or an API-compatible authentication server.
    /// The API endpoint to use. Useful if you are running GitHub Enterprise or an API-compatible authentication server.
    /// </summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>
    /// Specifies the description of the mount.
    /// This overrides the current stored value, if any.
    /// Specifies the description of the mount. This overrides the current stored value, if any.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If set, opts out of mount migration on path updates.
    /// See here for more info on Mount Migration
    /// If set, opts out of mount migration on path updates.
    /// </summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
    /// The organization configured users must be part of.
    /// The organization users must be part of.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// The ID of the organization users must be part of.
    /// Vault will attempt to fetch and set this value if it is not provided. (Vault 1.10+)
    /// The ID of the organization users must be part of. Vault will attempt to fetch and set this value if it is not provided (vault-1.10+)
    /// </summary>
    [JsonPropertyName("organizationId")]
    public double? OrganizationId { get; set; }

    /// <summary>
    /// Path where the auth backend is mounted. Defaults to auth/github
    /// if not specified.
    /// Path where the auth backend is mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// List of CIDR blocks; if set, specifies blocks of IP
    /// addresses which can authenticate successfully, and ties the resulting token to these blocks
    /// as well.
    /// Specifies the blocks of IP addresses which are allowed to use the generated token
    /// </summary>
    [JsonPropertyName("tokenBoundCidrs")]
    public IList<string>? TokenBoundCidrs { get; set; }

    /// <summary>
    /// If set, will encode an
    /// explicit max TTL
    /// onto the token in number of seconds. This is a hard cap even if token_ttl and
    /// token_max_ttl would otherwise allow a renewal.
    /// Generated Token&apos;s Explicit Maximum TTL in seconds
    /// </summary>
    [JsonPropertyName("tokenExplicitMaxTtl")]
    public double? TokenExplicitMaxTtl { get; set; }

    /// <summary>
    /// The maximum lifetime for generated tokens in number of seconds.
    /// Its current value will be referenced at renewal time.
    /// The maximum lifetime of the generated token
    /// </summary>
    [JsonPropertyName("tokenMaxTtl")]
    public double? TokenMaxTtl { get; set; }

    /// <summary>
    /// If set, the default policy will not be set on
    /// generated tokens; otherwise it will be added to the policies set in token_policies.
    /// If true, the &apos;default&apos; policy will not automatically be added to generated tokens
    /// </summary>
    [JsonPropertyName("tokenNoDefaultPolicy")]
    public bool? TokenNoDefaultPolicy { get; set; }

    /// <summary>
    /// The maximum number
    /// of times a generated token may be used (within its lifetime); 0 means unlimited.
    /// The maximum number of times a token may be used, a value of zero means unlimited
    /// </summary>
    [JsonPropertyName("tokenNumUses")]
    public double? TokenNumUses { get; set; }

    /// <summary>
    /// If set, indicates that the
    /// token generated using this role should never expire. The token should be renewed within the
    /// duration specified by this value. At each renewal, the token&apos;s TTL will be set to the
    /// value of this field. Specified in seconds.
    /// Generated Token&apos;s Period
    /// </summary>
    [JsonPropertyName("tokenPeriod")]
    public double? TokenPeriod { get; set; }

    /// <summary>
    /// List of policies to encode onto generated tokens. Depending
    /// on the auth method, this list may be supplemented by user/group/other values.
    /// Generated Token&apos;s Policies
    /// </summary>
    [JsonPropertyName("tokenPolicies")]
    public IList<string>? TokenPolicies { get; set; }

    /// <summary>
    /// The incremental lifetime for generated tokens in number of seconds.
    /// Its current value will be referenced at renewal time.
    /// The initial ttl of the token to generate in seconds
    /// </summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>
    /// The type of token that should be generated. Can be service,
    /// batch, or default to use the mount&apos;s tuned default (which unless changed will be
    /// service tokens). For token store roles, there are two additional possibilities:
    /// default-service and default-batch which specify the type to return unless the client
    /// requests a different type at generation time.
    /// The type of token to generate, service or batch
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    /// <summary>Extra configuration block. Structure is documented below.</summary>
    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendStatusAtProviderTune>? Tune { get; set; }
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

/// <summary>AuthBackend is the Schema for the AuthBackends API. Manages GitHub Auth mounts in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendSpec>, IStatus<V1alpha1AuthBackendStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackend";
    public const string KubeGroup = "github.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "github.vault.upbound.io/v1alpha1";

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