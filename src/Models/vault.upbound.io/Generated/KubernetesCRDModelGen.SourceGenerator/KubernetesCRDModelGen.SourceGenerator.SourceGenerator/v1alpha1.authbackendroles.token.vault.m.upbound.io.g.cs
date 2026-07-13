#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.token.vault.m.upbound.io;
/// <summary>AuthBackendRole is the Schema for the AuthBackendRoles API. Manages Token auth backend roles in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackendRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendRoleList";
    public const string KubeGroup = "token.vault.m.upbound.io";
    public const string KubePluralName = "authbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "token.vault.m.upbound.io/v1alpha1";

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
    /// List of allowed entity aliases.
    /// Set of allowed entity aliases for this role.
    /// </summary>
    [JsonPropertyName("allowedEntityAliases")]
    public IList<string>? AllowedEntityAliases { get; set; }

    /// <summary>
    /// List of allowed policies for given role.
    /// List of allowed policies for given role.
    /// </summary>
    [JsonPropertyName("allowedPolicies")]
    public IList<string>? AllowedPolicies { get; set; }

    /// <summary>
    /// Set of allowed policies with glob match for given role.
    /// Set of allowed policies with glob match for given role.
    /// </summary>
    [JsonPropertyName("allowedPoliciesGlob")]
    public IList<string>? AllowedPoliciesGlob { get; set; }

    /// <summary>
    /// List of disallowed policies for given role.
    /// List of disallowed policies for given role.
    /// </summary>
    [JsonPropertyName("disallowedPolicies")]
    public IList<string>? DisallowedPolicies { get; set; }

    /// <summary>
    /// Set of disallowed policies with glob match for given role.
    /// Set of disallowed policies with glob match for given role.
    /// </summary>
    [JsonPropertyName("disallowedPoliciesGlob")]
    public IList<string>? DisallowedPoliciesGlob { get; set; }

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
    /// If true, tokens created against this policy will be orphan tokens.
    /// If true, tokens created against this policy will be orphan tokens.
    /// </summary>
    [JsonPropertyName("orphan")]
    public bool? Orphan { get; set; }

    /// <summary>
    /// Tokens created against this role will have the given suffix as part of their path in addition to the role name.
    /// Tokens created against this role will have the given suffix as part of their path in addition to the role name.
    /// </summary>
    [JsonPropertyName("pathSuffix")]
    public string? PathSuffix { get; set; }

    /// <summary>
    /// Whether to disable the ability of the token to be renewed past its initial TTL.
    /// Whether to disable the ability of the token to be renewed past its initial TTL.
    /// </summary>
    [JsonPropertyName("renewable")]
    public bool? Renewable { get; set; }

    /// <summary>
    /// The name of the role.
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

    /// <summary>Generated Token&apos;s Policies</summary>
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
public partial class V1alpha1AuthBackendRoleSpecInitProvider
{
    /// <summary>
    /// The metadata to be tied to generated entity alias.
    /// This should be a list or map containing the metadata in key value pairs.
    /// </summary>
    [JsonPropertyName("aliasMetadata")]
    public IDictionary<string, string>? AliasMetadata { get; set; }

    /// <summary>
    /// List of allowed entity aliases.
    /// Set of allowed entity aliases for this role.
    /// </summary>
    [JsonPropertyName("allowedEntityAliases")]
    public IList<string>? AllowedEntityAliases { get; set; }

    /// <summary>
    /// List of allowed policies for given role.
    /// List of allowed policies for given role.
    /// </summary>
    [JsonPropertyName("allowedPolicies")]
    public IList<string>? AllowedPolicies { get; set; }

    /// <summary>
    /// Set of allowed policies with glob match for given role.
    /// Set of allowed policies with glob match for given role.
    /// </summary>
    [JsonPropertyName("allowedPoliciesGlob")]
    public IList<string>? AllowedPoliciesGlob { get; set; }

