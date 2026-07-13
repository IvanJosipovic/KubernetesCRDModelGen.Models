#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pki.vault.upbound.io;
/// <summary>SecretBackendIntermediateCertRequest is the Schema for the SecretBackendIntermediateCertRequests API. Generate a new private key and a CSR for signing the PKI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendIntermediateCertRequestList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendIntermediateCertRequest>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendIntermediateCertRequestList";
    public const string KubeGroup = "pki.vault.upbound.io";
    public const string KubePluralName = "secretbackendintermediatecertrequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendIntermediateCertRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendIntermediateCertRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendIntermediateCertRequest> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecForProvider
{
    /// <summary>
    /// Adds a Basic Constraints extension with &apos;CA: true&apos;.
    /// Only needed as a workaround in some compatibility scenarios with Active Directory
    /// Certificate Services
    /// Set &apos;CA: true&apos; in a Basic Constraints extension. Only needed as
    /// a workaround in some compatibility scenarios with Active Directory Certificate Services.
    /// </summary>
    [JsonPropertyName("addBasicConstraints")]
    public bool? AddBasicConstraints { get; set; }

    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// CN of intermediate to create
    /// CN of intermediate to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// The country
    /// The country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// The format of data
    /// The format of data.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// List of alternative IPs
    /// List of alternative IPs.
    /// </summary>
    [JsonPropertyName("ipSans")]
    public IList<string>? IpSans { get; set; }

    /// <summary>
    /// The number of bits to use
    /// The number of bits to use.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// When a new key is created with this request, optionally specifies
    /// the name for this. The global ref default may not be used as a name.
    /// When a new key is created with this request, optionally specifies the name for this.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// Specifies the key (either default, by name, or by identifier) to use
    /// for generating this request. Only suitable for type=existing requests.
    /// Specifies the key to use for generating this request.
    /// </summary>
    [JsonPropertyName("keyRef")]
    public string? KeyRef { get; set; }

    /// <summary>
    /// The desired key type
    /// The desired key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specifies key_usage to encode in the generated certificate.
    /// Specify the key usages to encode in the generated certificate.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality
    /// The locality.
    /// </summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>
    /// The ID of the previously configured managed key. This field is
    /// required if type is kms and it conflicts with managed_key_name
    /// The ID of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the previously configured managed key. This field is
    /// required if type is kms  and it conflicts with managed_key_id
    /// The name of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

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
    /// The organization
    /// The organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The organization unit
    /// The organization unit.
    /// </summary>
    [JsonPropertyName("ou")]
    public string? Ou { get; set; }

    /// <summary>
    /// The postal code
    /// The postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// The province
    /// The province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The requested Subject&apos;s named Serial Number
    /// The requested Subject&apos;s named serial number.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address
    /// The street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Type of intermediate to create. Must be either &quot;exported&quot; or &quot;internal&quot;
    /// or &quot;kms&quot;
    /// Type of intermediate to create. Must be either &quot;existing&quot;, &quot;exported&quot;, &quot;internal&quot; or &quot;kms&quot;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecInitProvider
{
    /// <summary>
    /// Adds a Basic Constraints extension with &apos;CA: true&apos;.
    /// Only needed as a workaround in some compatibility scenarios with Active Directory
    /// Certificate Services
    /// Set &apos;CA: true&apos; in a Basic Constraints extension. Only needed as
    /// a workaround in some compatibility scenarios with Active Directory Certificate Services.
    /// </summary>
    [JsonPropertyName("addBasicConstraints")]
    public bool? AddBasicConstraints { get; set; }

    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// CN of intermediate to create
    /// CN of intermediate to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// The country
    /// The country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// The format of data
    /// The format of data.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// List of alternative IPs
    /// List of alternative IPs.
    /// </summary>
    [JsonPropertyName("ipSans")]
    public IList<string>? IpSans { get; set; }

    /// <summary>
    /// The number of bits to use
    /// The number of bits to use.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// When a new key is created with this request, optionally specifies
    /// the name for this. The global ref default may not be used as a name.
    /// When a new key is created with this request, optionally specifies the name for this.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// Specifies the key (either default, by name, or by identifier) to use
    /// for generating this request. Only suitable for type=existing requests.
    /// Specifies the key to use for generating this request.
    /// </summary>
    [JsonPropertyName("keyRef")]
    public string? KeyRef { get; set; }

    /// <summary>
    /// The desired key type
    /// The desired key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specifies key_usage to encode in the generated certificate.
    /// Specify the key usages to encode in the generated certificate.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality
    /// The locality.
    /// </summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>
    /// The ID of the previously configured managed key. This field is
    /// required if type is kms and it conflicts with managed_key_name
    /// The ID of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the previously configured managed key. This field is
    /// required if type is kms  and it conflicts with managed_key_id
    /// The name of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

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
    /// The organization
    /// The organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The organization unit
    /// The organization unit.
    /// </summary>
    [JsonPropertyName("ou")]
    public string? Ou { get; set; }

    /// <summary>
    /// The postal code
    /// The postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// The province
    /// The province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The requested Subject&apos;s named Serial Number
    /// The requested Subject&apos;s named serial number.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address
    /// The street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Type of intermediate to create. Must be either &quot;exported&quot; or &quot;internal&quot;
    /// or &quot;kms&quot;
    /// Type of intermediate to create. Must be either &quot;existing&quot;, &quot;exported&quot;, &quot;internal&quot; or &quot;kms&quot;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretBackendIntermediateCertRequestSpec defines the desired state of SecretBackendIntermediateCertRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestSpec
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
    public V1alpha1SecretBackendIntermediateCertRequestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendIntermediateCertRequestSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendIntermediateCertRequestSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretBackendIntermediateCertRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendIntermediateCertRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestStatusAtProvider
{
    /// <summary>
    /// Adds a Basic Constraints extension with &apos;CA: true&apos;.
    /// Only needed as a workaround in some compatibility scenarios with Active Directory
    /// Certificate Services
    /// Set &apos;CA: true&apos; in a Basic Constraints extension. Only needed as
    /// a workaround in some compatibility scenarios with Active Directory Certificate Services.
    /// </summary>
    [JsonPropertyName("addBasicConstraints")]
    public bool? AddBasicConstraints { get; set; }

    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// CN of intermediate to create
    /// CN of intermediate to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// The country
    /// The country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// The CSR
    /// The CSR.
    /// </summary>
    [JsonPropertyName("csr")]
    public string? Csr { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// The format of data
    /// The format of data.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// List of alternative IPs
    /// List of alternative IPs.
    /// </summary>
    [JsonPropertyName("ipSans")]
    public IList<string>? IpSans { get; set; }

    /// <summary>
    /// The number of bits to use
    /// The number of bits to use.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// The ID of the generated key.
    /// The ID of the generated key.
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// When a new key is created with this request, optionally specifies
    /// the name for this. The global ref default may not be used as a name.
    /// When a new key is created with this request, optionally specifies the name for this.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// Specifies the key (either default, by name, or by identifier) to use
    /// for generating this request. Only suitable for type=existing requests.
    /// Specifies the key to use for generating this request.
    /// </summary>
    [JsonPropertyName("keyRef")]
    public string? KeyRef { get; set; }

    /// <summary>
    /// The desired key type
    /// The desired key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specifies key_usage to encode in the generated certificate.
    /// Specify the key usages to encode in the generated certificate.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality
    /// The locality.
    /// </summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>
    /// The ID of the previously configured managed key. This field is
    /// required if type is kms and it conflicts with managed_key_name
    /// The ID of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the previously configured managed key. This field is
    /// required if type is kms  and it conflicts with managed_key_id
    /// The name of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

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
    /// The organization
    /// The organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The organization unit
    /// The organization unit.
    /// </summary>
    [JsonPropertyName("ou")]
    public string? Ou { get; set; }

    /// <summary>
    /// The postal code
    /// The postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// The private key type
    /// The private key type.
    /// </summary>
    [JsonPropertyName("privateKeyType")]
    public string? PrivateKeyType { get; set; }

    /// <summary>
    /// The province
    /// The province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The requested Subject&apos;s named Serial Number
    /// The requested Subject&apos;s named serial number.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address
    /// The street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Type of intermediate to create. Must be either &quot;exported&quot; or &quot;internal&quot;
    /// or &quot;kms&quot;
    /// Type of intermediate to create. Must be either &quot;existing&quot;, &quot;exported&quot;, &quot;internal&quot; or &quot;kms&quot;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestStatusConditions
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

/// <summary>SecretBackendIntermediateCertRequestStatus defines the observed state of SecretBackendIntermediateCertRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendIntermediateCertRequestStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendIntermediateCertRequestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendIntermediateCertRequestStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendIntermediateCertRequest is the Schema for the SecretBackendIntermediateCertRequests API. Generate a new private key and a CSR for signing the PKI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendIntermediateCertRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendIntermediateCertRequestSpec>, IStatus<V1alpha1SecretBackendIntermediateCertRequestStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendIntermediateCertRequest";
    public const string KubeGroup = "pki.vault.upbound.io";
    public const string KubePluralName = "secretbackendintermediatecertrequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendIntermediateCertRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendIntermediateCertRequestSpec defines the desired state of SecretBackendIntermediateCertRequest</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendIntermediateCertRequestSpec Spec { get; set; }

    /// <summary>SecretBackendIntermediateCertRequestStatus defines the observed state of SecretBackendIntermediateCertRequest.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendIntermediateCertRequestStatus? Status { get; set; }
}