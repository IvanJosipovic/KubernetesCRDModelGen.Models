#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
/// <summary>IAMServiceAccountKey is the Schema for the IAMServiceAccountKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMServiceAccountKeyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IAMServiceAccountKey>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMServiceAccountKeyList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamserviceaccountkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMServiceAccountKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1IAMServiceAccountKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1IAMServiceAccountKey> Items { get; set; }
}

/// <summary>Immutable. The Service Account to create a key for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMServiceAccountKeySpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>IAMServiceAccountKeySpec defines the desired state of IAMServiceAccountKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMServiceAccountKeySpec
{
    /// <summary>Immutable. The algorithm used to generate the key, used only on create. KEY_ALG_RSA_2048 is the default algorithm. Valid values are: &quot;KEY_ALG_RSA_1024&quot;, &quot;KEY_ALG_RSA_2048&quot;.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Immutable. The output format of the private key. TYPE_GOOGLE_CREDENTIALS_FILE is the default output format.</summary>
    [JsonPropertyName("privateKeyType")]
    public string? PrivateKeyType { get; set; }

    /// <summary>Immutable. A field that allows clients to upload their own public key. If set, use this public key data to create a service account key for given service account. Please note, the expected format for this field is a base64 encoded X509_PEM.</summary>
    [JsonPropertyName("publicKeyData")]
    public string? PublicKeyData { get; set; }

    /// <summary>Immutable. The output format for the public key. TYPE_NONE is the default for public key output.</summary>
    [JsonPropertyName("publicKeyType")]
    public string? PublicKeyType { get; set; }

    /// <summary>Immutable. The Service Account to create a key for.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public required V1beta1IAMServiceAccountKeySpecServiceAccountRef ServiceAccountRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMServiceAccountKeyStatusConditions
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

/// <summary>IAMServiceAccountKeyStatus defines the config connector machine state of IAMServiceAccountKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMServiceAccountKeyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMServiceAccountKeyStatusConditions>? Conditions { get; set; }

    /// <summary>Immutable. The name used for this key pair.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The private key in JSON format, base64 encoded. This is what you normally get as a file when creating service account keys through the CLI or web console. This is only populated when creating a new key.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>Immutable. The public key, base64 encoded.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The key can be used after this timestamp. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("validAfter")]
    public string? ValidAfter { get; set; }

    /// <summary>The key can be used before this timestamp. A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds. Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("validBefore")]
    public string? ValidBefore { get; set; }
}

/// <summary>IAMServiceAccountKey is the Schema for the IAMServiceAccountKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMServiceAccountKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMServiceAccountKeySpec>, IStatus<V1beta1IAMServiceAccountKeyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMServiceAccountKey";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamserviceaccountkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMServiceAccountKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMServiceAccountKeySpec defines the desired state of IAMServiceAccountKey</summary>
    [JsonPropertyName("spec")]
    public required V1beta1IAMServiceAccountKeySpec Spec { get; set; }

    /// <summary>IAMServiceAccountKeyStatus defines the config connector machine state of IAMServiceAccountKey</summary>
    [JsonPropertyName("status")]
    public V1beta1IAMServiceAccountKeyStatus? Status { get; set; }
}