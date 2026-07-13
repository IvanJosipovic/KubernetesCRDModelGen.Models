#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identity.vault.m.upbound.io;
/// <summary>MfaTotp is the Schema for the MfaTotps API. Resource for configuring the totp MFA method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MfaTotpList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MfaTotp>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MfaTotpList";
    public const string KubeGroup = "identity.vault.m.upbound.io";
    public const string KubePluralName = "mfatotps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identity.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MfaTotpList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MfaTotp objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MfaTotp> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MfaTotpSpecForProvider
{
    /// <summary>
    /// Specifies the hashing algorithm used to generate the TOTP code. Options include SHA1, SHA256, SHA512.
    /// Specifies the hashing algorithm used to generate the TOTP code. Options include SHA1, SHA256, SHA512.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>
    /// The number of digits in the generated TOTP token. This value can either be 6 or 8
    /// The number of digits in the generated TOTP token. This value can either be 6 or 8
    /// </summary>
    [JsonPropertyName("digits")]
    public double? Digits { get; set; }

    /// <summary>
    /// The name of the key&apos;s issuing organization.
    /// The name of the key&apos;s issuing organization.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// Specifies the size in bytes of the generated key.
    /// Specifies the size in bytes of the generated key.
    /// </summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>
    /// The maximum number of consecutive failed validation attempts allowed.
    /// The maximum number of consecutive failed validation attempts allowed.
    /// </summary>
    [JsonPropertyName("maxValidationAttempts")]
    public double? MaxValidationAttempts { get; set; }

    /// <summary>
    /// Target namespace. (requires Enterprise)
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The length of time in seconds used to generate a counter for the TOTP token calculation.
    /// The length of time in seconds used to generate a counter for the TOTP token calculation.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The pixel size of the generated square QR code.
    /// The pixel size of the generated square QR code.
    /// </summary>
    [JsonPropertyName("qrSize")]
    public double? QrSize { get; set; }

    /// <summary>
    /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
    /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
    /// </summary>
    [JsonPropertyName("skew")]
    public double? Skew { get; set; }
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
public partial class V1alpha1MfaTotpSpecInitProvider
{
    /// <summary>
    /// Specifies the hashing algorithm used to generate the TOTP code. Options include SHA1, SHA256, SHA512.
    /// Specifies the hashing algorithm used to generate the TOTP code. Options include SHA1, SHA256, SHA512.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>
    /// The number of digits in the generated TOTP token. This value can either be 6 or 8
    /// The number of digits in the generated TOTP token. This value can either be 6 or 8
    /// </summary>
    [JsonPropertyName("digits")]
    public double? Digits { get; set; }

    /// <summary>
    /// The name of the key&apos;s issuing organization.
    /// The name of the key&apos;s issuing organization.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// Specifies the size in bytes of the generated key.
    /// Specifies the size in bytes of the generated key.
    /// </summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>
    /// The maximum number of consecutive failed validation attempts allowed.
    /// The maximum number of consecutive failed validation attempts allowed.
    /// </summary>
    [JsonPropertyName("maxValidationAttempts")]
    public double? MaxValidationAttempts { get; set; }

    /// <summary>
    /// Target namespace. (requires Enterprise)
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The length of time in seconds used to generate a counter for the TOTP token calculation.
    /// The length of time in seconds used to generate a counter for the TOTP token calculation.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The pixel size of the generated square QR code.
    /// The pixel size of the generated square QR code.
    /// </summary>
    [JsonPropertyName("qrSize")]
    public double? QrSize { get; set; }

    /// <summary>
    /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
    /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
    /// </summary>
    [JsonPropertyName("skew")]
    public double? Skew { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MfaTotpSpecManagementPoliciesEnum>))]
public enum V1alpha1MfaTotpSpecManagementPoliciesEnum
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
public partial class V1alpha1MfaTotpSpecProviderConfigRef
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
public partial class V1alpha1MfaTotpSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MfaTotpSpec defines the desired state of MfaTotp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MfaTotpSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1MfaTotpSpecForProvider ForProvider { get; set; }

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
    public V1alpha1MfaTotpSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1MfaTotpSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MfaTotpSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MfaTotpSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MfaTotpStatusAtProvider
{
    /// <summary>
    /// Specifies the hashing algorithm used to generate the TOTP code. Options include SHA1, SHA256, SHA512.
    /// Specifies the hashing algorithm used to generate the TOTP code. Options include SHA1, SHA256, SHA512.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>
    /// The number of digits in the generated TOTP token. This value can either be 6 or 8
    /// The number of digits in the generated TOTP token. This value can either be 6 or 8
    /// </summary>
    [JsonPropertyName("digits")]
    public double? Digits { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The name of the key&apos;s issuing organization.
    /// The name of the key&apos;s issuing organization.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// Specifies the size in bytes of the generated key.
    /// Specifies the size in bytes of the generated key.
    /// </summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>
    /// The maximum number of consecutive failed validation attempts allowed.
    /// The maximum number of consecutive failed validation attempts allowed.
    /// </summary>
    [JsonPropertyName("maxValidationAttempts")]
    public double? MaxValidationAttempts { get; set; }

    /// <summary>
    /// Method ID.
    /// Method ID.
    /// </summary>
    [JsonPropertyName("methodId")]
    public string? MethodId { get; set; }

    /// <summary>
    /// Mount accessor.
    /// Mount accessor.
    /// </summary>
    [JsonPropertyName("mountAccessor")]
    public string? MountAccessor { get; set; }

    /// <summary>Method name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Target namespace. (requires Enterprise)
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Method&apos;s namespace ID.
    /// Method&apos;s namespace ID.
    /// </summary>
    [JsonPropertyName("namespaceId")]
    public string? NamespaceId { get; set; }

    /// <summary>
    /// Method&apos;s namespace path.
    /// Method&apos;s namespace path.
    /// </summary>
    [JsonPropertyName("namespacePath")]
    public string? NamespacePath { get; set; }

    /// <summary>
    /// The length of time in seconds used to generate a counter for the TOTP token calculation.
    /// The length of time in seconds used to generate a counter for the TOTP token calculation.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The pixel size of the generated square QR code.
    /// The pixel size of the generated square QR code.
    /// </summary>
    [JsonPropertyName("qrSize")]
    public double? QrSize { get; set; }

    /// <summary>
    /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
    /// The number of delay periods that are allowed when validating a TOTP token. This value can either be 0 or 1.
    /// </summary>
    [JsonPropertyName("skew")]
    public double? Skew { get; set; }

    /// <summary>
    /// MFA type.
    /// MFA type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Resource UUID.
    /// Resource UUID.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MfaTotpStatusConditions
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

/// <summary>MfaTotpStatus defines the observed state of MfaTotp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MfaTotpStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1MfaTotpStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MfaTotpStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MfaTotp is the Schema for the MfaTotps API. Resource for configuring the totp MFA method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MfaTotp : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MfaTotpSpec>, IStatus<V1alpha1MfaTotpStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MfaTotp";
    public const string KubeGroup = "identity.vault.m.upbound.io";
    public const string KubePluralName = "mfatotps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identity.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MfaTotp";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MfaTotpSpec defines the desired state of MfaTotp</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MfaTotpSpec Spec { get; set; }

    /// <summary>MfaTotpStatus defines the observed state of MfaTotp.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MfaTotpStatus? Status { get; set; }
}