#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.okta.vault.upbound.io;
/// <summary>AuthBackend is the Schema for the AuthBackends API. &lt;no value&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackend>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendList";
    public const string KubeGroup = "okta.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "okta.vault.upbound.io/v1alpha1";

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

/// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderApiTokenSecretRef
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

/// <summary>Write-only Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderApiTokenWoSecretRef
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
public partial class V1alpha1AuthBackendSpecForProviderGroup
{
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }
}

/// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled. Use api_token instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderTokenSecretRef
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
public partial class V1alpha1AuthBackendSpecForProviderUser
{
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
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

    /// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
    [JsonPropertyName("apiTokenSecretRef")]
    public V1alpha1AuthBackendSpecForProviderApiTokenSecretRef? ApiTokenSecretRef { get; set; }

    /// <summary>Write-only Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
    [JsonPropertyName("apiTokenWoSecretRef")]
    public V1alpha1AuthBackendSpecForProviderApiTokenWoSecretRef? ApiTokenWoSecretRef { get; set; }

    /// <summary>Version counter for write-only api_token.</summary>
    [JsonPropertyName("apiTokenWoVersion")]
    public double? ApiTokenWoVersion { get; set; }

    /// <summary>The Okta url. Examples: oktapreview.com, okta.com (default)</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>When true, requests by Okta for a MFA check will be bypassed. This also disallows certain status checks on the account, such as whether the password is expired.</summary>
    [JsonPropertyName("bypassOktaMfa")]
    public bool? BypassOktaMfa { get; set; }

    /// <summary>The description of the auth backend</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set, opts out of mount migration on path updates.</summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("group")]
    public IList<V1alpha1AuthBackendSpecForProviderGroup>? Group { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The Okta organization. This will be the first part of the url https://XXX.okta.com.</summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }

    /// <summary>The Okta organization. This will be the first part of the url https://XXX.okta.com. Use org_name instead.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>path to mount the backend</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

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

    /// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled. Use api_token instead.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1alpha1AuthBackendSpecForProviderTokenSecretRef? TokenSecretRef { get; set; }

    /// <summary>The initial ttl of the token to generate in seconds</summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>The type of token to generate, service or batch</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecForProviderTune>? Tune { get; set; }

    [JsonPropertyName("user")]
    public IList<V1alpha1AuthBackendSpecForProviderUser>? User { get; set; }
}

/// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderApiTokenSecretRef
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

/// <summary>Write-only Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderApiTokenWoSecretRef
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
public partial class V1alpha1AuthBackendSpecInitProviderGroup
{
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }
}

/// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled. Use api_token instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderTokenSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderUser
{
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
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

    /// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
    [JsonPropertyName("apiTokenSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderApiTokenSecretRef? ApiTokenSecretRef { get; set; }

    /// <summary>Write-only Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled.</summary>
    [JsonPropertyName("apiTokenWoSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderApiTokenWoSecretRef? ApiTokenWoSecretRef { get; set; }

    /// <summary>Version counter for write-only api_token.</summary>
    [JsonPropertyName("apiTokenWoVersion")]
    public double? ApiTokenWoVersion { get; set; }

    /// <summary>The Okta url. Examples: oktapreview.com, okta.com (default)</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>When true, requests by Okta for a MFA check will be bypassed. This also disallows certain status checks on the account, such as whether the password is expired.</summary>
    [JsonPropertyName("bypassOktaMfa")]
    public bool? BypassOktaMfa { get; set; }

    /// <summary>The description of the auth backend</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set, opts out of mount migration on path updates.</summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("group")]
    public IList<V1alpha1AuthBackendSpecInitProviderGroup>? Group { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The Okta organization. This will be the first part of the url https://XXX.okta.com.</summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }

    /// <summary>The Okta organization. This will be the first part of the url https://XXX.okta.com. Use org_name instead.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>path to mount the backend</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

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

    /// <summary>The Okta API token. This is required to query Okta for user group membership. If this is not supplied only locally configured groups will be enabled. Use api_token instead.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderTokenSecretRef? TokenSecretRef { get; set; }

    /// <summary>The initial ttl of the token to generate in seconds</summary>
    [JsonPropertyName("tokenTtl")]
    public double? TokenTtl { get; set; }

    /// <summary>The type of token to generate, service or batch</summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecInitProviderTune>? Tune { get; set; }

    [JsonPropertyName("user")]
    public IList<V1alpha1AuthBackendSpecInitProviderUser>? User { get; set; }
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
public partial class V1alpha1AuthBackendStatusAtProviderGroup
{
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }
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
public partial class V1alpha1AuthBackendStatusAtProviderUser
{
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    [JsonPropertyName("policies")]
    public IList<string>? Policies { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusAtProvider
{
    /// <summary>The mount accessor related to the auth mount.</summary>
    [JsonPropertyName("accessor")]
    public string? Accessor { get; set; }

    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>Version counter for write-only api_token.</summary>
    [JsonPropertyName("apiTokenWoVersion")]
    public double? ApiTokenWoVersion { get; set; }

    /// <summary>The Okta url. Examples: oktapreview.com, okta.com (default)</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>When true, requests by Okta for a MFA check will be bypassed. This also disallows certain status checks on the account, such as whether the password is expired.</summary>
    [JsonPropertyName("bypassOktaMfa")]
    public bool? BypassOktaMfa { get; set; }

    /// <summary>The description of the auth backend</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set, opts out of mount migration on path updates.</summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("group")]
    public IList<V1alpha1AuthBackendStatusAtProviderGroup>? Group { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The Okta organization. This will be the first part of the url https://XXX.okta.com.</summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }

    /// <summary>The Okta organization. This will be the first part of the url https://XXX.okta.com. Use org_name instead.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>path to mount the backend</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

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

    [JsonPropertyName("user")]
    public IList<V1alpha1AuthBackendStatusAtProviderUser>? User { get; set; }
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
    public const string KubeGroup = "okta.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "okta.vault.upbound.io/v1alpha1";

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