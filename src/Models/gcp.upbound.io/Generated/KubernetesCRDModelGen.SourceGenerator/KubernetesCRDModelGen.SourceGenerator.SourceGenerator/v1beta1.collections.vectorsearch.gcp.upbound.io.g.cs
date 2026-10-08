#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vectorsearch.gcp.upbound.io;
/// <summary>Collection is the Schema for the Collections API. Description</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CollectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Collection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CollectionList";
    public const string KubeGroup = "vectorsearch.gcp.upbound.io";
    public const string KubePluralName = "collections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vectorsearch.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CollectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Collection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Collection> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecDeletionPolicyEnum>))]
public enum V1beta1CollectionSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicyResolutionEnum>))]
public enum V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicyResolveEnum>))]
public enum V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate cryptoKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate cryptoKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelector
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
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents a customer-managed encryption key specification that can be
/// applied to a Vector Search collection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderEncryptionSpec
{
    /// <summary>
    /// Resource name of the Cloud KMS key used to protect the resource.
    /// The Cloud KMS key must be in the same region as the resource. It must have
    /// the format
    /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate cryptoKeyName.</summary>
    [JsonPropertyName("cryptoKeyNameRef")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameRef? CryptoKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate cryptoKeyName.</summary>
    [JsonPropertyName("cryptoKeyNameSelector")]
    public V1beta1CollectionSpecForProviderEncryptionSpecCryptoKeyNameSelector? CryptoKeyNameSelector { get; set; }
}

/// <summary>
/// Message describing the configuration for generating embeddings for a vector
/// field using Vertex AI embeddings API.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderVectorSchemaDenseVectorVertexEmbeddingConfig
{
    /// <summary>
    /// Required: ID of the embedding model to use. See
    /// https://cloud.google.com/vertex-ai/generative-ai/docs/learn/models#embeddings-models
    /// for the list of supported models.
    /// </summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>
    /// Possible values:
    /// RETRIEVAL_QUERY
    /// RETRIEVAL_DOCUMENT
    /// SEMANTIC_SIMILARITY
    /// CLASSIFICATION
    /// CLUSTERING
    /// QUESTION_ANSWERING
    /// FACT_VERIFICATION
    /// CODE_RETRIEVAL_QUERY
    /// </summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }

    /// <summary>
    /// Required: Text template for the input to the model. The template must
    /// contain one or more references to fields in the DataObject, e.g.:
    /// &quot;Movie Title: {title} ---- Movie Plot: {plot}&quot;.
    /// </summary>
    [JsonPropertyName("textTemplate")]
    public string? TextTemplate { get; set; }
}

/// <summary>
/// Message describing a dense vector field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderVectorSchemaDenseVector
{
    /// <summary>Dimensionality of the vector field.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>
    /// Message describing the configuration for generating embeddings for a vector
    /// field using Vertex AI embeddings API.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vertexEmbeddingConfig")]
    public V1beta1CollectionSpecForProviderVectorSchemaDenseVectorVertexEmbeddingConfig? VertexEmbeddingConfig { get; set; }
}

/// <summary>Message describing a sparse vector field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderVectorSchemaSparseVector
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProviderVectorSchema
{
    /// <summary>
    /// Message describing a dense vector field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("denseVector")]
    public V1beta1CollectionSpecForProviderVectorSchemaDenseVector? DenseVector { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>Message describing a sparse vector field.</summary>
    [JsonPropertyName("sparseVector")]
    public V1beta1CollectionSpecForProviderVectorSchemaSparseVector? SparseVector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecForProvider
{
    /// <summary>
    /// JSON Schema for data.
    /// Field names must contain only alphanumeric characters,
    /// underscores, and hyphens.
    /// </summary>
    [JsonPropertyName("dataSchema")]
    public string? DataSchema { get; set; }

    /// <summary>User-specified description of the collection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User-specified display name of the collection</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Represents a customer-managed encryption key specification that can be
    /// applied to a Vector Search collection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1CollectionSpecForProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>
    /// Labels as key value pairs.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Schema for vector fields. Only vector fields in this schema will be
    /// searchable.
    /// Field names must contain only alphanumeric characters,
    /// underscores, and hyphens.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vectorSchema")]
    public IList<V1beta1CollectionSpecForProviderVectorSchema>? VectorSchema { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicyResolutionEnum>))]
public enum V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicyResolveEnum>))]
public enum V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate cryptoKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate cryptoKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelector
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
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents a customer-managed encryption key specification that can be
/// applied to a Vector Search collection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderEncryptionSpec
{
    /// <summary>
    /// Resource name of the Cloud KMS key used to protect the resource.
    /// The Cloud KMS key must be in the same region as the resource. It must have
    /// the format
    /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate cryptoKeyName.</summary>
    [JsonPropertyName("cryptoKeyNameRef")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameRef? CryptoKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate cryptoKeyName.</summary>
    [JsonPropertyName("cryptoKeyNameSelector")]
    public V1beta1CollectionSpecInitProviderEncryptionSpecCryptoKeyNameSelector? CryptoKeyNameSelector { get; set; }
}

/// <summary>
/// Message describing the configuration for generating embeddings for a vector
/// field using Vertex AI embeddings API.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderVectorSchemaDenseVectorVertexEmbeddingConfig
{
    /// <summary>
    /// Required: ID of the embedding model to use. See
    /// https://cloud.google.com/vertex-ai/generative-ai/docs/learn/models#embeddings-models
    /// for the list of supported models.
    /// </summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>
    /// Possible values:
    /// RETRIEVAL_QUERY
    /// RETRIEVAL_DOCUMENT
    /// SEMANTIC_SIMILARITY
    /// CLASSIFICATION
    /// CLUSTERING
    /// QUESTION_ANSWERING
    /// FACT_VERIFICATION
    /// CODE_RETRIEVAL_QUERY
    /// </summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }

    /// <summary>
    /// Required: Text template for the input to the model. The template must
    /// contain one or more references to fields in the DataObject, e.g.:
    /// &quot;Movie Title: {title} ---- Movie Plot: {plot}&quot;.
    /// </summary>
    [JsonPropertyName("textTemplate")]
    public string? TextTemplate { get; set; }
}

/// <summary>
/// Message describing a dense vector field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderVectorSchemaDenseVector
{
    /// <summary>Dimensionality of the vector field.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>
    /// Message describing the configuration for generating embeddings for a vector
    /// field using Vertex AI embeddings API.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vertexEmbeddingConfig")]
    public V1beta1CollectionSpecInitProviderVectorSchemaDenseVectorVertexEmbeddingConfig? VertexEmbeddingConfig { get; set; }
}

/// <summary>Message describing a sparse vector field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderVectorSchemaSparseVector
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecInitProviderVectorSchema
{
    /// <summary>
    /// Message describing a dense vector field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("denseVector")]
    public V1beta1CollectionSpecInitProviderVectorSchemaDenseVector? DenseVector { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>Message describing a sparse vector field.</summary>
    [JsonPropertyName("sparseVector")]
    public V1beta1CollectionSpecInitProviderVectorSchemaSparseVector? SparseVector { get; set; }
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
public partial class V1beta1CollectionSpecInitProvider
{
    /// <summary>
    /// JSON Schema for data.
    /// Field names must contain only alphanumeric characters,
    /// underscores, and hyphens.
    /// </summary>
    [JsonPropertyName("dataSchema")]
    public string? DataSchema { get; set; }

    /// <summary>User-specified description of the collection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User-specified display name of the collection</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Represents a customer-managed encryption key specification that can be
    /// applied to a Vector Search collection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1CollectionSpecInitProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>
    /// Labels as key value pairs.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Schema for vector fields. Only vector fields in this schema will be
    /// searchable.
    /// Field names must contain only alphanumeric characters,
    /// underscores, and hyphens.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vectorSchema")]
    public IList<V1beta1CollectionSpecInitProviderVectorSchema>? VectorSchema { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecManagementPoliciesEnum>))]
public enum V1beta1CollectionSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1CollectionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CollectionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1CollectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CollectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CollectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CollectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CollectionSpec defines the desired state of Collection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionSpec
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
    public V1beta1CollectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1CollectionSpecForProvider ForProvider { get; set; }

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
    public V1beta1CollectionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1CollectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CollectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CollectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Represents a customer-managed encryption key specification that can be
/// applied to a Vector Search collection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusAtProviderEncryptionSpec
{
    /// <summary>
    /// Resource name of the Cloud KMS key used to protect the resource.
    /// The Cloud KMS key must be in the same region as the resource. It must have
    /// the format
    /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }
}

/// <summary>
/// Message describing the configuration for generating embeddings for a vector
/// field using Vertex AI embeddings API.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusAtProviderVectorSchemaDenseVectorVertexEmbeddingConfig
{
    /// <summary>
    /// Required: ID of the embedding model to use. See
    /// https://cloud.google.com/vertex-ai/generative-ai/docs/learn/models#embeddings-models
    /// for the list of supported models.
    /// </summary>
    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    /// <summary>
    /// Possible values:
    /// RETRIEVAL_QUERY
    /// RETRIEVAL_DOCUMENT
    /// SEMANTIC_SIMILARITY
    /// CLASSIFICATION
    /// CLUSTERING
    /// QUESTION_ANSWERING
    /// FACT_VERIFICATION
    /// CODE_RETRIEVAL_QUERY
    /// </summary>
    [JsonPropertyName("taskType")]
    public string? TaskType { get; set; }

    /// <summary>
    /// Required: Text template for the input to the model. The template must
    /// contain one or more references to fields in the DataObject, e.g.:
    /// &quot;Movie Title: {title} ---- Movie Plot: {plot}&quot;.
    /// </summary>
    [JsonPropertyName("textTemplate")]
    public string? TextTemplate { get; set; }
}

/// <summary>
/// Message describing a dense vector field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusAtProviderVectorSchemaDenseVector
{
    /// <summary>Dimensionality of the vector field.</summary>
    [JsonPropertyName("dimensions")]
    public double? Dimensions { get; set; }

    /// <summary>
    /// Message describing the configuration for generating embeddings for a vector
    /// field using Vertex AI embeddings API.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vertexEmbeddingConfig")]
    public V1beta1CollectionStatusAtProviderVectorSchemaDenseVectorVertexEmbeddingConfig? VertexEmbeddingConfig { get; set; }
}

/// <summary>Message describing a sparse vector field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusAtProviderVectorSchemaSparseVector
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusAtProviderVectorSchema
{
    /// <summary>
    /// Message describing a dense vector field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("denseVector")]
    public V1beta1CollectionStatusAtProviderVectorSchemaDenseVector? DenseVector { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>Message describing a sparse vector field.</summary>
    [JsonPropertyName("sparseVector")]
    public V1beta1CollectionStatusAtProviderVectorSchemaSparseVector? SparseVector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusAtProvider
{
    /// <summary>[Output only] Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// JSON Schema for data.
    /// Field names must contain only alphanumeric characters,
    /// underscores, and hyphens.
    /// </summary>
    [JsonPropertyName("dataSchema")]
    public string? DataSchema { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>User-specified description of the collection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User-specified display name of the collection</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Represents a customer-managed encryption key specification that can be
    /// applied to a Vector Search collection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionSpec")]
    public V1beta1CollectionStatusAtProviderEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/collections/{{collection_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Labels as key value pairs.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Identifier. name of resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>[Output only] Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Schema for vector fields. Only vector fields in this schema will be
    /// searchable.
    /// Field names must contain only alphanumeric characters,
    /// underscores, and hyphens.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vectorSchema")]
    public IList<V1beta1CollectionStatusAtProviderVectorSchema>? VectorSchema { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatusConditions
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

/// <summary>CollectionStatus defines the observed state of Collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CollectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CollectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CollectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Collection is the Schema for the Collections API. Description</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Collection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CollectionSpec>, IStatus<V1beta1CollectionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Collection";
    public const string KubeGroup = "vectorsearch.gcp.upbound.io";
    public const string KubePluralName = "collections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vectorsearch.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Collection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CollectionSpec defines the desired state of Collection</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CollectionSpec Spec { get; set; }

    /// <summary>CollectionStatus defines the observed state of Collection.</summary>
    [JsonPropertyName("status")]
    public V1beta1CollectionStatus? Status { get; set; }
}