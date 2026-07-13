#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>DatabaseRole is the Schema for the databaseroles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1DatabaseRoleList : IKubernetesObject<V1ListMeta>, IItems<V1DatabaseRole>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "DatabaseRoleList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "databaseroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1DatabaseRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1DatabaseRole> Items { get; set; }
}

/// <summary>
/// ClientCertificate configures the operator to generate and renew a TLS client
/// certificate for this role, signed by the cluster&apos;s client CA. The certificate
/// is stored in a Secret named `&lt;databaserole-name&gt;-client-cert`.
/// Requires login to be true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleSpecClientCertificate
{
    /// <summary>
    /// Enabled turns on client certificate issuance for this role. When true,
    /// the role must have login enabled. Defaults to true when the block is present.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The corresponding cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleSpecCluster
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The policy for end-of-life maintenance of this role</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseRoleSpecDatabaseRoleReclaimPolicyEnum>))]
public enum V1DatabaseRoleSpecDatabaseRoleReclaimPolicyEnum
{
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "retain"), JsonStringEnumMemberName("retain")]
    Retain
}

/// <summary>Ensure the role is `present` or `absent` - defaults to &quot;present&quot;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseRoleSpecEnsureEnum>))]
public enum V1DatabaseRoleSpecEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>
/// Secret containing the password of the role (if present).
/// If null, the password will be ignored unless DisablePassword is set.
/// When set, the secret must follow the `kubernetes.io/basic-auth` format
/// and contain both a `username` and a `password` field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleSpecPasswordSecret
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Specification of the desired DatabaseRole.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleSpec
{
    /// <summary>
    /// Whether a role bypasses every row-level security (RLS) policy.
    /// Default is `false`.
    /// </summary>
    [JsonPropertyName("bypassrls")]
    public bool? Bypassrls { get; set; }

    /// <summary>
    /// ClientCertificate configures the operator to generate and renew a TLS client
    /// certificate for this role, signed by the cluster&apos;s client CA. The certificate
    /// is stored in a Secret named `&lt;databaserole-name&gt;-client-cert`.
    /// Requires login to be true.
    /// </summary>
    [JsonPropertyName("clientCertificate")]
    public V1DatabaseRoleSpecClientCertificate? ClientCertificate { get; set; }

    /// <summary>The corresponding cluster</summary>
    [JsonPropertyName("cluster")]
    public required V1DatabaseRoleSpecCluster Cluster { get; set; }

    /// <summary>Description of the role</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// If the role can log in, this specifies how many concurrent
    /// connections the role can make. `-1` (the default) means no limit.
    /// </summary>
    [JsonPropertyName("connectionLimit")]
    public long? ConnectionLimit { get; set; }

    /// <summary>
    /// When set to `true`, the role being defined will be allowed to create
    /// new databases. Specifying `false` (default) will deny a role the
    /// ability to create databases.
    /// </summary>
    [JsonPropertyName("createdb")]
    public bool? Createdb { get; set; }

    /// <summary>
    /// Whether the role will be permitted to create, alter, drop, comment
    /// on, change the security label for, and grant or revoke membership in
    /// other roles. Default is `false`.
    /// </summary>
    [JsonPropertyName("createrole")]
    public bool? Createrole { get; set; }

    /// <summary>The policy for end-of-life maintenance of this role</summary>
    [JsonPropertyName("databaseRoleReclaimPolicy")]
    public V1DatabaseRoleSpecDatabaseRoleReclaimPolicyEnum? DatabaseRoleReclaimPolicy { get; set; }

    /// <summary>DisablePassword indicates that a role&apos;s password should be set to NULL in Postgres</summary>
    [JsonPropertyName("disablePassword")]
    public bool? DisablePassword { get; set; }

    /// <summary>Ensure the role is `present` or `absent` - defaults to &quot;present&quot;</summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseRoleSpecEnsureEnum? Ensure { get; set; }

    /// <summary>
    /// List of one or more existing roles to which this role will be
    /// immediately added as a new member. Default empty.
    /// Changes to the list are applied to an existing role through
    /// `GRANT` and `REVOKE` statements, not only at role creation.
    /// </summary>
    [JsonPropertyName("inRoles")]
    public IList<string>? InRoles { get; set; }

    /// <summary>
    /// Whether a role &quot;inherits&quot; the privileges of roles it is a member of.
    /// Default is `true`.
    /// </summary>
    [JsonPropertyName("inherit")]
    public bool? Inherit { get; set; }

    /// <summary>
    /// Whether the role is allowed to log in. A role having the `login`
    /// attribute can be thought of as a user. Roles without this attribute
    /// are useful for managing database privileges, but are not users in
    /// the usual sense of the word. Default is `false`.
    /// </summary>
    [JsonPropertyName("login")]
    public bool? Login { get; set; }

    /// <summary>Name of the role</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Secret containing the password of the role (if present).
    /// If null, the password will be ignored unless DisablePassword is set.
    /// When set, the secret must follow the `kubernetes.io/basic-auth` format
    /// and contain both a `username` and a `password` field.
    /// </summary>
    [JsonPropertyName("passwordSecret")]
    public V1DatabaseRoleSpecPasswordSecret? PasswordSecret { get; set; }

    /// <summary>
    /// Whether a role is a replication role. A role must have this
    /// attribute (or be a superuser) in order to be able to connect to the
    /// server in replication mode (physical or logical replication) and in
    /// order to be able to create or drop replication slots. A role having
    /// the `replication` attribute is a very highly privileged role, and
    /// should only be used on roles actually used for replication. Default
    /// is `false`.
    /// </summary>
    [JsonPropertyName("replication")]
    public bool? Replication { get; set; }

    /// <summary>
    /// Whether the role is a `superuser` who can override all access
    /// restrictions within the database - superuser status is dangerous and
    /// should be used only when really needed. You must yourself be a
    /// superuser to create a new superuser. Defaults is `false`.
    /// </summary>
    [JsonPropertyName("superuser")]
    public bool? Superuser { get; set; }

    /// <summary>
    /// Date and time after which the role&apos;s password is no longer valid.
    /// When omitted, the password will never expire (default).
    /// </summary>
    [JsonPropertyName("validUntil")]
    public DateTime? ValidUntil { get; set; }
}

