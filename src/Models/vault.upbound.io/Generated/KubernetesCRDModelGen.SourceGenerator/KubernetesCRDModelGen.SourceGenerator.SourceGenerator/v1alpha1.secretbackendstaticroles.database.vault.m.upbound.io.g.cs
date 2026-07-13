#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.database.vault.m.upbound.io;
/// <summary>SecretBackendStaticRole is the Schema for the SecretBackendStaticRoles API. Configures a database secret backend static role for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendStaticRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendStaticRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendStaticRoleList";
    public const string KubeGroup = "database.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendstaticroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "database.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendStaticRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendStaticRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendStaticRole> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelector
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
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretBackendConnection in database to populate dbName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretBackendConnection in database to populate dbName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelector
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
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The password corresponding to the username in the database.
/// Required when using the Rootless Password Rotation workflow for static roles. Only enabled for
/// select DB engines (Postgres). Requires Vault 1.18+ Enterprise.
/// Deprecated: Use password_wo instead. This field will be removed in a future version.
/// The password corresponding to the username in the database. Required when using the Rootless Password Rotation workflow for static roles. Deprecated in favor of password_wo field introduced in Vault 1.19.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProviderSelfManagedPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecForProvider
{
    /// <summary>
    /// The unique name of the Vault mount to configure.
    /// The path of the Database Secret Backend the role belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>The configuration for the credential type.Full documentation for the allowed values can be found under &quot;https://developer.hashicorp.com/vault/api-docs/secret/databases#credential_config&quot;.</summary>
    [JsonPropertyName("credentialConfig")]
    public IDictionary<string, string>? CredentialConfig { get; set; }

    /// <summary>The credential type for the user, can be one of &quot;password&quot;, &quot;rsa_private_key&quot; or &quot;client_certificate&quot;.The configuration can be done in `credential_config`.</summary>
    [JsonPropertyName("credentialType")]
    public string? CredentialType { get; set; }

    /// <summary>
    /// The unique name of the database connection to use for the static role.
    /// Database connection to use for this role.
    /// </summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }

    /// <summary>Reference to a SecretBackendConnection in database to populate dbName.</summary>
    [JsonPropertyName("dbNameRef")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameRef? DbNameRef { get; set; }

    /// <summary>Selector for a SecretBackendConnection in database to populate dbName.</summary>
    [JsonPropertyName("dbNameSelector")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderDbNameSelector? DbNameSelector { get; set; }

    /// <summary>
    /// A unique name to give the static role.
    /// Unique name for the static role.
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
    /// The password corresponding to the username in the database.
    /// This is a write-only field. Requires Vault 1.19+. Deprecates self_managed_password which was introduced in Vault 1.18.
    /// Cannot be used with self_managed_password.
    /// The password corresponding to the username in the database. This is a write-only field. Requires Vault 1.19+. Deprecates &apos;self_managed_password&apos; which was introduced in Vault 1.18.
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo field.
    /// Used for tracking changes to the write-only password field. For more info see
    /// updating write-only attributes.
    /// The version of the password_wo field. Used for tracking changes to the write-only password field.
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// The amount of time Vault should wait before rotating the password, in seconds.
    /// Mutually exclusive with rotation_schedule.
    /// The amount of time Vault should wait before rotating the password, in seconds.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// A cron-style string that will define the schedule on which rotations should occur.
    /// Mutually exclusive with rotation_period.
    /// A cron-style string that will define the schedule on which rotations should occur.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// Database statements to execute to rotate the password for the configured database user.
    /// Database statements to execute to rotate the password for the configured database user.
    /// </summary>
    [JsonPropertyName("rotationStatements")]
    public IList<string>? RotationStatements { get; set; }

    /// <summary>
    /// The amount of time, in seconds, in which rotations are allowed to occur starting
    /// from a given rotation_schedule.
    /// The amount of time in seconds in which the rotations are allowed to occur starting from a given rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// The password corresponding to the username in the database.
    /// Required when using the Rootless Password Rotation workflow for static roles. Only enabled for
    /// select DB engines (Postgres). Requires Vault 1.18+ Enterprise.
    /// Deprecated: Use password_wo instead. This field will be removed in a future version.
    /// The password corresponding to the username in the database. Required when using the Rootless Password Rotation workflow for static roles. Deprecated in favor of password_wo field introduced in Vault 1.19.
    /// </summary>
    [JsonPropertyName("selfManagedPasswordSecretRef")]
    public V1alpha1SecretBackendStaticRoleSpecForProviderSelfManagedPasswordSecretRef? SelfManagedPasswordSecretRef { get; set; }

    /// <summary>
    /// If set to true, Vault will skip the
    /// initial secret rotation on import. Requires Vault 1.18+ Enterprise.
    /// Skip rotation of the password on import. When not set, inherits from connection&apos;s skip_static_role_import_rotation.
    /// </summary>
    [JsonPropertyName("skipImportRotation")]
    public bool? SkipImportRotation { get; set; }

    /// <summary>
    /// The database username that this static role corresponds to.
    /// The database username that this role corresponds to.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretBackendConnection in database to populate dbName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretBackendConnection in database to populate dbName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelector
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
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The password corresponding to the username in the database.
/// Required when using the Rootless Password Rotation workflow for static roles. Only enabled for
/// select DB engines (Postgres). Requires Vault 1.18+ Enterprise.
/// Deprecated: Use password_wo instead. This field will be removed in a future version.
/// The password corresponding to the username in the database. Required when using the Rootless Password Rotation workflow for static roles. Deprecated in favor of password_wo field introduced in Vault 1.19.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpecInitProviderSelfManagedPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
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
public partial class V1alpha1SecretBackendStaticRoleSpecInitProvider
{
    /// <summary>
    /// The unique name of the Vault mount to configure.
    /// The path of the Database Secret Backend the role belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>The configuration for the credential type.Full documentation for the allowed values can be found under &quot;https://developer.hashicorp.com/vault/api-docs/secret/databases#credential_config&quot;.</summary>
    [JsonPropertyName("credentialConfig")]
    public IDictionary<string, string>? CredentialConfig { get; set; }

    /// <summary>The credential type for the user, can be one of &quot;password&quot;, &quot;rsa_private_key&quot; or &quot;client_certificate&quot;.The configuration can be done in `credential_config`.</summary>
    [JsonPropertyName("credentialType")]
    public string? CredentialType { get; set; }

    /// <summary>
    /// The unique name of the database connection to use for the static role.
    /// Database connection to use for this role.
    /// </summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }

    /// <summary>Reference to a SecretBackendConnection in database to populate dbName.</summary>
    [JsonPropertyName("dbNameRef")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameRef? DbNameRef { get; set; }

    /// <summary>Selector for a SecretBackendConnection in database to populate dbName.</summary>
    [JsonPropertyName("dbNameSelector")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderDbNameSelector? DbNameSelector { get; set; }

    /// <summary>
    /// A unique name to give the static role.
    /// Unique name for the static role.
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
    /// The password corresponding to the username in the database.
    /// This is a write-only field. Requires Vault 1.19+. Deprecates self_managed_password which was introduced in Vault 1.18.
    /// Cannot be used with self_managed_password.
    /// The password corresponding to the username in the database. This is a write-only field. Requires Vault 1.19+. Deprecates &apos;self_managed_password&apos; which was introduced in Vault 1.18.
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo field.
    /// Used for tracking changes to the write-only password field. For more info see
    /// updating write-only attributes.
    /// The version of the password_wo field. Used for tracking changes to the write-only password field.
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// The amount of time Vault should wait before rotating the password, in seconds.
    /// Mutually exclusive with rotation_schedule.
    /// The amount of time Vault should wait before rotating the password, in seconds.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// A cron-style string that will define the schedule on which rotations should occur.
    /// Mutually exclusive with rotation_period.
    /// A cron-style string that will define the schedule on which rotations should occur.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// Database statements to execute to rotate the password for the configured database user.
    /// Database statements to execute to rotate the password for the configured database user.
    /// </summary>
    [JsonPropertyName("rotationStatements")]
    public IList<string>? RotationStatements { get; set; }

    /// <summary>
    /// The amount of time, in seconds, in which rotations are allowed to occur starting
    /// from a given rotation_schedule.
    /// The amount of time in seconds in which the rotations are allowed to occur starting from a given rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// The password corresponding to the username in the database.
    /// Required when using the Rootless Password Rotation workflow for static roles. Only enabled for
    /// select DB engines (Postgres). Requires Vault 1.18+ Enterprise.
    /// Deprecated: Use password_wo instead. This field will be removed in a future version.
    /// The password corresponding to the username in the database. Required when using the Rootless Password Rotation workflow for static roles. Deprecated in favor of password_wo field introduced in Vault 1.19.
    /// </summary>
    [JsonPropertyName("selfManagedPasswordSecretRef")]
    public V1alpha1SecretBackendStaticRoleSpecInitProviderSelfManagedPasswordSecretRef? SelfManagedPasswordSecretRef { get; set; }

    /// <summary>
    /// If set to true, Vault will skip the
    /// initial secret rotation on import. Requires Vault 1.18+ Enterprise.
    /// Skip rotation of the password on import. When not set, inherits from connection&apos;s skip_static_role_import_rotation.
    /// </summary>
    [JsonPropertyName("skipImportRotation")]
    public bool? SkipImportRotation { get; set; }

    /// <summary>
    /// The database username that this static role corresponds to.
    /// The database username that this role corresponds to.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendStaticRoleSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendStaticRoleSpecManagementPoliciesEnum
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
public partial class V1alpha1SecretBackendStaticRoleSpecProviderConfigRef
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
public partial class V1alpha1SecretBackendStaticRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretBackendStaticRoleSpec defines the desired state of SecretBackendStaticRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendStaticRoleSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendStaticRoleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretBackendStaticRoleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendStaticRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendStaticRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleStatusAtProvider
{
    /// <summary>
    /// The unique name of the Vault mount to configure.
    /// The path of the Database Secret Backend the role belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>The configuration for the credential type.Full documentation for the allowed values can be found under &quot;https://developer.hashicorp.com/vault/api-docs/secret/databases#credential_config&quot;.</summary>
    [JsonPropertyName("credentialConfig")]
    public IDictionary<string, string>? CredentialConfig { get; set; }

    /// <summary>The credential type for the user, can be one of &quot;password&quot;, &quot;rsa_private_key&quot; or &quot;client_certificate&quot;.The configuration can be done in `credential_config`.</summary>
    [JsonPropertyName("credentialType")]
    public string? CredentialType { get; set; }

    /// <summary>
    /// The unique name of the database connection to use for the static role.
    /// Database connection to use for this role.
    /// </summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A unique name to give the static role.
    /// Unique name for the static role.
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
    /// The password corresponding to the username in the database.
    /// This is a write-only field. Requires Vault 1.19+. Deprecates self_managed_password which was introduced in Vault 1.18.
    /// Cannot be used with self_managed_password.
    /// The password corresponding to the username in the database. This is a write-only field. Requires Vault 1.19+. Deprecates &apos;self_managed_password&apos; which was introduced in Vault 1.18.
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo field.
    /// Used for tracking changes to the write-only password field. For more info see
    /// updating write-only attributes.
    /// The version of the password_wo field. Used for tracking changes to the write-only password field.
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// The amount of time Vault should wait before rotating the password, in seconds.
    /// Mutually exclusive with rotation_schedule.
    /// The amount of time Vault should wait before rotating the password, in seconds.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// A cron-style string that will define the schedule on which rotations should occur.
    /// Mutually exclusive with rotation_period.
    /// A cron-style string that will define the schedule on which rotations should occur.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// Database statements to execute to rotate the password for the configured database user.
    /// Database statements to execute to rotate the password for the configured database user.
    /// </summary>
    [JsonPropertyName("rotationStatements")]
    public IList<string>? RotationStatements { get; set; }

    /// <summary>
    /// The amount of time, in seconds, in which rotations are allowed to occur starting
    /// from a given rotation_schedule.
    /// The amount of time in seconds in which the rotations are allowed to occur starting from a given rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// If set to true, Vault will skip the
    /// initial secret rotation on import. Requires Vault 1.18+ Enterprise.
    /// Skip rotation of the password on import. When not set, inherits from connection&apos;s skip_static_role_import_rotation.
    /// </summary>
    [JsonPropertyName("skipImportRotation")]
    public bool? SkipImportRotation { get; set; }

    /// <summary>
    /// The database username that this static role corresponds to.
    /// The database username that this role corresponds to.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleStatusConditions
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

/// <summary>SecretBackendStaticRoleStatus defines the observed state of SecretBackendStaticRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStaticRoleStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendStaticRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendStaticRoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendStaticRole is the Schema for the SecretBackendStaticRoles API. Configures a database secret backend static role for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendStaticRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendStaticRoleSpec>, IStatus<V1alpha1SecretBackendStaticRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendStaticRole";
    public const string KubeGroup = "database.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendstaticroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "database.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendStaticRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendStaticRoleSpec defines the desired state of SecretBackendStaticRole</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendStaticRoleSpec Spec { get; set; }

    /// <summary>SecretBackendStaticRoleStatus defines the observed state of SecretBackendStaticRole.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendStaticRoleStatus? Status { get; set; }
}