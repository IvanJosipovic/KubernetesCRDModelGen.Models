#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kubernetes.vault.m.upbound.io;
/// <summary>AuthBackendRole is the Schema for the AuthBackendRoles API. Manages Kubernetes auth backend roles in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackendRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendRoleList";
    public const string KubeGroup = "kubernetes.vault.m.upbound.io";
    public const string KubePluralName = "authbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetes.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AuthBackendRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AuthBackendRole> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecForProviderBackendSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecForProvider
{
    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// Configures how identity aliases are generated.
    /// Valid choices are: serviceaccount_uid, serviceaccount_name. (vault-1.9+)
    /// Configures how identity aliases are generated. Valid choices are: serviceaccount_uid, serviceaccount_name
    /// </summary>
    [JsonPropertyName("aliasNameSource")]
    public string? AliasNameSource { get; set; }

    /// <summary>
    /// Audience claim to verify in the JWT.
    /// Optional Audience claim to verify in the JWT.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Unique name of the kubernetes backend to configure.
    /// Unique name of the kubernetes backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1AuthBackendRoleSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// List of service account names able to access this role. If set to [&quot;*&quot;] all names are allowed, both this and bound_service_account_namespaces can not be &quot;*&quot;.
    /// List of service account names able to access this role. If set to `[&quot;*&quot;]` all names are allowed, both this and bound_service_account_namespaces can not be &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNames")]
    public IList<string>? BoundServiceAccountNames { get; set; }

    /// <summary>
    /// A label selector for Kubernetes namespaces allowed to access this role. Accepts either a JSON or YAML object. The value should be of type LabelSelector. Currently, label selectors with matchExpressions are not supported. To use label selectors, Vault must have permission to read namespaces on the Kubernetes cluster. If set with bound_service_account_namespaces, the conditions are ORed. Requires Vault v1.16+.
    /// A label selector for Kubernetes namespaces allowed to access this role. Accepts either a JSON or YAML object. The value should be of type LabelSelector. Currently, label selectors with matchExpressions are not supported. To use label selectors, Vault must have permission to read namespaces on the Kubernetes cluster. If set with bound_service_account_namespaces, the conditions are ORed.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNamespaceSelector")]
    public string? BoundServiceAccountNamespaceSelector { get; set; }

    /// <summary>
    /// List of namespaces allowed to access this role. If set to [&quot;*&quot;] all namespaces are allowed, both this and bound_service_account_names can not be set to &quot;*&quot;.
    /// List of namespaces allowed to access this role. If set to `[&quot;*&quot;]` all namespaces are allowed, both this and bound_service_account_names can not be set to &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNamespaces")]
    public IList<string>? BoundServiceAccountNamespaces { get; set; }

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
    /// Name of the role.
    /// Name of the role.
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

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

    /// <summary>The initial ttl of the token to generate in seconds</summary>
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
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecInitProviderBackendSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1AuthBackendRoleSpecInitProvider
{
    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// Configures how identity aliases are generated.
    /// Valid choices are: serviceaccount_uid, serviceaccount_name. (vault-1.9+)
    /// Configures how identity aliases are generated. Valid choices are: serviceaccount_uid, serviceaccount_name
    /// </summary>
    [JsonPropertyName("aliasNameSource")]
    public string? AliasNameSource { get; set; }

    /// <summary>
    /// Audience claim to verify in the JWT.
    /// Optional Audience claim to verify in the JWT.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Unique name of the kubernetes backend to configure.
    /// Unique name of the kubernetes backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1AuthBackendRoleSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// List of service account names able to access this role. If set to [&quot;*&quot;] all names are allowed, both this and bound_service_account_namespaces can not be &quot;*&quot;.
    /// List of service account names able to access this role. If set to `[&quot;*&quot;]` all names are allowed, both this and bound_service_account_namespaces can not be &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNames")]
    public IList<string>? BoundServiceAccountNames { get; set; }

    /// <summary>
    /// A label selector for Kubernetes namespaces allowed to access this role. Accepts either a JSON or YAML object. The value should be of type LabelSelector. Currently, label selectors with matchExpressions are not supported. To use label selectors, Vault must have permission to read namespaces on the Kubernetes cluster. If set with bound_service_account_namespaces, the conditions are ORed. Requires Vault v1.16+.
    /// A label selector for Kubernetes namespaces allowed to access this role. Accepts either a JSON or YAML object. The value should be of type LabelSelector. Currently, label selectors with matchExpressions are not supported. To use label selectors, Vault must have permission to read namespaces on the Kubernetes cluster. If set with bound_service_account_namespaces, the conditions are ORed.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNamespaceSelector")]
    public string? BoundServiceAccountNamespaceSelector { get; set; }

    /// <summary>
    /// List of namespaces allowed to access this role. If set to [&quot;*&quot;] all namespaces are allowed, both this and bound_service_account_names can not be set to &quot;*&quot;.
    /// List of namespaces allowed to access this role. If set to `[&quot;*&quot;]` all namespaces are allowed, both this and bound_service_account_names can not be set to &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNamespaces")]
    public IList<string>? BoundServiceAccountNamespaces { get; set; }

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
    /// Name of the role.
    /// Name of the role.
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

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

    /// <summary>The initial ttl of the token to generate in seconds</summary>
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
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendRoleSpecManagementPoliciesEnum>))]
public enum V1alpha1AuthBackendRoleSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AuthBackendRoleSpec defines the desired state of AuthBackendRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1AuthBackendRoleSpecForProvider ForProvider { get; set; }

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
    public V1alpha1AuthBackendRoleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1AuthBackendRoleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1AuthBackendRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1AuthBackendRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleStatusAtProvider
{
    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// Configures how identity aliases are generated.
    /// Valid choices are: serviceaccount_uid, serviceaccount_name. (vault-1.9+)
    /// Configures how identity aliases are generated. Valid choices are: serviceaccount_uid, serviceaccount_name
    /// </summary>
    [JsonPropertyName("aliasNameSource")]
    public string? AliasNameSource { get; set; }

    /// <summary>
    /// Audience claim to verify in the JWT.
    /// Optional Audience claim to verify in the JWT.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Unique name of the kubernetes backend to configure.
    /// Unique name of the kubernetes backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// List of service account names able to access this role. If set to [&quot;*&quot;] all names are allowed, both this and bound_service_account_namespaces can not be &quot;*&quot;.
    /// List of service account names able to access this role. If set to `[&quot;*&quot;]` all names are allowed, both this and bound_service_account_namespaces can not be &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNames")]
    public IList<string>? BoundServiceAccountNames { get; set; }

    /// <summary>
    /// A label selector for Kubernetes namespaces allowed to access this role. Accepts either a JSON or YAML object. The value should be of type LabelSelector. Currently, label selectors with matchExpressions are not supported. To use label selectors, Vault must have permission to read namespaces on the Kubernetes cluster. If set with bound_service_account_namespaces, the conditions are ORed. Requires Vault v1.16+.
    /// A label selector for Kubernetes namespaces allowed to access this role. Accepts either a JSON or YAML object. The value should be of type LabelSelector. Currently, label selectors with matchExpressions are not supported. To use label selectors, Vault must have permission to read namespaces on the Kubernetes cluster. If set with bound_service_account_namespaces, the conditions are ORed.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNamespaceSelector")]
    public string? BoundServiceAccountNamespaceSelector { get; set; }

    /// <summary>
    /// List of namespaces allowed to access this role. If set to [&quot;*&quot;] all namespaces are allowed, both this and bound_service_account_names can not be set to &quot;*&quot;.
    /// List of namespaces allowed to access this role. If set to `[&quot;*&quot;]` all namespaces are allowed, both this and bound_service_account_names can not be set to &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("boundServiceAccountNamespaces")]
    public IList<string>? BoundServiceAccountNamespaces { get; set; }

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
    /// Name of the role.
    /// Name of the role.
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

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

    /// <summary>The initial ttl of the token to generate in seconds</summary>
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
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleStatusConditions
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

/// <summary>AuthBackendRoleStatus defines the observed state of AuthBackendRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1AuthBackendRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthBackendRoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AuthBackendRole is the Schema for the AuthBackendRoles API. Manages Kubernetes auth backend roles in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendRoleSpec>, IStatus<V1alpha1AuthBackendRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendRole";
    public const string KubeGroup = "kubernetes.vault.m.upbound.io";
    public const string KubePluralName = "authbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetes.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthBackendRoleSpec defines the desired state of AuthBackendRole</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AuthBackendRoleSpec Spec { get; set; }

    /// <summary>AuthBackendRoleStatus defines the observed state of AuthBackendRole.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthBackendRoleStatus? Status { get; set; }
}