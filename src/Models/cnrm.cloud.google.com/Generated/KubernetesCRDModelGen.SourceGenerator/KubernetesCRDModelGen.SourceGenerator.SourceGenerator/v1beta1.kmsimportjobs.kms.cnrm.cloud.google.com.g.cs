#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kms.cnrm.cloud.google.com;
/// <summary>KMSImportJob is the Schema for the KMSImportJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KMSImportJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KMSImportJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KMSImportJobList";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmsimportjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kms.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KMSImportJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1KMSImportJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1KMSImportJob> Items { get; set; }
}

/// <summary>KMSKeyRingRef defines the resource reference to KMSKeyRing, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobSpecKmsKeyRingRef
{
    /// <summary>A reference to an externally managed KMSKeyRing. Should be in the format `projects/{{projectId}}/locations/{{location}}/keyRings/{{keyRingId}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSKeyRing` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSKeyRing` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>KMSImportJobSpec defines the desired state of KMSImportJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobSpec
{
    /// <summary>Required. Immutable. The wrapping method to be used for incoming key material.</summary>
    [JsonPropertyName("importMethod")]
    public required string ImportMethod { get; set; }

    /// <summary>KMSKeyRingRef defines the resource reference to KMSKeyRing, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("kmsKeyRingRef")]
    public required V1beta1KMSImportJobSpecKmsKeyRingRef KmsKeyRingRef { get; set; }

    /// <summary>Required. Immutable. The protection level of the [ImportJob][google.cloud.kms.v1.ImportJob]. This must match the [protection_level][google.cloud.kms.v1.CryptoKeyVersionTemplate.protection_level] of the [version_template][google.cloud.kms.v1.CryptoKey.version_template] on the [CryptoKey][google.cloud.kms.v1.CryptoKey] you attempt to import into.</summary>
    [JsonPropertyName("protectionLevel")]
    public required string ProtectionLevel { get; set; }

    /// <summary>The KMSImportJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobStatusConditions
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

/// <summary>Output only. The certificate chains needed to validate the attestation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobStatusObservedStateAttestationCertChains
{
    /// <summary>Cavium certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("caviumCerts")]
    public IList<string>? CaviumCerts { get; set; }

    /// <summary>Google card certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("googleCardCerts")]
    public IList<string>? GoogleCardCerts { get; set; }

    /// <summary>Google partition certificate chain corresponding to the attestation.</summary>
    [JsonPropertyName("googlePartitionCerts")]
    public IList<string>? GooglePartitionCerts { get; set; }
}

/// <summary>Output only. Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen [ImportMethod][google.cloud.kms.v1.ImportJob.ImportMethod] is one with a protection level of [HSM][google.cloud.kms.v1.ProtectionLevel.HSM].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobStatusObservedStateAttestation
{
    /// <summary>Output only. The certificate chains needed to validate the attestation</summary>
    [JsonPropertyName("certChains")]
    public V1beta1KMSImportJobStatusObservedStateAttestationCertChains? CertChains { get; set; }

    /// <summary>Output only. The attestation data provided by the HSM when the key operation was performed.</summary>
    [JsonPropertyName("content")]
    public byte[]? Content { get; set; }

    /// <summary>Output only. The format of the attestation data.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary>Output only. The public key with which to wrap key material prior to import. Only returned if [state][google.cloud.kms.v1.ImportJob.state] is [ACTIVE][google.cloud.kms.v1.ImportJob.ImportJobState.ACTIVE].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobStatusObservedStatePublicKey
{
    /// <summary>The public key, encoded in PEM format. For more information, see the [RFC 7468](https://tools.ietf.org/html/rfc7468) sections for [General Considerations](https://tools.ietf.org/html/rfc7468#section-2) and [Textual Encoding of Subject Public Key Info] (https://tools.ietf.org/html/rfc7468#section-13).</summary>
    [JsonPropertyName("pem")]
    public string? Pem { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobStatusObservedState
{
    /// <summary>Output only. Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen [ImportMethod][google.cloud.kms.v1.ImportJob.ImportMethod] is one with a protection level of [HSM][google.cloud.kms.v1.ProtectionLevel.HSM].</summary>
    [JsonPropertyName("attestation")]
    public V1beta1KMSImportJobStatusObservedStateAttestation? Attestation { get; set; }

    /// <summary>Output only. The time at which this [ImportJob][google.cloud.kms.v1.ImportJob] was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time this [ImportJob][google.cloud.kms.v1.ImportJob] expired. Only present if [state][google.cloud.kms.v1.ImportJob.state] is [EXPIRED][google.cloud.kms.v1.ImportJob.ImportJobState.EXPIRED].</summary>
    [JsonPropertyName("expireEventTime")]
    public string? ExpireEventTime { get; set; }

    /// <summary>Output only. The time at which this [ImportJob][google.cloud.kms.v1.ImportJob] is scheduled for expiration and can no longer be used to import key material.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The time this [ImportJob][google.cloud.kms.v1.ImportJob]&apos;s key material was generated.</summary>
    [JsonPropertyName("generateTime")]
    public string? GenerateTime { get; set; }

    /// <summary>Output only. The public key with which to wrap key material prior to import. Only returned if [state][google.cloud.kms.v1.ImportJob.state] is [ACTIVE][google.cloud.kms.v1.ImportJob.ImportJobState.ACTIVE].</summary>
    [JsonPropertyName("publicKey")]
    public V1beta1KMSImportJobStatusObservedStatePublicKey? PublicKey { get; set; }

    /// <summary>Output only. The current state of the [ImportJob][google.cloud.kms.v1.ImportJob], indicating if it can be used.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>KMSImportJobStatus defines the config connector machine state of KMSImportJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KMSImportJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KMSImportJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the KMSImportJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1KMSImportJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>KMSImportJob is the Schema for the KMSImportJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KMSImportJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KMSImportJobSpec>, IStatus<V1beta1KMSImportJobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KMSImportJob";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmsimportjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kms.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KMSImportJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KMSImportJobSpec defines the desired state of KMSImportJob</summary>
    [JsonPropertyName("spec")]
    public required V1beta1KMSImportJobSpec Spec { get; set; }

    /// <summary>KMSImportJobStatus defines the config connector machine state of KMSImportJob</summary>
    [JsonPropertyName("status")]
    public V1beta1KMSImportJobStatus? Status { get; set; }
}