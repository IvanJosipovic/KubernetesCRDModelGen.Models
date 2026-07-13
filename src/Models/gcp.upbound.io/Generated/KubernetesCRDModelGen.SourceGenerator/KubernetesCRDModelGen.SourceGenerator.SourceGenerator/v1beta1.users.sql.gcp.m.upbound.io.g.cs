#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.gcp.m.upbound.io;
/// <summary>User is the Schema for the Users API. Creates a new SQL user in Google Cloud SQL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserList : IKubernetesObject<V1ListMeta>, IItems<V1beta1User>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserList";
    public const string KubeGroup = "sql.gcp.m.upbound.io";
    public const string KubePluralName = "users";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1User objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1User> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecForProviderInstanceRefPolicyResolutionEnum>))]
public enum V1beta1UserSpecForProviderInstanceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecForProviderInstanceRefPolicyResolveEnum>))]
public enum V1beta1UserSpecForProviderInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserSpecForProviderInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserSpecForProviderInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserSpecForProviderInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecForProviderInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta1UserSpecForProviderInstanceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecForProviderInstanceSelectorPolicyResolveEnum>))]
public enum V1beta1UserSpecForProviderInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserSpecForProviderInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserSpecForProviderInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderInstanceSelector
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
    public V1beta1UserSpecForProviderInstanceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderPasswordPolicy
{
    /// <summary>Number of failed attempts allowed before the user get locked.</summary>
    [JsonPropertyName("allowedFailedAttempts")]
    public double? AllowedFailedAttempts { get; set; }

    /// <summary>If true, the check that will lock user after too many failed login attempts will be enabled.</summary>
    [JsonPropertyName("enableFailedAttemptsCheck")]
    public bool? EnableFailedAttemptsCheck { get; set; }

    /// <summary>If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.</summary>
    [JsonPropertyName("enablePasswordVerification")]
    public bool? EnablePasswordVerification { get; set; }

    /// <summary>Password expiration duration with one week grace period.</summary>
    [JsonPropertyName("passwordExpirationDuration")]
    public string? PasswordExpirationDuration { get; set; }
}

/// <summary>
/// The password for the user. Can be updated. For Postgres
/// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
/// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
/// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProviderPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecForProvider
{
    /// <summary>
    /// The deletion policy for the user.
    /// Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful
    /// for Postgres, where users cannot be deleted from the API if they have been granted SQL roles.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The host the user can connect from. This is only supported
    /// for BUILT_IN users in MySQL instances. Don&apos;t set this field for PostgreSQL and SQL Server instances.
    /// Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this
    /// forces a new resource to be created.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1UserSpecForProviderInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta1UserSpecForProviderInstanceSelector? InstanceSelector { get; set; }

    [JsonPropertyName("passwordPolicy")]
    public V1beta1UserSpecForProviderPasswordPolicy? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres
    /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
    /// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
    /// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1UserSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres
    /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
    /// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
    /// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
    /// Note: This property is write-only and will not be read from the API.
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>The version of the password_wo. For more info see updating write-only attributes.</summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The user type. It determines the method to authenticate the
    /// user during login. The default is the database&apos;s built-in user type. Flags
    /// include &quot;BUILT_IN&quot;, &quot;CLOUD_IAM_USER&quot;, &quot;CLOUD_IAM_SERVICE_ACCOUNT&quot;, &quot;CLOUD_IAM_GROUP&quot;,
    /// &quot;CLOUD_IAM_GROUP_USER&quot; and &quot;CLOUD_IAM_GROUP_SERVICE_ACCOUNT&quot; for
    /// Postgres
    /// and MySQL.
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecInitProviderInstanceRefPolicyResolutionEnum>))]
public enum V1beta1UserSpecInitProviderInstanceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecInitProviderInstanceRefPolicyResolveEnum>))]
public enum V1beta1UserSpecInitProviderInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserSpecInitProviderInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserSpecInitProviderInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserSpecInitProviderInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecInitProviderInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta1UserSpecInitProviderInstanceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecInitProviderInstanceSelectorPolicyResolveEnum>))]
public enum V1beta1UserSpecInitProviderInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1UserSpecInitProviderInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1UserSpecInitProviderInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderInstanceSelector
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
    public V1beta1UserSpecInitProviderInstanceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderPasswordPolicy
{
    /// <summary>Number of failed attempts allowed before the user get locked.</summary>
    [JsonPropertyName("allowedFailedAttempts")]
    public double? AllowedFailedAttempts { get; set; }

    /// <summary>If true, the check that will lock user after too many failed login attempts will be enabled.</summary>
    [JsonPropertyName("enableFailedAttemptsCheck")]
    public bool? EnableFailedAttemptsCheck { get; set; }

    /// <summary>If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.</summary>
    [JsonPropertyName("enablePasswordVerification")]
    public bool? EnablePasswordVerification { get; set; }

    /// <summary>Password expiration duration with one week grace period.</summary>
    [JsonPropertyName("passwordExpirationDuration")]
    public string? PasswordExpirationDuration { get; set; }
}

