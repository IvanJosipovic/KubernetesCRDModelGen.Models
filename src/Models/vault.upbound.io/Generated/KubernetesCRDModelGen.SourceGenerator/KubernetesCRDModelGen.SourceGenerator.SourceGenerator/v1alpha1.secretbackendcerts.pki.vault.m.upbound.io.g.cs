#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pki.vault.m.upbound.io;
/// <summary>SecretBackendCert is the Schema for the SecretBackendCerts API. Generate an PKI certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendCertList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendCert>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendCertList";
    public const string KubeGroup = "pki.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendcerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendCertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendCert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendCert> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCertSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderBackendSelector
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
    public V1alpha1SecretBackendCertSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderNameRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderNameRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecForProviderNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecForProviderNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretBackendRole in pki to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCertSpecForProviderNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretBackendRole in pki to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProviderNameSelector
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
    public V1alpha1SecretBackendCertSpecForProviderNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecForProvider
{
    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// If set to true, certs will be renewed if the expiration is within min_seconds_remaining. Default false
    /// If enabled, a new certificate will be generated if the expiration is within min_seconds_remaining
    /// </summary>
    [JsonPropertyName("autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendCertSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendCertSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// A base 64 encoded value or an empty string to associate with the certificate&apos;s serial number. The role&apos;s no_store_metadata must be set to false, otherwise an error is returned when specified.
    /// A base 64 encoded value or an empty string to associate with the certificate&apos;s serial number. The role&apos;s no_store_metadata must be set to false, otherwise an error is returned when specified.
    /// </summary>
    [JsonPropertyName("certMetadata")]
    public string? CertMetadata { get; set; }

    /// <summary>
    /// CN of certificate to create
    /// CN of the certificate to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

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

    /// <summary>Specifies the default issuer of this request.</summary>
    [JsonPropertyName("issuerRef")]
    public string? IssuerRef { get; set; }

    /// <summary>
    /// Generate a new certificate when the expiration is within this number of seconds, default is 604800 (7 days)
    /// Generate a new certificate when the expiration is within this number of seconds
    /// </summary>
    [JsonPropertyName("minSecondsRemaining")]
    public double? MinSecondsRemaining { get; set; }

    /// <summary>
    /// Name of the role to create the certificate against
    /// Name of the role to create the certificate against.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a SecretBackendRole in pki to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1alpha1SecretBackendCertSpecForProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a SecretBackendRole in pki to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1alpha1SecretBackendCertSpecForProviderNameSelector? NameSelector { get; set; }

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
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// If set to true, the returned ca_chain field will not include any self-signed CA certificates. Useful if end-users already have the root CA in their trust store. Default false.
    /// If true, the returned ca_chain field will not include any self-signed CA certificates. Useful if end-users already have the root CA in their trust store.
    /// </summary>
    [JsonPropertyName("removeRootsFromChain")]
    public bool? RemoveRootsFromChain { get; set; }

    /// <summary>
    /// If set to true, the certificate will be revoked on resource destruction using the revoke PKI API. Conflicts with revoke_with_key. Default false.
    /// Revoke the certificate upon resource destruction.
    /// </summary>
    [JsonPropertyName("revoke")]
    public bool? Revoke { get; set; }

    /// <summary>
    /// If set to true, the certificate will be revoked on resource destruction using the revoke-with-key PKI API. Conflicts with revoke. Default false
    /// Revoke the certificate with private key method upon resource destruction.
    /// </summary>
    [JsonPropertyName("revokeWithKey")]
    public bool? RevokeWithKey { get; set; }

    /// <summary>
    /// Time to live
    /// Time to live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }

    /// <summary>
    /// List of Subject User IDs
    /// List of Subject User IDs.
    /// </summary>
    [JsonPropertyName("userIds")]
    public IList<string>? UserIds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendCertSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderNameRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderNameRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecInitProviderNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecInitProviderNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretBackendRole in pki to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCertSpecInitProviderNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretBackendRole in pki to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpecInitProviderNameSelector
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
    public V1alpha1SecretBackendCertSpecInitProviderNameSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretBackendCertSpecInitProvider
{
    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// If set to true, certs will be renewed if the expiration is within min_seconds_remaining. Default false
    /// If enabled, a new certificate will be generated if the expiration is within min_seconds_remaining
    /// </summary>
    [JsonPropertyName("autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendCertSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// A base 64 encoded value or an empty string to associate with the certificate&apos;s serial number. The role&apos;s no_store_metadata must be set to false, otherwise an error is returned when specified.
    /// A base 64 encoded value or an empty string to associate with the certificate&apos;s serial number. The role&apos;s no_store_metadata must be set to false, otherwise an error is returned when specified.
    /// </summary>
    [JsonPropertyName("certMetadata")]
    public string? CertMetadata { get; set; }

    /// <summary>
    /// CN of certificate to create
    /// CN of the certificate to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

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

    /// <summary>Specifies the default issuer of this request.</summary>
    [JsonPropertyName("issuerRef")]
    public string? IssuerRef { get; set; }

    /// <summary>
    /// Generate a new certificate when the expiration is within this number of seconds, default is 604800 (7 days)
    /// Generate a new certificate when the expiration is within this number of seconds
    /// </summary>
    [JsonPropertyName("minSecondsRemaining")]
    public double? MinSecondsRemaining { get; set; }

    /// <summary>
    /// Name of the role to create the certificate against
    /// Name of the role to create the certificate against.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a SecretBackendRole in pki to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1alpha1SecretBackendCertSpecInitProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a SecretBackendRole in pki to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1alpha1SecretBackendCertSpecInitProviderNameSelector? NameSelector { get; set; }

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
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// If set to true, the returned ca_chain field will not include any self-signed CA certificates. Useful if end-users already have the root CA in their trust store. Default false.
    /// If true, the returned ca_chain field will not include any self-signed CA certificates. Useful if end-users already have the root CA in their trust store.
    /// </summary>
    [JsonPropertyName("removeRootsFromChain")]
    public bool? RemoveRootsFromChain { get; set; }

    /// <summary>
    /// If set to true, the certificate will be revoked on resource destruction using the revoke PKI API. Conflicts with revoke_with_key. Default false.
    /// Revoke the certificate upon resource destruction.
    /// </summary>
    [JsonPropertyName("revoke")]
    public bool? Revoke { get; set; }

    /// <summary>
    /// If set to true, the certificate will be revoked on resource destruction using the revoke-with-key PKI API. Conflicts with revoke. Default false
    /// Revoke the certificate with private key method upon resource destruction.
    /// </summary>
    [JsonPropertyName("revokeWithKey")]
    public bool? RevokeWithKey { get; set; }

    /// <summary>
    /// Time to live
    /// Time to live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }

    /// <summary>
    /// List of Subject User IDs
    /// List of Subject User IDs.
    /// </summary>
    [JsonPropertyName("userIds")]
    public IList<string>? UserIds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCertSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendCertSpecManagementPoliciesEnum
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
public partial class V1alpha1SecretBackendCertSpecProviderConfigRef
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
public partial class V1alpha1SecretBackendCertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretBackendCertSpec defines the desired state of SecretBackendCert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendCertSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendCertSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretBackendCertSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendCertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendCertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertStatusAtProvider
{
    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// If set to true, certs will be renewed if the expiration is within min_seconds_remaining. Default false
    /// If enabled, a new certificate will be generated if the expiration is within min_seconds_remaining
    /// </summary>
    [JsonPropertyName("autoRenew")]
    public bool? AutoRenew { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// The CA chain
    /// The CA chain.
    /// </summary>
    [JsonPropertyName("caChain")]
    public string? CaChain { get; set; }

    /// <summary>
    /// A base 64 encoded value or an empty string to associate with the certificate&apos;s serial number. The role&apos;s no_store_metadata must be set to false, otherwise an error is returned when specified.
    /// A base 64 encoded value or an empty string to associate with the certificate&apos;s serial number. The role&apos;s no_store_metadata must be set to false, otherwise an error is returned when specified.
    /// </summary>
    [JsonPropertyName("certMetadata")]
    public string? CertMetadata { get; set; }

    /// <summary>
    /// The certificate
    /// The certicate.
    /// </summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// CN of certificate to create
    /// CN of the certificate to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// The expiration date of the certificate in unix epoch format
    /// The certificate expiration as a Unix-style timestamp.
    /// </summary>
    [JsonPropertyName("expiration")]
    public double? Expiration { get; set; }

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

    /// <summary>Specifies the default issuer of this request.</summary>
    [JsonPropertyName("issuerRef")]
    public string? IssuerRef { get; set; }

    /// <summary>
    /// The issuing CA
    /// The issuing CA.
    /// </summary>
    [JsonPropertyName("issuingCa")]
    public string? IssuingCa { get; set; }

    /// <summary>
    /// Generate a new certificate when the expiration is within this number of seconds, default is 604800 (7 days)
    /// Generate a new certificate when the expiration is within this number of seconds
    /// </summary>
    [JsonPropertyName("minSecondsRemaining")]
    public double? MinSecondsRemaining { get; set; }

    /// <summary>
    /// Name of the role to create the certificate against
    /// Name of the role to create the certificate against.
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
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

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
    /// If set to true, the returned ca_chain field will not include any self-signed CA certificates. Useful if end-users already have the root CA in their trust store. Default false.
    /// If true, the returned ca_chain field will not include any self-signed CA certificates. Useful if end-users already have the root CA in their trust store.
    /// </summary>
    [JsonPropertyName("removeRootsFromChain")]
    public bool? RemoveRootsFromChain { get; set; }

    /// <summary>
    /// true if the current time (during refresh) is after the start of the early renewal window declared by min_seconds_remaining, and false otherwise; if auto_renew is set to true then the provider will plan to replace the certificate once renewal is pending.
    /// Initially false, and then set to true during refresh once the expiration is less than min_seconds_remaining in the future.
    /// </summary>
    [JsonPropertyName("renewPending")]
    public bool? RenewPending { get; set; }

    /// <summary>
    /// If set to true, the certificate will be revoked on resource destruction using the revoke PKI API. Conflicts with revoke_with_key. Default false.
    /// Revoke the certificate upon resource destruction.
    /// </summary>
    [JsonPropertyName("revoke")]
    public bool? Revoke { get; set; }

    /// <summary>
    /// If set to true, the certificate will be revoked on resource destruction using the revoke-with-key PKI API. Conflicts with revoke. Default false
    /// Revoke the certificate with private key method upon resource destruction.
    /// </summary>
    [JsonPropertyName("revokeWithKey")]
    public bool? RevokeWithKey { get; set; }

    /// <summary>
    /// The serial number
    /// The serial number.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// Time to live
    /// Time to live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }

    /// <summary>
    /// List of Subject User IDs
    /// List of Subject User IDs.
    /// </summary>
    [JsonPropertyName("userIds")]
    public IList<string>? UserIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertStatusConditions
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

/// <summary>SecretBackendCertStatus defines the observed state of SecretBackendCert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCertStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendCertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendCertStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendCert is the Schema for the SecretBackendCerts API. Generate an PKI certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendCert : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendCertSpec>, IStatus<V1alpha1SecretBackendCertStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendCert";
    public const string KubeGroup = "pki.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendcerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendCert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendCertSpec defines the desired state of SecretBackendCert</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendCertSpec Spec { get; set; }

    /// <summary>SecretBackendCertStatus defines the observed state of SecretBackendCert.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendCertStatus? Status { get; set; }
}