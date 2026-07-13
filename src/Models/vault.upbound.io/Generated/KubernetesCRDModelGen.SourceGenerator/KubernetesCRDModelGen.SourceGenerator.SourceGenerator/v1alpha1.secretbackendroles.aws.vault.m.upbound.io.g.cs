#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aws.vault.m.upbound.io;
/// <summary>SecretBackendRole is the Schema for the SecretBackendRoles API. Creates a role on an AWS Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRoleList";
    public const string KubeGroup = "aws.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aws.vault.m.upbound.io/v1alpha1";

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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Reference to a SecretBackend in aws to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Selector for a SecretBackend in aws to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProvider
{
    /// <summary>
    /// The path the AWS secret backend is mounted at,
    /// with no leading or trailing /s.
    /// The path of the AWS Secret Backend the role belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a SecretBackend in aws to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a SecretBackend in aws to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Specifies the type of credential to be used when
    /// retrieving credentials from the role. Must be one of iam_user, assumed_role, or
    /// federation_token.
    /// Role credential type.
    /// </summary>
    [JsonPropertyName("credentialType")]
    public string? CredentialType { get; set; }

    /// <summary>
    /// The default TTL in seconds for STS credentials.
    /// When a TTL is not specified when STS credentials are requested,
    /// and a default TTL is specified on the role,
    /// then this default TTL will be used. Valid only when credential_type is one of
    /// assumed_role or federation_token.
    /// The default TTL in seconds for STS credentials. When a TTL is not specified when STS credentials are requested, and a default TTL is specified on the role, then this default TTL will be used. Valid only when credential_type is one of assumed_role or federation_token.
    /// </summary>
    [JsonPropertyName("defaultStsTtl")]
    public double? DefaultStsTtl { get; set; }

    /// <summary>
    /// External ID to set for assume role creds.
    /// Valid only when credential_type is set to assumed_role.
    /// External ID to set for assume role creds.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// A list of IAM group names. IAM users generated
    /// against this vault role will be added to these IAM Groups. For a credential
    /// type of assumed_role or federation_token, the policies sent to the
    /// corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the
    /// policies from each group in iam_groups combined with the policy_document
    /// and policy_arns parameters.
    /// A list of IAM group names. IAM users generated against this vault role will be added to these IAM Groups. For a credential type of assumed_role or federation_token, the policies sent to the corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the policies from each group in iam_groups combined with the policy_document and policy_arns parameters.
    /// </summary>
    [JsonPropertyName("iamGroups")]
    public IList<string>? IamGroups { get; set; }

    /// <summary>
    /// A map of strings representing key/value pairs
    /// to be used as tags for any IAM user that is created by this role.
    /// A map of strings representing key/value pairs used as tags for any IAM user created by this role.
    /// </summary>
    [JsonPropertyName("iamTags")]
    public IDictionary<string, string>? IamTags { get; set; }

    /// <summary>
    /// The max allowed TTL in seconds for STS credentials
    /// (credentials TTL are capped to max_sts_ttl). Valid only when credential_type is
    /// one of assumed_role or federation_token.
    /// The max allowed TTL in seconds for STS credentials (credentials TTL are capped to max_sts_ttl). Valid only when credential_type is one of assumed_role or federation_token.
    /// </summary>
    [JsonPropertyName("maxStsTtl")]
    public double? MaxStsTtl { get; set; }

    /// <summary>
    /// The ARN or hardware device number of the device configured to the IAM user for multi-factor authentication. Only required if the IAM user has an MFA device set up in AWS.
    /// The ARN or hardware device number of the device configured to the IAM user for multi-factor authentication. Only required if the IAM user has an MFA device set up in AWS.
    /// </summary>
    [JsonPropertyName("mfaSerialNumber")]
    public string? MfaSerialNumber { get; set; }

    /// <summary>
    /// The name to identify this role within the backend.
    /// Must be unique within the backend.
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
    /// The ARN of the AWS Permissions
    /// Boundary to attach to IAM users created in the role. Valid only when
    /// credential_type is iam_user. If not specified, then no permissions boundary
    /// policy will be attached.
    /// The ARN of the AWS Permissions Boundary to attach to IAM users created in the role. Valid only when credential_type is iam_user. If not specified, then no permissions boundary policy will be attached.
    /// </summary>
    [JsonPropertyName("permissionsBoundaryArn")]
    public string? PermissionsBoundaryArn { get; set; }

    /// <summary>
    /// Specifies a list of AWS managed policy ARNs. The
    /// behavior depends on the credential type. With iam_user, the policies will be
    /// attached to IAM users when they are requested. With assumed_role and
    /// federation_token, the policy ARNs will act as a filter on what the credentials
    /// can do, similar to policy_document. When credential_type is iam_user or
    /// federation_token, at least one of policy_document or policy_arns must
    /// be specified.
    /// ARN for an existing IAM policy the role should use.
    /// </summary>
    [JsonPropertyName("policyArns")]
    public IList<string>? PolicyArns { get; set; }

    /// <summary>
    /// The IAM policy document for the role. The
    /// behavior depends on the credential type. With iam_user, the policy document
    /// will be attached to the IAM user generated and augment the permissions the IAM
    /// user has. With assumed_role and federation_token, the policy document will
    /// act as a filter on what the credentials can do, similar to policy_arns.
    /// IAM policy the role should use in JSON format.
    /// </summary>
    [JsonPropertyName("policyDocument")]
    public string? PolicyDocument { get; set; }

    /// <summary>
    /// Specifies the ARNs of the AWS roles this Vault role
    /// is allowed to assume. Required when credential_type is assumed_role and
    /// prohibited otherwise.
    /// ARNs of AWS roles allowed to be assumed. Only valid when credential_type is &apos;assumed_role&apos;
    /// </summary>
    [JsonPropertyName("roleArns")]
    public IList<string>? RoleArns { get; set; }

    /// <summary>
    /// A map of strings representing key/value pairs to be set
    /// during assume role creds creation. Valid only when credential_type is set to
    /// assumed_role.
    /// Session tags to be set for assume role creds created.
    /// </summary>
    [JsonPropertyName("sessionTags")]
    public IDictionary<string, string>? SessionTags { get; set; }

    /// <summary>
    /// The path for the user name. Valid only when
    /// credential_type is iam_user. Default is /.
    /// The path for the user name. Valid only when credential_type is iam_user. Default is /
    /// </summary>
    [JsonPropertyName("userPath")]
    public string? UserPath { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Reference to a SecretBackend in aws to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Selector for a SecretBackend in aws to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProvider
{
    /// <summary>
    /// The path the AWS secret backend is mounted at,
    /// with no leading or trailing /s.
    /// The path of the AWS Secret Backend the role belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a SecretBackend in aws to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a SecretBackend in aws to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Specifies the type of credential to be used when
    /// retrieving credentials from the role. Must be one of iam_user, assumed_role, or
    /// federation_token.
    /// Role credential type.
    /// </summary>
    [JsonPropertyName("credentialType")]
    public string? CredentialType { get; set; }

    /// <summary>
    /// The default TTL in seconds for STS credentials.
    /// When a TTL is not specified when STS credentials are requested,
    /// and a default TTL is specified on the role,
    /// then this default TTL will be used. Valid only when credential_type is one of
    /// assumed_role or federation_token.
    /// The default TTL in seconds for STS credentials. When a TTL is not specified when STS credentials are requested, and a default TTL is specified on the role, then this default TTL will be used. Valid only when credential_type is one of assumed_role or federation_token.
    /// </summary>
    [JsonPropertyName("defaultStsTtl")]
    public double? DefaultStsTtl { get; set; }

    /// <summary>
    /// External ID to set for assume role creds.
    /// Valid only when credential_type is set to assumed_role.
    /// External ID to set for assume role creds.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// A list of IAM group names. IAM users generated
    /// against this vault role will be added to these IAM Groups. For a credential
    /// type of assumed_role or federation_token, the policies sent to the
    /// corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the
    /// policies from each group in iam_groups combined with the policy_document
    /// and policy_arns parameters.
    /// A list of IAM group names. IAM users generated against this vault role will be added to these IAM Groups. For a credential type of assumed_role or federation_token, the policies sent to the corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the policies from each group in iam_groups combined with the policy_document and policy_arns parameters.
    /// </summary>
    [JsonPropertyName("iamGroups")]
    public IList<string>? IamGroups { get; set; }

    /// <summary>
    /// A map of strings representing key/value pairs
    /// to be used as tags for any IAM user that is created by this role.
    /// A map of strings representing key/value pairs used as tags for any IAM user created by this role.
    /// </summary>
    [JsonPropertyName("iamTags")]
    public IDictionary<string, string>? IamTags { get; set; }

    /// <summary>
    /// The max allowed TTL in seconds for STS credentials
    /// (credentials TTL are capped to max_sts_ttl). Valid only when credential_type is
    /// one of assumed_role or federation_token.
    /// The max allowed TTL in seconds for STS credentials (credentials TTL are capped to max_sts_ttl). Valid only when credential_type is one of assumed_role or federation_token.
    /// </summary>
    [JsonPropertyName("maxStsTtl")]
    public double? MaxStsTtl { get; set; }

    /// <summary>
    /// The ARN or hardware device number of the device configured to the IAM user for multi-factor authentication. Only required if the IAM user has an MFA device set up in AWS.
    /// The ARN or hardware device number of the device configured to the IAM user for multi-factor authentication. Only required if the IAM user has an MFA device set up in AWS.
    /// </summary>
    [JsonPropertyName("mfaSerialNumber")]
    public string? MfaSerialNumber { get; set; }

    /// <summary>
    /// The name to identify this role within the backend.
    /// Must be unique within the backend.
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
    /// The ARN of the AWS Permissions
    /// Boundary to attach to IAM users created in the role. Valid only when
    /// credential_type is iam_user. If not specified, then no permissions boundary
    /// policy will be attached.
    /// The ARN of the AWS Permissions Boundary to attach to IAM users created in the role. Valid only when credential_type is iam_user. If not specified, then no permissions boundary policy will be attached.
    /// </summary>
    [JsonPropertyName("permissionsBoundaryArn")]
    public string? PermissionsBoundaryArn { get; set; }

    /// <summary>
    /// Specifies a list of AWS managed policy ARNs. The
    /// behavior depends on the credential type. With iam_user, the policies will be
    /// attached to IAM users when they are requested. With assumed_role and
    /// federation_token, the policy ARNs will act as a filter on what the credentials
    /// can do, similar to policy_document. When credential_type is iam_user or
    /// federation_token, at least one of policy_document or policy_arns must
    /// be specified.
    /// ARN for an existing IAM policy the role should use.
    /// </summary>
    [JsonPropertyName("policyArns")]
    public IList<string>? PolicyArns { get; set; }

    /// <summary>
    /// The IAM policy document for the role. The
    /// behavior depends on the credential type. With iam_user, the policy document
    /// will be attached to the IAM user generated and augment the permissions the IAM
    /// user has. With assumed_role and federation_token, the policy document will
    /// act as a filter on what the credentials can do, similar to policy_arns.
    /// IAM policy the role should use in JSON format.
    /// </summary>
    [JsonPropertyName("policyDocument")]
    public string? PolicyDocument { get; set; }

    /// <summary>
    /// Specifies the ARNs of the AWS roles this Vault role
    /// is allowed to assume. Required when credential_type is assumed_role and
    /// prohibited otherwise.
    /// ARNs of AWS roles allowed to be assumed. Only valid when credential_type is &apos;assumed_role&apos;
    /// </summary>
    [JsonPropertyName("roleArns")]
    public IList<string>? RoleArns { get; set; }

    /// <summary>
    /// A map of strings representing key/value pairs to be set
    /// during assume role creds creation. Valid only when credential_type is set to
    /// assumed_role.
    /// Session tags to be set for assume role creds created.
    /// </summary>
    [JsonPropertyName("sessionTags")]
    public IDictionary<string, string>? SessionTags { get; set; }

    /// <summary>
    /// The path for the user name. Valid only when
    /// credential_type is iam_user. Default is /.
    /// The path for the user name. Valid only when credential_type is iam_user. Default is /
    /// </summary>
    [JsonPropertyName("userPath")]
    public string? UserPath { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecProviderConfigRef
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
public partial class V1alpha1SecretBackendRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretBackendRoleSpec defines the desired state of SecretBackendRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpec
{
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusAtProvider
{
    /// <summary>
    /// The path the AWS secret backend is mounted at,
    /// with no leading or trailing /s.
    /// The path of the AWS Secret Backend the role belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Specifies the type of credential to be used when
    /// retrieving credentials from the role. Must be one of iam_user, assumed_role, or
    /// federation_token.
    /// Role credential type.
    /// </summary>
    [JsonPropertyName("credentialType")]
    public string? CredentialType { get; set; }

    /// <summary>
    /// The default TTL in seconds for STS credentials.
    /// When a TTL is not specified when STS credentials are requested,
    /// and a default TTL is specified on the role,
    /// then this default TTL will be used. Valid only when credential_type is one of
    /// assumed_role or federation_token.
    /// The default TTL in seconds for STS credentials. When a TTL is not specified when STS credentials are requested, and a default TTL is specified on the role, then this default TTL will be used. Valid only when credential_type is one of assumed_role or federation_token.
    /// </summary>
    [JsonPropertyName("defaultStsTtl")]
    public double? DefaultStsTtl { get; set; }

    /// <summary>
    /// External ID to set for assume role creds.
    /// Valid only when credential_type is set to assumed_role.
    /// External ID to set for assume role creds.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// A list of IAM group names. IAM users generated
    /// against this vault role will be added to these IAM Groups. For a credential
    /// type of assumed_role or federation_token, the policies sent to the
    /// corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the
    /// policies from each group in iam_groups combined with the policy_document
    /// and policy_arns parameters.
    /// A list of IAM group names. IAM users generated against this vault role will be added to these IAM Groups. For a credential type of assumed_role or federation_token, the policies sent to the corresponding AWS call (sts:AssumeRole or sts:GetFederation) will be the policies from each group in iam_groups combined with the policy_document and policy_arns parameters.
    /// </summary>
    [JsonPropertyName("iamGroups")]
    public IList<string>? IamGroups { get; set; }

    /// <summary>
    /// A map of strings representing key/value pairs
    /// to be used as tags for any IAM user that is created by this role.
    /// A map of strings representing key/value pairs used as tags for any IAM user created by this role.
    /// </summary>
    [JsonPropertyName("iamTags")]
    public IDictionary<string, string>? IamTags { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The max allowed TTL in seconds for STS credentials
    /// (credentials TTL are capped to max_sts_ttl). Valid only when credential_type is
    /// one of assumed_role or federation_token.
    /// The max allowed TTL in seconds for STS credentials (credentials TTL are capped to max_sts_ttl). Valid only when credential_type is one of assumed_role or federation_token.
    /// </summary>
    [JsonPropertyName("maxStsTtl")]
    public double? MaxStsTtl { get; set; }

    /// <summary>
    /// The ARN or hardware device number of the device configured to the IAM user for multi-factor authentication. Only required if the IAM user has an MFA device set up in AWS.
    /// The ARN or hardware device number of the device configured to the IAM user for multi-factor authentication. Only required if the IAM user has an MFA device set up in AWS.
    /// </summary>
    [JsonPropertyName("mfaSerialNumber")]
    public string? MfaSerialNumber { get; set; }

    /// <summary>
    /// The name to identify this role within the backend.
    /// Must be unique within the backend.
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
    /// The ARN of the AWS Permissions
    /// Boundary to attach to IAM users created in the role. Valid only when
    /// credential_type is iam_user. If not specified, then no permissions boundary
    /// policy will be attached.
    /// The ARN of the AWS Permissions Boundary to attach to IAM users created in the role. Valid only when credential_type is iam_user. If not specified, then no permissions boundary policy will be attached.
    /// </summary>
    [JsonPropertyName("permissionsBoundaryArn")]
    public string? PermissionsBoundaryArn { get; set; }

    /// <summary>
    /// Specifies a list of AWS managed policy ARNs. The
    /// behavior depends on the credential type. With iam_user, the policies will be
    /// attached to IAM users when they are requested. With assumed_role and
    /// federation_token, the policy ARNs will act as a filter on what the credentials
    /// can do, similar to policy_document. When credential_type is iam_user or
    /// federation_token, at least one of policy_document or policy_arns must
    /// be specified.
    /// ARN for an existing IAM policy the role should use.
    /// </summary>
    [JsonPropertyName("policyArns")]
    public IList<string>? PolicyArns { get; set; }

    /// <summary>
    /// The IAM policy document for the role. The
    /// behavior depends on the credential type. With iam_user, the policy document
    /// will be attached to the IAM user generated and augment the permissions the IAM
    /// user has. With assumed_role and federation_token, the policy document will
    /// act as a filter on what the credentials can do, similar to policy_arns.
    /// IAM policy the role should use in JSON format.
    /// </summary>
    [JsonPropertyName("policyDocument")]
    public string? PolicyDocument { get; set; }

    /// <summary>
    /// Specifies the ARNs of the AWS roles this Vault role
    /// is allowed to assume. Required when credential_type is assumed_role and
    /// prohibited otherwise.
    /// ARNs of AWS roles allowed to be assumed. Only valid when credential_type is &apos;assumed_role&apos;
    /// </summary>
    [JsonPropertyName("roleArns")]
    public IList<string>? RoleArns { get; set; }

    /// <summary>
    /// A map of strings representing key/value pairs to be set
    /// during assume role creds creation. Valid only when credential_type is set to
    /// assumed_role.
    /// Session tags to be set for assume role creds created.
    /// </summary>
    [JsonPropertyName("sessionTags")]
    public IDictionary<string, string>? SessionTags { get; set; }

    /// <summary>
    /// The path for the user name. Valid only when
    /// credential_type is iam_user. Default is /.
    /// The path for the user name. Valid only when credential_type is iam_user. Default is /
    /// </summary>
    [JsonPropertyName("userPath")]
    public string? UserPath { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>SecretBackendRole is the Schema for the SecretBackendRoles API. Creates a role on an AWS Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendRoleSpec>, IStatus<V1alpha1SecretBackendRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRole";
    public const string KubeGroup = "aws.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aws.vault.m.upbound.io/v1alpha1";

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