/// <summary>
/// The password for the user. Can be updated. For Postgres
/// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
/// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
/// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpecInitProviderPasswordSecretRef
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
public partial class V1beta1UserSpecInitProvider
{
    /// <summary>
    /// The deletion policy for the user.
    /// Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful
    /// for Postgres, where users cannot be deleted from the API if they have been granted SQL roles.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The host the user can connect from. This is only supported
    /// for BUILT_IN users in MySQL instances. Don&apos;t set this field for PostgreSQL and SQL Server instances.
    /// Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this
    /// forces a new resource to be created.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1UserSpecInitProviderInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta1UserSpecInitProviderInstanceSelector? InstanceSelector { get; set; }

    [JsonPropertyName("passwordPolicy")]
    public V1beta1UserSpecInitProviderPasswordPolicy? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres
    /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
    /// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
    /// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1UserSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres
    /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
    /// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
    /// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
    /// Note: This property is write-only and will not be read from the API.
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>The version of the password_wo. For more info see updating write-only attributes.</summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The user type. It determines the method to authenticate the
    /// user during login. The default is the database&apos;s built-in user type. Flags
    /// include &quot;BUILT_IN&quot;, &quot;CLOUD_IAM_USER&quot;, &quot;CLOUD_IAM_SERVICE_ACCOUNT&quot;, &quot;CLOUD_IAM_GROUP&quot;,
    /// &quot;CLOUD_IAM_GROUP_USER&quot; and &quot;CLOUD_IAM_GROUP_SERVICE_ACCOUNT&quot; for
    /// Postgres
    /// and MySQL.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserSpecManagementPoliciesEnum>))]
public enum V1beta1UserSpecManagementPoliciesEnum
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
public partial class V1beta1UserSpecProviderConfigRef
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
public partial class V1beta1UserSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>UserSpec defines the desired state of User</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1UserSpecForProvider ForProvider { get; set; }

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
    public V1beta1UserSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1UserSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderPasswordPolicyStatus
{
    /// <summary>(read only) If true, user does not have login privileges.</summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary>(read only) Password expiration duration with one week grace period.</summary>
    [JsonPropertyName("passwordExpirationTime")]
    public string? PasswordExpirationTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderPasswordPolicy
{
    /// <summary>Number of failed attempts allowed before the user get locked.</summary>
    [JsonPropertyName("allowedFailedAttempts")]
    public double? AllowedFailedAttempts { get; set; }

    /// <summary>If true, the check that will lock user after too many failed login attempts will be enabled.</summary>
    [JsonPropertyName("enableFailedAttemptsCheck")]
    public bool? EnableFailedAttemptsCheck { get; set; }

    /// <summary>If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.</summary>
    [JsonPropertyName("enablePasswordVerification")]
    public bool? EnablePasswordVerification { get; set; }

    /// <summary>Password expiration duration with one week grace period.</summary>
    [JsonPropertyName("passwordExpirationDuration")]
    public string? PasswordExpirationDuration { get; set; }

    [JsonPropertyName("status")]
    public IList<V1beta1UserStatusAtProviderPasswordPolicyStatus>? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProviderSqlServerUserDetails
{
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    [JsonPropertyName("serverRoles")]
    public IList<string>? ServerRoles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusAtProvider
{
    /// <summary>
    /// The deletion policy for the user.
    /// Setting ABANDON allows the resource to be abandoned rather than deleted. This is useful
    /// for Postgres, where users cannot be deleted from the API if they have been granted SQL roles.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The host the user can connect from. This is only supported
    /// for BUILT_IN users in MySQL instances. Don&apos;t set this field for PostgreSQL and SQL Server instances.
    /// Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this
    /// forces a new resource to be created.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    [JsonPropertyName("passwordPolicy")]
    public V1beta1UserStatusAtProviderPasswordPolicy? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres
    /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
    /// or CLOUD_IAM_SERVICE_ACCOUNT. Don&apos;t set this field for CLOUD_IAM_USER
    /// and CLOUD_IAM_SERVICE_ACCOUNT user types for any Cloud SQL instance.
    /// Note: This property is write-only and will not be read from the API.
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>The version of the password_wo. For more info see updating write-only attributes.</summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    [JsonPropertyName("sqlServerUserDetails")]
    public IList<V1beta1UserStatusAtProviderSqlServerUserDetails>? SqlServerUserDetails { get; set; }

    /// <summary>
    /// The user type. It determines the method to authenticate the
    /// user during login. The default is the database&apos;s built-in user type. Flags
    /// include &quot;BUILT_IN&quot;, &quot;CLOUD_IAM_USER&quot;, &quot;CLOUD_IAM_SERVICE_ACCOUNT&quot;, &quot;CLOUD_IAM_GROUP&quot;,
    /// &quot;CLOUD_IAM_GROUP_USER&quot; and &quot;CLOUD_IAM_GROUP_SERVICE_ACCOUNT&quot; for
    /// Postgres
    /// and MySQL.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatusConditions
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

/// <summary>UserStatus defines the observed state of User.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1UserStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1UserStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>User is the Schema for the Users API. Creates a new SQL user in Google Cloud SQL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1User : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserSpec>, IStatus<V1beta1UserStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "User";
    public const string KubeGroup = "sql.gcp.m.upbound.io";
    public const string KubePluralName = "users";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "User";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserSpec defines the desired state of User</summary>
    [JsonPropertyName("spec")]
    public required V1beta1UserSpec Spec { get; set; }

    /// <summary>UserStatus defines the observed state of User.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserStatus? Status { get; set; }
}