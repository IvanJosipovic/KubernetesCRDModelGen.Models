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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSKeyRingImportJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1KMSKeyRingImportJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSKeyRingImportJobList";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmskeyringimportjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kms.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KMSKeyRingImportJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1KMSKeyRingImportJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1KMSKeyRingImportJob> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobSpec
{
    /// <summary>Immutable. It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}.</summary>
    [JsonPropertyName("importJobId")]
    public required string ImportJobId { get; set; }

    /// <summary>Immutable. The wrapping method to be used for incoming key material. Possible values: [&quot;RSA_OAEP_3072_SHA1_AES_256&quot;, &quot;RSA_OAEP_4096_SHA1_AES_256&quot;].</summary>
    [JsonPropertyName("importMethod")]
    public required string ImportMethod { get; set; }

    /// <summary>
    /// Immutable. The KeyRing that this import job belongs to.
    /// Format: &apos; &apos;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&apos; &apos;.
    /// </summary>
    [JsonPropertyName("keyRing")]
    public required string KeyRing { get; set; }

    /// <summary>
    /// Immutable. The protection level of the ImportJob. This must match the protectionLevel of the
    /// versionTemplate on the CryptoKey you attempt to import into. Possible values: [&quot;SOFTWARE&quot;, &quot;HSM&quot;, &quot;EXTERNAL&quot;].
    /// </summary>
    [JsonPropertyName("protectionLevel")]
    public required string ProtectionLevel { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatusAttestation
{
    /// <summary>
    /// The attestation data provided by the HSM when the key operation was performed.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The format of the attestation data.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatusConditions
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
public partial class V1alpha1KMSKeyRingImportJobStatusPublicKey
{
    /// <summary>
    /// The public key, encoded in PEM format. For more information, see the RFC 7468 sections
    /// for General Considerations and Textual Encoding of Subject Public Key Info.
    /// </summary>
    [JsonPropertyName("pem")]
    public string? Pem { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KMSKeyRingImportJobStatus
{
    /// <summary>
    /// Statement that was generated and signed by the key creator (for example, an HSM) at key creation time.
    /// Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only present if the chosen ImportMethod is one with a protection level of HSM.
    /// </summary>
    [JsonPropertyName("attestation")]
    public IList<V1alpha1KMSKeyRingImportJobStatusAttestation>? Attestation { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1KMSKeyRingImportJobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The time at which this resource is scheduled for expiration and can no longer be used.
    /// This is in RFC3339 text format.
    /// </summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The public key with which to wrap key material prior to import. Only returned if state is &apos;ACTIVE&apos;.</summary>
    [JsonPropertyName("publicKey")]
    public IList<V1alpha1KMSKeyRingImportJobStatusPublicKey>? PublicKey { get; set; }

    /// <summary>The current state of the ImportJob, indicating if it can be used.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KMSKeyRingImportJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1KMSKeyRingImportJobSpec>, IStatus<V1alpha1KMSKeyRingImportJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KMSKeyRingImportJob";
    public const string KubeGroup = "kms.cnrm.cloud.google.com";
    public const string KubePluralName = "kmskeyringimportjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kms.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KMSKeyRingImportJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1KMSKeyRingImportJobSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1KMSKeyRingImportJobStatus? Status { get; set; }
}