    /// <summary>
    /// List of disallowed policies for given role.
    /// List of disallowed policies for given role.
    /// </summary>
    [JsonPropertyName("disallowedPolicies")]
    public IList<string>? DisallowedPolicies { get; set; }

    /// <summary>
    /// Set of disallowed policies with glob match for given role.
    /// Set of disallowed policies with glob match for given role.
    /// </summary>
    [JsonPropertyName("disallowedPoliciesGlob")]
    public IList<string>? DisallowedPoliciesGlob { get; set; }

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
    /// If true, tokens created against this policy will be orphan tokens.
    /// If true, tokens created against this policy will be orphan tokens.
    /// </summary>
    [JsonPropertyName("orphan")]
    public bool? Orphan { get; set; }

    /// <summary>
    /// Tokens created against this role will have the given suffix as part of their path in addition to the role name.
    /// Tokens created against this role will have the given suffix as part of their path in addition to the role name.
    /// </summary>
    [JsonPropertyName("pathSuffix")]
    public string? PathSuffix { get; set; }

    /// <summary>
    /// Whether to disable the ability of the token to be renewed past its initial TTL.
    /// Whether to disable the ability of the token to be renewed past its initial TTL.
    /// </summary>
    [JsonPropertyName("renewable")]
    public bool? Renewable { get; set; }

    /// <summary>
    /// The name of the role.
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

    /// <summary>Generated Token&apos;s Policies</summary>
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
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AuthBackendRoleSpec defines the desired state of AuthBackendRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
    /// List of allowed entity aliases.
    /// Set of allowed entity aliases for this role.
    /// </summary>
    [JsonPropertyName("allowedEntityAliases")]
    public IList<string>? AllowedEntityAliases { get; set; }

    /// <summary>
    /// List of allowed policies for given role.
    /// List of allowed policies for given role.
    /// </summary>
    [JsonPropertyName("allowedPolicies")]
    public IList<string>? AllowedPolicies { get; set; }

    /// <summary>
    /// Set of allowed policies with glob match for given role.
    /// Set of allowed policies with glob match for given role.
    /// </summary>
    [JsonPropertyName("allowedPoliciesGlob")]
    public IList<string>? AllowedPoliciesGlob { get; set; }

    /// <summary>
    /// List of disallowed policies for given role.
    /// List of disallowed policies for given role.
    /// </summary>
    [JsonPropertyName("disallowedPolicies")]
    public IList<string>? DisallowedPolicies { get; set; }

    /// <summary>
    /// Set of disallowed policies with glob match for given role.
    /// Set of disallowed policies with glob match for given role.
    /// </summary>
    [JsonPropertyName("disallowedPoliciesGlob")]
    public IList<string>? DisallowedPoliciesGlob { get; set; }

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
    /// If true, tokens created against this policy will be orphan tokens.
    /// If true, tokens created against this policy will be orphan tokens.
    /// </summary>
    [JsonPropertyName("orphan")]
    public bool? Orphan { get; set; }

    /// <summary>
    /// Tokens created against this role will have the given suffix as part of their path in addition to the role name.
    /// Tokens created against this role will have the given suffix as part of their path in addition to the role name.
    /// </summary>
    [JsonPropertyName("pathSuffix")]
    public string? PathSuffix { get; set; }

    /// <summary>
    /// Whether to disable the ability of the token to be renewed past its initial TTL.
    /// Whether to disable the ability of the token to be renewed past its initial TTL.
    /// </summary>
    [JsonPropertyName("renewable")]
    public bool? Renewable { get; set; }

    /// <summary>
    /// The name of the role.
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

    /// <summary>Generated Token&apos;s Policies</summary>
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
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>AuthBackendRole is the Schema for the AuthBackendRoles API. Manages Token auth backend roles in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendRoleSpec>, IStatus<V1alpha1AuthBackendRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendRole";
    public const string KubeGroup = "token.vault.m.upbound.io";
    public const string KubePluralName = "authbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "token.vault.m.upbound.io/v1alpha1";

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