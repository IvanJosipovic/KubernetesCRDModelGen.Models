#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificateTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateCACertificateTemplate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateTemplateList";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificatetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateCACertificateTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PrivateCACertificateTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PrivateCACertificateTemplate> Items { get; set; }
}

/// <summary>Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecIdentityConstraintsCelExpression
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecIdentityConstraints
{
    /// <summary>Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public required bool AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public required bool AllowSubjectPassthrough { get; set; }

    /// <summary>Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel</summary>
    [JsonPropertyName("celExpression")]
    public V1beta1PrivateCACertificateTemplateSpecIdentityConstraintsCelExpression? CelExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPassthroughExtensionsAdditionalExtensions
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

/// <summary>Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPassthroughExtensions
{
    /// <summary>Optional. A set of ObjectIds identifying custom X.509 extensions. Will be combined with known_extensions to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateTemplateSpecPassthroughExtensionsAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("knownExtensions")]
    public IList<string>? KnownExtensions { get; set; }
}

/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesAdditionalExtensions
{
    /// <summary>Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public required V1beta1PrivateCACertificateTemplateSpecPredefinedValuesAdditionalExtensionsObjectId ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; X.509 extension, which is a boolean value. When this value is missing, the extension will be omitted from the CA certificate.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Optional. Refers to the path length restriction X.509 extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. If this value is missing, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public long? MaxIssuerPathLength { get; set; }
}

/// <summary>Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as &quot;non-repudiation&quot;.</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary>Detailed scenarios in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &quot;TLS WWW client authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &quot;Signing of downloadable executable code client authentication&quot;.</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &quot;Email protection&quot;.</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &quot;Signing OCSP responses&quot;.</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &quot;TLS WWW server authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &quot;Binding the hash of an object to a time&quot;.</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

/// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValuesPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public required IList<long> ObjectIdPath { get; set; }
}

/// <summary>Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecPredefinedValues
{
    /// <summary>Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACertificateTemplateSpecPredefinedValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Optional. Describes options in this X509Parameters that are relevant in a CA certificate.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACertificateTemplateSpecPredefinedValuesCaOptions? CaOptions { get; set; }

    /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACertificateTemplateSpecPredefinedValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACertificateTemplateSpecPredefinedValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpecProjectRef
{
    /// <summary>
    /// The project for the resource
    /// 
    /// Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).
    /// </summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateSpec
{
    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.</summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta1PrivateCACertificateTemplateSpecIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.</summary>
    [JsonPropertyName("passthroughExtensions")]
    public V1beta1PrivateCACertificateTemplateSpecPassthroughExtensions? PassthroughExtensions { get; set; }

    /// <summary>Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.</summary>
    [JsonPropertyName("predefinedValues")]
    public V1beta1PrivateCACertificateTemplateSpecPredefinedValues? PredefinedValues { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1PrivateCACertificateTemplateSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACertificateTemplateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateCACertificateTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time at which this CertificateTemplate was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The time at which this CertificateTemplate was updated.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACertificateTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateCACertificateTemplateSpec>, IStatus<V1beta1PrivateCACertificateTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACertificateTemplate";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacertificatetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateCACertificateTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1PrivateCACertificateTemplateSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1PrivateCACertificateTemplateStatus? Status { get; set; }
}