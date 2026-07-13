#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.gcp.upbound.io;
/// <summary>Attestor is the Schema for the Attestors API. An attestor that attests to container image artifacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AttestorList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Attestor>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AttestorList";
    public const string KubeGroup = "binaryauthorization.gcp.upbound.io";
    public const string KubePluralName = "attestors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AttestorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Attestor objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Attestor> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecDeletionPolicyEnum>))]
public enum V1beta2AttestorSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum>))]
public enum V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum>))]
public enum V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum>))]
public enum V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum>))]
public enum V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelector
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
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A raw PKIX SubjectPublicKeyInfo format public key.
/// NOTE: id may be explicitly provided by the caller when using this
/// type of public key, but it MUST be a valid RFC3986 URI. If id is left
/// blank, a default one will be computed based on the digest of the DER
/// encoding of the public key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNotePublicKeysPkixPublicKey
{
    /// <summary>
    /// A PEM-encoded public key, as described in
    /// https://tools.ietf.org/html/rfc7468#section-13
    /// </summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>
    /// The signature algorithm used to verify a message against
    /// a signature using this key. These signature algorithm must
    /// match the structure and any object identifiers encoded in
    /// publicKeyPem (i.e. this algorithm must match that of the
    /// public key).
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNotePublicKeys
{
    /// <summary>
    /// ASCII-armored representation of a PGP public key, as the
    /// entire output by the command
    /// gpg --export --armor foo@example.com (either LF or CRLF
    /// line endings). When using this field, id should be left
    /// blank. The BinAuthz API handlers will calculate the ID
    /// and fill it in automatically. BinAuthz computes this ID
    /// as the OpenPGP RFC4880 V4 fingerprint, represented as
    /// upper-case hex. If id is provided by the caller, it will
    /// be overwritten by the API-calculated ID.
    /// </summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The ID of this public key. Signatures verified by BinAuthz
    /// must include the ID of the public key that can be used to
    /// verify them, and that ID must match the contents of this
    /// field exactly. Additional restrictions on this field can
    /// be imposed based on which public key type is encapsulated.
    /// See the documentation on publicKey cases below for details.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A raw PKIX SubjectPublicKeyInfo format public key.
    /// NOTE: id may be explicitly provided by the caller when using this
    /// type of public key, but it MUST be a valid RFC3986 URI. If id is left
    /// blank, a default one will be computed based on the digest of the DER
    /// encoding of the public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pkixPublicKey")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNotePublicKeysPkixPublicKey? PkixPublicKey { get; set; }
}

/// <summary>
/// A Container Analysis ATTESTATION_AUTHORITY Note, created by the user.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProviderAttestationAuthorityNote
{
    /// <summary>
    /// The resource name of a ATTESTATION_AUTHORITY Note, created by the
    /// user. If the Note is in a different project from the Attestor, it
    /// should be specified in the format projects/*/notes/* (or the legacy
    /// providers/*/notes/*). This field may not be updated.
    /// An attestation by this attestor is stored as a Container Analysis
    /// ATTESTATION_AUTHORITY Occurrence that names a container image
    /// and that links to this Note.
    /// </summary>
    [JsonPropertyName("noteReference")]
    public string? NoteReference { get; set; }

    /// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceRef")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceRef? NoteReferenceRef { get; set; }

    /// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceSelector")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNoteNoteReferenceSelector? NoteReferenceSelector { get; set; }

    /// <summary>
    /// Public keys that verify attestations signed by this attestor. This
    /// field may be updated.
    /// If this field is non-empty, one of the specified public keys must
    /// verify that an attestation was signed by this attestor for the
    /// image specified in the admission request.
    /// If this field is empty, this attestor always returns that no valid
    /// attestations exist.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta2AttestorSpecForProviderAttestationAuthorityNotePublicKeys>? PublicKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecForProvider
{
    /// <summary>
    /// A Container Analysis ATTESTATION_AUTHORITY Note, created by the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("attestationAuthorityNote")]
    public V1beta2AttestorSpecForProviderAttestationAuthorityNote? AttestationAuthorityNote { get; set; }

    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum>))]
