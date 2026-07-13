#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certificatemanager.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateManagerCertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CertificateManagerCertificate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateManagerCertificateList";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateManagerCertificateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CertificateManagerCertificate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CertificateManagerCertificate> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecManagedAuthorizationAttemptInfo
{
    /// <summary>
    /// Human readable explanation for reaching the state. Provided to help
    /// address the configuration issues.
    /// Not guaranteed to be stable. For programmatic access use &apos;failure_reason&apos; field.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Domain name of the authorization attempt.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Reason for failure of the authorization attempt for the domain.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>State of the domain for managed certificate issuance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specified, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecManagedDnsAuthorizationsRefs
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/global/dnsAuthorizations/{{value}}`, where {{value}} is the `name` field of a `CertificateManagerDNSAuthorization` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Only the `external` field is supported to configure the reference.
/// 
/// Immutable. The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
/// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
/// Either issuanceConfig or dnsAuthorizations should be specified, but not both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecManagedIssuanceConfigRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/locations/{{location}}/certificateIssuanceConfigs/{{name}}`, where {{value}} is the `name` field of a `CertificateManagerCertificateIssuanceConfig` resource.</summary>
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
public partial class V1beta1CertificateManagerCertificateSpecManagedProvisioningIssue
{
    /// <summary>
    /// Human readable explanation about the issue. Provided to help address
    /// the configuration issues.
    /// Not guaranteed to be stable. For programmatic access use &apos;reason&apos; field.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Reason for provisioning failures.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>
/// Immutable. Configuration and state of a Managed Certificate.
/// Certificate Manager provisions and renews Managed Certificates
/// automatically, for as long as it&apos;s authorized to do so.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecManaged
{
    /// <summary>
    /// Detailed state of the latest authorization attempt for each domain
    /// specified for this Managed Certificate.
    /// </summary>
    [JsonPropertyName("authorizationAttemptInfo")]
    public IList<V1beta1CertificateManagerCertificateSpecManagedAuthorizationAttemptInfo>? AuthorizationAttemptInfo { get; set; }

    [JsonPropertyName("dnsAuthorizationsRefs")]
    public IList<V1beta1CertificateManagerCertificateSpecManagedDnsAuthorizationsRefs>? DnsAuthorizationsRefs { get; set; }

    /// <summary>
    /// Immutable. The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution.
    /// </summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>
    /// Only the `external` field is supported to configure the reference.
    /// 
    /// Immutable. The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specified, but not both.
    /// </summary>
    [JsonPropertyName("issuanceConfigRef")]
    public V1beta1CertificateManagerCertificateSpecManagedIssuanceConfigRef? IssuanceConfigRef { get; set; }

    /// <summary>Information about issues with provisioning this Managed Certificate.</summary>
    [JsonPropertyName("provisioningIssue")]
    public IList<V1beta1CertificateManagerCertificateSpecManagedProvisioningIssue>? ProvisioningIssue { get; set; }

    /// <summary>A state of this Managed Certificate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>
/// DEPRECATED. `certificate_pem` is deprecated. Use `pem_certificate` instead. Immutable. The certificate chain in PEM-encoded form.
/// 
/// Leaf certificate comes first, followed by intermediate ones if any.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedCertificatePem
{
    /// <summary>Value of the field. Cannot be used if &apos;valueFrom&apos; is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedCertificatePemValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedPemPrivateKey
{
    /// <summary>Value of the field. Cannot be used if &apos;valueFrom&apos; is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedPemPrivateKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>DEPRECATED. `private_key_pem` is deprecated. Use `pem_private_key` instead. Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManagedPrivateKeyPem
{
    /// <summary>Value of the field. Cannot be used if &apos;valueFrom&apos; is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field&apos;s value. Cannot be used if &apos;value&apos; is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedPrivateKeyPemValueFrom? ValueFrom { get; set; }
}

/// <summary>
/// Immutable. Certificate data for a SelfManaged Certificate.
/// SelfManaged Certificates are uploaded by the user. Updating such
/// certificates before they expire remains the user&apos;s responsibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpecSelfManaged
{
    /// <summary>
    /// DEPRECATED. `certificate_pem` is deprecated. Use `pem_certificate` instead. Immutable. The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [JsonPropertyName("certificatePem")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedCertificatePem? CertificatePem { get; set; }

    /// <summary>
    /// Immutable. The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
    [JsonPropertyName("pemPrivateKey")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedPemPrivateKey? PemPrivateKey { get; set; }

    /// <summary>DEPRECATED. `private_key_pem` is deprecated. Use `pem_private_key` instead. Immutable. The private key of the leaf certificate in PEM-encoded form.</summary>
    [JsonPropertyName("privateKeyPem")]
    public V1beta1CertificateManagerCertificateSpecSelfManagedPrivateKeyPem? PrivateKeyPem { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateSpec
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The Certificate Manager location. If not specified, &quot;global&quot; is used.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// Immutable. Configuration and state of a Managed Certificate.
    /// Certificate Manager provisions and renews Managed Certificates
    /// automatically, for as long as it&apos;s authorized to do so.
    /// </summary>
    [JsonPropertyName("managed")]
    public V1beta1CertificateManagerCertificateSpecManaged? Managed { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1CertificateManagerCertificateSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Immutable. The scope of the certificate.
    /// 
    /// DEFAULT: Certificates with default scope are served from core Google data centers.
    /// If unsure, choose this option.
    /// 
    /// EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates,
    /// served from non-core Google data centers.
    /// 
    /// ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs).
    /// see https://cloud.google.com/compute/docs/regions-zones.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Immutable. Certificate data for a SelfManaged Certificate.
    /// SelfManaged Certificates are uploaded by the user. Updating such
    /// certificates before they expire remains the user&apos;s responsibility.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public V1beta1CertificateManagerCertificateSpecSelfManaged? SelfManaged { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateStatusConditions
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
public partial class V1beta1CertificateManagerCertificateStatusObservedStateManagedAuthorizationAttemptInfo
{
    /// <summary>
    /// Human readable explanation for reaching the state. Provided to help
    /// address the configuration issues.
    /// Not guaranteed to be stable. For programmatic access use &apos;failure_reason&apos; field.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Domain name of the authorization attempt.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Reason for failure of the authorization attempt for the domain.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>State of the domain for managed certificate issuance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateStatusObservedStateManagedProvisioningIssue
{
    /// <summary>
    /// Human readable explanation about the issue. Provided to help address
    /// the configuration issues.
    /// Not guaranteed to be stable. For programmatic access use &apos;reason&apos; field.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Reason for provisioning failures.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>
/// Immutable. Configuration and state of a Managed Certificate.
/// Certificate Manager provisions and renews Managed Certificates
/// automatically, for as long as it&apos;s authorized to do so.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateStatusObservedStateManaged
{
    /// <summary>
    /// Detailed state of the latest authorization attempt for each domain
    /// specified for this Managed Certificate.
    /// </summary>
    [JsonPropertyName("authorizationAttemptInfo")]
    public IList<V1beta1CertificateManagerCertificateStatusObservedStateManagedAuthorizationAttemptInfo>? AuthorizationAttemptInfo { get; set; }

    /// <summary>Information about issues with provisioning this Managed Certificate.</summary>
    [JsonPropertyName("provisioningIssue")]
    public IList<V1beta1CertificateManagerCertificateStatusObservedStateManagedProvisioningIssue>? ProvisioningIssue { get; set; }

    /// <summary>A state of this Managed Certificate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The observed state of the underlying GCP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateStatusObservedState
{
    /// <summary>
    /// Immutable. Configuration and state of a Managed Certificate.
    /// Certificate Manager provisions and renews Managed Certificates
    /// automatically, for as long as it&apos;s authorized to do so.
    /// </summary>
    [JsonPropertyName("managed")]
    public V1beta1CertificateManagerCertificateStatusObservedStateManaged? Managed { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CertificateManagerCertificateStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1CertificateManagerCertificateStatusObservedState? ObservedState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateManagerCertificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateManagerCertificateSpec>, IStatus<V1beta1CertificateManagerCertificateStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateManagerCertificate";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateManagerCertificate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1CertificateManagerCertificateSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1CertificateManagerCertificateStatus? Status { get; set; }
}