#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appstream.aws.upbound.io;
/// <summary>DirectoryConfig is the Schema for the DirectoryConfigs API. Provides an AppStream Directory Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DirectoryConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DirectoryConfig>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DirectoryConfigList";
    public const string KubeGroup = "appstream.aws.upbound.io";
    public const string KubePluralName = "directoryconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appstream.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DirectoryConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DirectoryConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DirectoryConfig> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DirectoryConfigSpecDeletionPolicyEnum>))]
public enum V1beta2DirectoryConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block for the certificate-based authentication properties used to authenticate SAML 2.0 Identity Provider (IdP) user identities to Active Directory domain-joined streaming instances. See certificate_based_auth_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecForProviderCertificateBasedAuthProperties
{
    /// <summary>The ARN of the AWS Certificate Manager Private CA resource.</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>The status of the certificate-based authentication properties. Valid values - [&quot;DISABLED&quot;, &quot;ENABLED&quot;, &quot;ENABLED_NO_DIRECTORY_LOGIN_FALLBACK&quot;].</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Password for the account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecForProviderServiceAccountCredentialsAccountPasswordSecretRef
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

/// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the directory config to a Microsoft Active Directory domain. See service_account_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecForProviderServiceAccountCredentials
{
    /// <summary>User name of the account. This account must have the following privileges: create computer objects, join computers to the domain, and change/reset the password on descendant computer objects for the organizational units specified.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Password for the account.</summary>
    [JsonPropertyName("accountPasswordSecretRef")]
    public V1beta2DirectoryConfigSpecForProviderServiceAccountCredentialsAccountPasswordSecretRef? AccountPasswordSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecForProvider
{
    /// <summary>Configuration block for the certificate-based authentication properties used to authenticate SAML 2.0 Identity Provider (IdP) user identities to Active Directory domain-joined streaming instances. See certificate_based_auth_properties below.</summary>
    [JsonPropertyName("certificateBasedAuthProperties")]
    public V1beta2DirectoryConfigSpecForProviderCertificateBasedAuthProperties? CertificateBasedAuthProperties { get; set; }

    /// <summary>Fully qualified name of the directory.</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>Distinguished names of the organizational units for computer accounts.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedNames")]
    public IList<string>? OrganizationalUnitDistinguishedNames { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the directory config to a Microsoft Active Directory domain. See service_account_credentials below.</summary>
    [JsonPropertyName("serviceAccountCredentials")]
    public V1beta2DirectoryConfigSpecForProviderServiceAccountCredentials? ServiceAccountCredentials { get; set; }
}

/// <summary>Configuration block for the certificate-based authentication properties used to authenticate SAML 2.0 Identity Provider (IdP) user identities to Active Directory domain-joined streaming instances. See certificate_based_auth_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecInitProviderCertificateBasedAuthProperties
{
    /// <summary>The ARN of the AWS Certificate Manager Private CA resource.</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>The status of the certificate-based authentication properties. Valid values - [&quot;DISABLED&quot;, &quot;ENABLED&quot;, &quot;ENABLED_NO_DIRECTORY_LOGIN_FALLBACK&quot;].</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Password for the account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecInitProviderServiceAccountCredentialsAccountPasswordSecretRef
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

/// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the directory config to a Microsoft Active Directory domain. See service_account_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecInitProviderServiceAccountCredentials
{
    /// <summary>User name of the account. This account must have the following privileges: create computer objects, join computers to the domain, and change/reset the password on descendant computer objects for the organizational units specified.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Password for the account.</summary>
    [JsonPropertyName("accountPasswordSecretRef")]
    public required V1beta2DirectoryConfigSpecInitProviderServiceAccountCredentialsAccountPasswordSecretRef AccountPasswordSecretRef { get; set; }
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
public partial class V1beta2DirectoryConfigSpecInitProvider
{
    /// <summary>Configuration block for the certificate-based authentication properties used to authenticate SAML 2.0 Identity Provider (IdP) user identities to Active Directory domain-joined streaming instances. See certificate_based_auth_properties below.</summary>
    [JsonPropertyName("certificateBasedAuthProperties")]
    public V1beta2DirectoryConfigSpecInitProviderCertificateBasedAuthProperties? CertificateBasedAuthProperties { get; set; }

    /// <summary>Fully qualified name of the directory.</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>Distinguished names of the organizational units for computer accounts.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedNames")]
    public IList<string>? OrganizationalUnitDistinguishedNames { get; set; }

    /// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the directory config to a Microsoft Active Directory domain. See service_account_credentials below.</summary>
    [JsonPropertyName("serviceAccountCredentials")]
    public V1beta2DirectoryConfigSpecInitProviderServiceAccountCredentials? ServiceAccountCredentials { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DirectoryConfigSpecManagementPoliciesEnum>))]
public enum V1beta2DirectoryConfigSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DirectoryConfigSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DirectoryConfigSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DirectoryConfigSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DirectoryConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DirectoryConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DirectoryConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DirectoryConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DirectoryConfigSpec defines the desired state of DirectoryConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigSpec
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
    public V1beta2DirectoryConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DirectoryConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta2DirectoryConfigSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DirectoryConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DirectoryConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DirectoryConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for the certificate-based authentication properties used to authenticate SAML 2.0 Identity Provider (IdP) user identities to Active Directory domain-joined streaming instances. See certificate_based_auth_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigStatusAtProviderCertificateBasedAuthProperties
{
    /// <summary>The ARN of the AWS Certificate Manager Private CA resource.</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>The status of the certificate-based authentication properties. Valid values - [&quot;DISABLED&quot;, &quot;ENABLED&quot;, &quot;ENABLED_NO_DIRECTORY_LOGIN_FALLBACK&quot;].</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the directory config to a Microsoft Active Directory domain. See service_account_credentials below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigStatusAtProviderServiceAccountCredentials
{
    /// <summary>User name of the account. This account must have the following privileges: create computer objects, join computers to the domain, and change/reset the password on descendant computer objects for the organizational units specified.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigStatusAtProvider
{
    /// <summary>Configuration block for the certificate-based authentication properties used to authenticate SAML 2.0 Identity Provider (IdP) user identities to Active Directory domain-joined streaming instances. See certificate_based_auth_properties below.</summary>
    [JsonPropertyName("certificateBasedAuthProperties")]
    public V1beta2DirectoryConfigStatusAtProviderCertificateBasedAuthProperties? CertificateBasedAuthProperties { get; set; }

    /// <summary>Date and time, in UTC and extended RFC 3339 format, when the directory config was created.</summary>
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    /// <summary>Fully qualified name of the directory.</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>Unique identifier (ID) of the appstream directory config.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Distinguished names of the organizational units for computer accounts.</summary>
    [JsonPropertyName("organizationalUnitDistinguishedNames")]
    public IList<string>? OrganizationalUnitDistinguishedNames { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for the name of the directory and organizational unit (OU) to use to join the directory config to a Microsoft Active Directory domain. See service_account_credentials below.</summary>
    [JsonPropertyName("serviceAccountCredentials")]
    public V1beta2DirectoryConfigStatusAtProviderServiceAccountCredentials? ServiceAccountCredentials { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigStatusConditions
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

/// <summary>DirectoryConfigStatus defines the observed state of DirectoryConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DirectoryConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DirectoryConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DirectoryConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DirectoryConfig is the Schema for the DirectoryConfigs API. Provides an AppStream Directory Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DirectoryConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DirectoryConfigSpec>, IStatus<V1beta2DirectoryConfigStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DirectoryConfig";
    public const string KubeGroup = "appstream.aws.upbound.io";
    public const string KubePluralName = "directoryconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appstream.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DirectoryConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DirectoryConfigSpec defines the desired state of DirectoryConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DirectoryConfigSpec Spec { get; set; }

    /// <summary>DirectoryConfigStatus defines the observed state of DirectoryConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta2DirectoryConfigStatus? Status { get; set; }
}