public enum V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum>))]
public enum V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum>))]
public enum V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum>))]
public enum V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelector
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
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A raw PKIX SubjectPublicKeyInfo format public key.
/// NOTE: id may be explicitly provided by the caller when using this
/// type of public key, but it MUST be a valid RFC3986 URI. If id is left
/// blank, a default one will be computed based on the digest of the DER
/// encoding of the public key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNotePublicKeysPkixPublicKey
{
    /// <summary>
    /// A PEM-encoded public key, as described in
    /// https://tools.ietf.org/html/rfc7468#section-13
    /// </summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>
    /// The signature algorithm used to verify a message against
    /// a signature using this key. These signature algorithm must
    /// match the structure and any object identifiers encoded in
    /// publicKeyPem (i.e. this algorithm must match that of the
    /// public key).
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNotePublicKeys
{
    /// <summary>
    /// ASCII-armored representation of a PGP public key, as the
    /// entire output by the command
    /// gpg --export --armor foo@example.com (either LF or CRLF
    /// line endings). When using this field, id should be left
    /// blank. The BinAuthz API handlers will calculate the ID
    /// and fill it in automatically. BinAuthz computes this ID
    /// as the OpenPGP RFC4880 V4 fingerprint, represented as
    /// upper-case hex. If id is provided by the caller, it will
    /// be overwritten by the API-calculated ID.
    /// </summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The ID of this public key. Signatures verified by BinAuthz
    /// must include the ID of the public key that can be used to
    /// verify them, and that ID must match the contents of this
    /// field exactly. Additional restrictions on this field can
    /// be imposed based on which public key type is encapsulated.
    /// See the documentation on publicKey cases below for details.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A raw PKIX SubjectPublicKeyInfo format public key.
    /// NOTE: id may be explicitly provided by the caller when using this
    /// type of public key, but it MUST be a valid RFC3986 URI. If id is left
    /// blank, a default one will be computed based on the digest of the DER
    /// encoding of the public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pkixPublicKey")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNotePublicKeysPkixPublicKey? PkixPublicKey { get; set; }
}

/// <summary>
/// A Container Analysis ATTESTATION_AUTHORITY Note, created by the user.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecInitProviderAttestationAuthorityNote
{
    /// <summary>
    /// The resource name of a ATTESTATION_AUTHORITY Note, created by the
    /// user. If the Note is in a different project from the Attestor, it
    /// should be specified in the format projects/*/notes/* (or the legacy
    /// providers/*/notes/*). This field may not be updated.
    /// An attestation by this attestor is stored as a Container Analysis
    /// ATTESTATION_AUTHORITY Occurrence that names a container image
    /// and that links to this Note.
    /// </summary>
    [JsonPropertyName("noteReference")]
    public string? NoteReference { get; set; }

    /// <summary>Reference to a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceRef")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceRef? NoteReferenceRef { get; set; }

    /// <summary>Selector for a Note in containeranalysis to populate noteReference.</summary>
    [JsonPropertyName("noteReferenceSelector")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNoteNoteReferenceSelector? NoteReferenceSelector { get; set; }

    /// <summary>
    /// Public keys that verify attestations signed by this attestor. This
    /// field may be updated.
    /// If this field is non-empty, one of the specified public keys must
    /// verify that an attestation was signed by this attestor for the
    /// image specified in the admission request.
    /// If this field is empty, this attestor always returns that no valid
    /// attestations exist.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta2AttestorSpecInitProviderAttestationAuthorityNotePublicKeys>? PublicKeys { get; set; }
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
public partial class V1beta2AttestorSpecInitProvider
{
    /// <summary>
    /// A Container Analysis ATTESTATION_AUTHORITY Note, created by the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("attestationAuthorityNote")]
    public V1beta2AttestorSpecInitProviderAttestationAuthorityNote? AttestationAuthorityNote { get; set; }

    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecManagementPoliciesEnum>))]
public enum V1beta2AttestorSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AttestorSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AttestorSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AttestorSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AttestorSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AttestorSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AttestorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AttestorSpec defines the desired state of Attestor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorSpec
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
    public V1beta2AttestorSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AttestorSpecForProvider ForProvider { get; set; }

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
    public V1beta2AttestorSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AttestorSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AttestorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AttestorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A raw PKIX SubjectPublicKeyInfo format public key.
/// NOTE: id may be explicitly provided by the caller when using this
/// type of public key, but it MUST be a valid RFC3986 URI. If id is left
/// blank, a default one will be computed based on the digest of the DER
/// encoding of the public key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorStatusAtProviderAttestationAuthorityNotePublicKeysPkixPublicKey
{
    /// <summary>
    /// A PEM-encoded public key, as described in
    /// https://tools.ietf.org/html/rfc7468#section-13
    /// </summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>
    /// The signature algorithm used to verify a message against
    /// a signature using this key. These signature algorithm must
    /// match the structure and any object identifiers encoded in
    /// publicKeyPem (i.e. this algorithm must match that of the
    /// public key).
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorStatusAtProviderAttestationAuthorityNotePublicKeys
{
    /// <summary>
    /// ASCII-armored representation of a PGP public key, as the
    /// entire output by the command
    /// gpg --export --armor foo@example.com (either LF or CRLF
    /// line endings). When using this field, id should be left
    /// blank. The BinAuthz API handlers will calculate the ID
    /// and fill it in automatically. BinAuthz computes this ID
    /// as the OpenPGP RFC4880 V4 fingerprint, represented as
    /// upper-case hex. If id is provided by the caller, it will
    /// be overwritten by the API-calculated ID.
    /// </summary>
    [JsonPropertyName("asciiArmoredPgpPublicKey")]
    public string? AsciiArmoredPgpPublicKey { get; set; }

    /// <summary>A descriptive comment. This field may be updated.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// The ID of this public key. Signatures verified by BinAuthz
    /// must include the ID of the public key that can be used to
    /// verify them, and that ID must match the contents of this
    /// field exactly. Additional restrictions on this field can
    /// be imposed based on which public key type is encapsulated.
    /// See the documentation on publicKey cases below for details.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A raw PKIX SubjectPublicKeyInfo format public key.
    /// NOTE: id may be explicitly provided by the caller when using this
    /// type of public key, but it MUST be a valid RFC3986 URI. If id is left
    /// blank, a default one will be computed based on the digest of the DER
    /// encoding of the public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pkixPublicKey")]
    public V1beta2AttestorStatusAtProviderAttestationAuthorityNotePublicKeysPkixPublicKey? PkixPublicKey { get; set; }
}

/// <summary>
/// A Container Analysis ATTESTATION_AUTHORITY Note, created by the user.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorStatusAtProviderAttestationAuthorityNote
{
    /// <summary>
    /// (Output)
    /// This field will contain the service account email address that
    /// this Attestor will use as the principal when querying Container
    /// Analysis. Attestor administrators must grant this service account
    /// the IAM role needed to read attestations from the noteReference in
    /// Container Analysis (containeranalysis.notes.occurrences.viewer).
    /// This email address is fixed for the lifetime of the Attestor, but
    /// callers should not make any other assumptions about the service
    /// account email; future versions may use an email based on a
    /// different naming pattern.
    /// </summary>
    [JsonPropertyName("delegationServiceAccountEmail")]
    public string? DelegationServiceAccountEmail { get; set; }

    /// <summary>
    /// The resource name of a ATTESTATION_AUTHORITY Note, created by the
    /// user. If the Note is in a different project from the Attestor, it
    /// should be specified in the format projects/*/notes/* (or the legacy
    /// providers/*/notes/*). This field may not be updated.
    /// An attestation by this attestor is stored as a Container Analysis
    /// ATTESTATION_AUTHORITY Occurrence that names a container image
    /// and that links to this Note.
    /// </summary>
    [JsonPropertyName("noteReference")]
    public string? NoteReference { get; set; }

    /// <summary>
    /// Public keys that verify attestations signed by this attestor. This
    /// field may be updated.
    /// If this field is non-empty, one of the specified public keys must
    /// verify that an attestation was signed by this attestor for the
    /// image specified in the admission request.
    /// If this field is empty, this attestor always returns that no valid
    /// attestations exist.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1beta2AttestorStatusAtProviderAttestationAuthorityNotePublicKeys>? PublicKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorStatusAtProvider
{
    /// <summary>
    /// A Container Analysis ATTESTATION_AUTHORITY Note, created by the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("attestationAuthorityNote")]
    public V1beta2AttestorStatusAtProviderAttestationAuthorityNote? AttestationAuthorityNote { get; set; }

    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/attestors/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorStatusConditions
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

/// <summary>AttestorStatus defines the observed state of Attestor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AttestorStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AttestorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AttestorStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Attestor is the Schema for the Attestors API. An attestor that attests to container image artifacts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Attestor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AttestorSpec>, IStatus<V1beta2AttestorStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Attestor";
    public const string KubeGroup = "binaryauthorization.gcp.upbound.io";
    public const string KubePluralName = "attestors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Attestor";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AttestorSpec defines the desired state of Attestor</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AttestorSpec Spec { get; set; }

    /// <summary>AttestorStatus defines the observed state of Attestor.</summary>
    [JsonPropertyName("status")]
    public V1beta2AttestorStatus? Status { get; set; }
}