/// <summary>
/// ClientCertificate holds the observed state of the generated TLS client
/// certificate, when client certificate issuance is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleStatusClientCertificate
{
    /// <summary>Expiration is the expiration time of the generated client certificate, in RFC3339 format.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>
    /// Message contains a human-readable explanation of the current certificate status,
    /// such as why issuance was skipped or why an existing Secret was left untouched.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseRoleStatusConditionsStatusEnum>))]
public enum V1DatabaseRoleStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1DatabaseRoleStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Most recently observed status of the DatabaseRole. This data may not be up
/// to date. Populated by the system. Read-only.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseRoleStatus
{
    /// <summary>Applied is true if the role was reconciled correctly</summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }

    /// <summary>
    /// ClientCertificate holds the observed state of the generated TLS client
    /// certificate, when client certificate issuance is enabled.
    /// </summary>
    [JsonPropertyName("clientCertificate")]
    public V1DatabaseRoleStatusClientCertificate? ClientCertificate { get; set; }

    /// <summary>Conditions for the DatabaseRole object</summary>
    [JsonPropertyName("conditions")]
    public IList<V1DatabaseRoleStatusConditions>? Conditions { get; set; }

    /// <summary>Message is the reconciliation error message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// A sequence number representing the latest
    /// desired state that was synchronized
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// SecretResourceVersion is the resource version of the password secret
    /// last applied to the role; a change to it triggers reconciliation.
    /// </summary>
    [JsonPropertyName("secretResourceVersion")]
    public string? SecretResourceVersion { get; set; }
}

/// <summary>DatabaseRole is the Schema for the databaseroles API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1DatabaseRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1DatabaseRoleSpec>, IStatus<V1DatabaseRoleStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "DatabaseRole";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "databaseroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired DatabaseRole.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1DatabaseRoleSpec Spec { get; set; }

    /// <summary>
    /// Most recently observed status of the DatabaseRole. This data may not be up
    /// to date. Populated by the system. Read-only.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("status")]
    public V1DatabaseRoleStatus? Status { get; set; }
}