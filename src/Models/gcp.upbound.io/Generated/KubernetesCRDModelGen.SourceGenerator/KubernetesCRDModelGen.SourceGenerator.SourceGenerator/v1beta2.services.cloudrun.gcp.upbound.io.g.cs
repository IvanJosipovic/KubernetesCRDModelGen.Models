#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudrun.gcp.upbound.io;
/// <summary>Service is the Schema for the Services API. A Cloud Run service has a unique endpoint and autoscales containers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Service>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "cloudrun.gcp.upbound.io";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudrun.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Service objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Service> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecDeletionPolicyEnum>))]
public enum V1beta2ServiceSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderMetadataNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderMetadataNamespaceSelector
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
    public V1beta2ServiceSpecForProviderMetadataNamespaceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Metadata associated with this Service, including name, namespace, labels,
/// and annotations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderMetadata
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field.
    /// Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&apos;s project.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceRef")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceRef? NamespaceRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta2ServiceSpecForProviderMetadataNamespaceSelector? NamespaceSelector { get; set; }
}

/// <summary>
/// Optional metadata for this Revision, including labels and annotations.
/// Name will be generated by the Configuration. To set minimum instances
/// for this revision, use the &quot;autoscaling.knative.dev/minScale&quot; annotation
/// key. To set maximum instances for this revision, use the
/// &quot;autoscaling.knative.dev/maxScale&quot; annotation key. To set Cloud SQL
/// connections for the revision, use the &quot;run.googleapis.com/cloudsql-instances&quot;
/// annotation key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateMetadata
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field.
    /// Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&apos;s project.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector
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
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Selects a key (version) of a secret in Secret Manager.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &apos;latest&apos; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef? NameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector? NameSelector { get; set; }
}

/// <summary>
/// Source for the environment variable&apos;s value. Only supports secret_key_ref.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFrom
{
    /// <summary>
    /// Selects a key (version) of a secret in Secret Manager.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnv
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Source for the environment variable&apos;s value. Only supports secret_key_ref.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("valueFrom")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The ConfigMap to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFrom
{
    /// <summary>
    /// The ConfigMap to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("configMapRef")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>
/// GRPC specifies an action involving a GRPC port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HttpGet specifies the http request to perform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Periodic probe of container liveness. Container will be restarted if the probe fails.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbe
{
    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpc")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>
    /// HttpGet specifies the http request to perform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpGet")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be &quot;TCP&quot;. Defaults to &quot;TCP&quot;.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Compute Resources required by this container. Used to set values such as max memory
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersResources
{
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// The values of the map is string form of the &apos;quantity&apos; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is
    /// explicitly specified, otherwise to an implementation-defined value.
    /// The values of the map is string form of the &apos;quantity&apos; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>
/// GRPC specifies an action involving a GRPC port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HttpGet specifies the http request to perform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// TcpSocket specifies an action involving a TCP port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Startup probe of application within the container.
/// All other probes are disabled if a startup probe is provided, until it
/// succeeds. Container will not be added to service endpoints if the probe fails.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbe
{
    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpc")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>
    /// HttpGet specifies the http request to perform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpGet")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>
    /// TcpSocket specifies an action involving a TCP port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainersVolumeMounts
{
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must
    /// not contain &apos;:&apos;.
    /// </summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecContainers
{
    /// <summary>
    /// Arguments to the entrypoint.
    /// The docker image&apos;s CMD is used if this is not provided.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// Entrypoint array. Not executed within a shell.
    /// The docker image&apos;s ENTRYPOINT is used if this is not provided.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// List of environment variables to set in the container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>
    /// List of sources to populate environment variables in the container.
    /// All invalid keys will be reported as an event when the container is starting.
    /// When a key exists in multiple sources, the value associated with the last source will
    /// take precedence. Values defined by an Env with a duplicate key will take
    /// precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("envFrom")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>
    /// Docker image name. This is most often a reference to a container located
    /// in the container registry, such as gcr.io/cloudrun/hello
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of open ports in the container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>
    /// Compute Resources required by this container. Used to set values such as max memory
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>
    /// Startup probe of application within the container.
    /// All other probes are disabled if a startup probe is provided, until it
    /// succeeds. Container will not be added to service endpoints if the probe fails.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startupProbe")]
    public V1beta2ServiceSpecForProviderTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>
    /// Volume to mount into the container&apos;s filesystem.
    /// Only supports SecretVolumeSources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>
    /// Container&apos;s working directory.
    /// If not specified, the container runtime&apos;s default will be used, which
    /// might be configured in the container image.
    /// </summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>
/// A filesystem specified by the Container Storage Interface (CSI).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesCsi
{
    /// <summary>Unique name representing the type of file system to be created. Cloud Run supports the following values:</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Driver-specific attributes. The following options are supported for available drivers:</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>
/// Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. The default is &quot; &quot; which means to use the node&apos;s default medium. Must be an empty string (default) or Memory.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field&apos;s values are of the &apos;Quantity&apos; k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>
/// A filesystem backed by a Network File System share. This filesystem requires the
/// run.googleapis.com/execution-environment annotation to be unset or set to &quot;gen2&quot;
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesNfs
{
    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>IP address or hostname of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretItems
{
    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &apos;latest&apos; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Mode bits to use on this file, must be a value between 0000 and 0777. If
    /// not specified, the volume defaultMode will be used. This might be in
    /// conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelector
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
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The secret&apos;s value will be presented as the content of a file whose
/// name is defined in the item path. If no items are defined, the name of
/// the file is the secret_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumesSecret
{
    /// <summary>
    /// Mode bits to use on created files by default. Must be a value between 0000
    /// and 0777. Defaults to 0644. Directories within the path are not affected by
    /// this setting. This might be in conflict with other options that affect the
    /// file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>
    /// If unspecified, the volume will expose a file whose name is the
    /// secret_name.
    /// If specified, the key will be used as the version to fetch from Cloud
    /// Secret Manager and the path will be the name of the file exposed in the
    /// volume. When items are defined, they must specify a key and a path.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("items")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. By default, the secret
    /// is assumed to be in the same project.
    /// If the secret is in another project, you must define an alias.
    /// An alias definition has the form:
    /// {alias}:projects/{project-id|project-number}/secrets/{secret-name}.
    /// If multiple alias definitions are needed, they must be separated by
    /// commas.
    /// The alias definitions must be set on the run.googleapis.com/secrets
    /// annotation.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameRef")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameRef? SecretNameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameSelector")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecretSecretNameSelector? SecretNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpecVolumes
{
    /// <summary>
    /// A filesystem specified by the Container Storage Interface (CSI).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("csi")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>
    /// Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("emptyDir")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A filesystem backed by a Network File System share. This filesystem requires the
    /// run.googleapis.com/execution-environment annotation to be unset or set to &quot;gen2&quot;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nfs")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>
    /// The secret&apos;s value will be presented as the content of a file whose
    /// name is defined in the item path. If no items are defined, the name of
    /// the file is the secret_name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secret")]
    public V1beta2ServiceSpecForProviderTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>
/// RevisionSpec holds the desired state of the Revision (from the client).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplateSpec
{
    /// <summary>
    /// ContainerConcurrency specifies the maximum allowed in-flight (concurrent)
    /// requests per container of the Revision. If not specified or 0, defaults to 80 when
    /// requested CPU &gt;= 1 and defaults to 1 when requested CPU &lt; 1.
    /// </summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>
    /// Containers defines the unit of execution for this Revision.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// Node Selector describes the hardware requirements of the resources.
    /// Use the following node selector keys to configure features on a Revision:
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the
    /// service. The service account represents the identity of the running revision,
    /// and determines what permissions the revision has. If not provided, the revision
    /// will use the project&apos;s default service account.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// Volume represents a named volume in a container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2ServiceSpecForProviderTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>
/// template holds the latest specification for the Revision to
/// be stamped out. The template references the container image, and may also
/// include labels and annotations that should be attached to the Revision.
/// To correlate a Revision, and/or to force a Revision to be created when the
/// spec doesn&apos;t otherwise change, a nonce label may be provided in the
/// template metadata. For more details, see:
/// https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions
/// Cloud Run does not currently support referencing a build that is
/// responsible for materializing the container image from source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTemplate
{
    /// <summary>
    /// Optional metadata for this Revision, including labels and annotations.
    /// Name will be generated by the Configuration. To set minimum instances
    /// for this revision, use the &quot;autoscaling.knative.dev/minScale&quot; annotation
    /// key. To set maximum instances for this revision, use the
    /// &quot;autoscaling.knative.dev/maxScale&quot; annotation key. To set Cloud SQL
    /// connections for the revision, use the &quot;run.googleapis.com/cloudsql-instances&quot;
    /// annotation key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1beta2ServiceSpecForProviderTemplateMetadata? Metadata { get; set; }

    /// <summary>
    /// RevisionSpec holds the desired state of the Revision (from the client).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2ServiceSpecForProviderTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTraffic
{
    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProvider
{
    /// <summary>
    /// If set to true, the revision name (template.metadata.name) will be omitted and
    /// autogenerated by Cloud Run. This cannot be set to true while template.metadata.name
    /// is also set.
    /// (For legacy support, if template.metadata.name is unset in state while
    /// this field is set to false, the revision name will still autogenerate.)
    /// </summary>
    [JsonPropertyName("autogenerateRevisionName")]
    public bool? AutogenerateRevisionName { get; set; }

    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// Metadata associated with this Service, including name, namespace, labels,
    /// and annotations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1beta2ServiceSpecForProviderMetadata? Metadata { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// template holds the latest specification for the Revision to
    /// be stamped out. The template references the container image, and may also
    /// include labels and annotations that should be attached to the Revision.
    /// To correlate a Revision, and/or to force a Revision to be created when the
    /// spec doesn&apos;t otherwise change, a nonce label may be provided in the
    /// template metadata. For more details, see:
    /// https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions
    /// Cloud Run does not currently support referencing a build that is
    /// responsible for materializing the container image from source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("template")]
    public V1beta2ServiceSpecForProviderTemplate? Template { get; set; }

    /// <summary>
    /// Traffic specifies how to distribute traffic over a collection of Knative Revisions
    /// and Configurations
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta2ServiceSpecForProviderTraffic>? Traffic { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderMetadataNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderMetadataNamespaceSelector
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
    public V1beta2ServiceSpecInitProviderMetadataNamespaceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Metadata associated with this Service, including name, namespace, labels,
/// and annotations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderMetadata
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field.
    /// Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&apos;s project.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceRef")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceRef? NamespaceRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta2ServiceSpecInitProviderMetadataNamespaceSelector? NamespaceSelector { get; set; }
}

/// <summary>
/// Optional metadata for this Revision, including labels and annotations.
/// Name will be generated by the Configuration. To set minimum instances
/// for this revision, use the &quot;autoscaling.knative.dev/minScale&quot; annotation
/// key. To set maximum instances for this revision, use the
/// &quot;autoscaling.knative.dev/maxScale&quot; annotation key. To set Cloud SQL
/// connections for the revision, use the &quot;run.googleapis.com/cloudsql-instances&quot;
/// annotation key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateMetadata
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field.
    /// Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&apos;s project.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector
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
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Selects a key (version) of a secret in Secret Manager.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &apos;latest&apos; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameRef? NameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRefNameSelector? NameSelector { get; set; }
}

/// <summary>
/// Source for the environment variable&apos;s value. Only supports secret_key_ref.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFrom
{
    /// <summary>
    /// Selects a key (version) of a secret in Secret Manager.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnv
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Source for the environment variable&apos;s value. Only supports secret_key_ref.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("valueFrom")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The ConfigMap to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFrom
{
    /// <summary>
    /// The ConfigMap to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("configMapRef")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>
/// GRPC specifies an action involving a GRPC port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HttpGet specifies the http request to perform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Periodic probe of container liveness. Container will be restarted if the probe fails.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbe
{
    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpc")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>
    /// HttpGet specifies the http request to perform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpGet")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be &quot;TCP&quot;. Defaults to &quot;TCP&quot;.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Compute Resources required by this container. Used to set values such as max memory
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersResources
{
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// The values of the map is string form of the &apos;quantity&apos; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is
    /// explicitly specified, otherwise to an implementation-defined value.
    /// The values of the map is string form of the &apos;quantity&apos; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>
/// GRPC specifies an action involving a GRPC port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HttpGet specifies the http request to perform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// TcpSocket specifies an action involving a TCP port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Startup probe of application within the container.
/// All other probes are disabled if a startup probe is provided, until it
/// succeeds. Container will not be added to service endpoints if the probe fails.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbe
{
    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpc")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>
    /// HttpGet specifies the http request to perform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpGet")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>
    /// TcpSocket specifies an action involving a TCP port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainersVolumeMounts
{
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must
    /// not contain &apos;:&apos;.
    /// </summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecContainers
{
    /// <summary>
    /// Arguments to the entrypoint.
    /// The docker image&apos;s CMD is used if this is not provided.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// Entrypoint array. Not executed within a shell.
    /// The docker image&apos;s ENTRYPOINT is used if this is not provided.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// List of environment variables to set in the container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>
    /// List of sources to populate environment variables in the container.
    /// All invalid keys will be reported as an event when the container is starting.
    /// When a key exists in multiple sources, the value associated with the last source will
    /// take precedence. Values defined by an Env with a duplicate key will take
    /// precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("envFrom")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>
    /// Docker image name. This is most often a reference to a container located
    /// in the container registry, such as gcr.io/cloudrun/hello
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of open ports in the container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>
    /// Compute Resources required by this container. Used to set values such as max memory
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>
    /// Startup probe of application within the container.
    /// All other probes are disabled if a startup probe is provided, until it
    /// succeeds. Container will not be added to service endpoints if the probe fails.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startupProbe")]
    public V1beta2ServiceSpecInitProviderTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>
    /// Volume to mount into the container&apos;s filesystem.
    /// Only supports SecretVolumeSources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>
    /// Container&apos;s working directory.
    /// If not specified, the container runtime&apos;s default will be used, which
    /// might be configured in the container image.
    /// </summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>
/// A filesystem specified by the Container Storage Interface (CSI).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesCsi
{
    /// <summary>Unique name representing the type of file system to be created. Cloud Run supports the following values:</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Driver-specific attributes. The following options are supported for available drivers:</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>
/// Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. The default is &quot; &quot; which means to use the node&apos;s default medium. Must be an empty string (default) or Memory.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field&apos;s values are of the &apos;Quantity&apos; k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>
/// A filesystem backed by a Network File System share. This filesystem requires the
/// run.googleapis.com/execution-environment annotation to be unset or set to &quot;gen2&quot;
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesNfs
{
    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>IP address or hostname of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretItems
{
    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &apos;latest&apos; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Mode bits to use on this file, must be a value between 0000 and 0777. If
    /// not specified, the volume defaultMode will be used. This might be in
    /// conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelector
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
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The secret&apos;s value will be presented as the content of a file whose
/// name is defined in the item path. If no items are defined, the name of
/// the file is the secret_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecret
{
    /// <summary>
    /// Mode bits to use on created files by default. Must be a value between 0000
    /// and 0777. Defaults to 0644. Directories within the path are not affected by
    /// this setting. This might be in conflict with other options that affect the
    /// file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>
    /// If unspecified, the volume will expose a file whose name is the
    /// secret_name.
    /// If specified, the key will be used as the version to fetch from Cloud
    /// Secret Manager and the path will be the name of the file exposed in the
    /// volume. When items are defined, they must specify a key and a path.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("items")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. By default, the secret
    /// is assumed to be in the same project.
    /// If the secret is in another project, you must define an alias.
    /// An alias definition has the form:
    /// {alias}:projects/{project-id|project-number}/secrets/{secret-name}.
    /// If multiple alias definitions are needed, they must be separated by
    /// commas.
    /// The alias definitions must be set on the run.googleapis.com/secrets
    /// annotation.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameRef")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameRef? SecretNameRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secretName.</summary>
    [JsonPropertyName("secretNameSelector")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecretSecretNameSelector? SecretNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpecVolumes
{
    /// <summary>
    /// A filesystem specified by the Container Storage Interface (CSI).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("csi")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>
    /// Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("emptyDir")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A filesystem backed by a Network File System share. This filesystem requires the
    /// run.googleapis.com/execution-environment annotation to be unset or set to &quot;gen2&quot;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nfs")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>
    /// The secret&apos;s value will be presented as the content of a file whose
    /// name is defined in the item path. If no items are defined, the name of
    /// the file is the secret_name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secret")]
    public V1beta2ServiceSpecInitProviderTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>
/// RevisionSpec holds the desired state of the Revision (from the client).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplateSpec
{
    /// <summary>
    /// ContainerConcurrency specifies the maximum allowed in-flight (concurrent)
    /// requests per container of the Revision. If not specified or 0, defaults to 80 when
    /// requested CPU &gt;= 1 and defaults to 1 when requested CPU &lt; 1.
    /// </summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>
    /// Containers defines the unit of execution for this Revision.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// Node Selector describes the hardware requirements of the resources.
    /// Use the following node selector keys to configure features on a Revision:
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the
    /// service. The service account represents the identity of the running revision,
    /// and determines what permissions the revision has. If not provided, the revision
    /// will use the project&apos;s default service account.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// Volume represents a named volume in a container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2ServiceSpecInitProviderTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>
/// template holds the latest specification for the Revision to
/// be stamped out. The template references the container image, and may also
/// include labels and annotations that should be attached to the Revision.
/// To correlate a Revision, and/or to force a Revision to be created when the
/// spec doesn&apos;t otherwise change, a nonce label may be provided in the
/// template metadata. For more details, see:
/// https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions
/// Cloud Run does not currently support referencing a build that is
/// responsible for materializing the container image from source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTemplate
{
    /// <summary>
    /// Optional metadata for this Revision, including labels and annotations.
    /// Name will be generated by the Configuration. To set minimum instances
    /// for this revision, use the &quot;autoscaling.knative.dev/minScale&quot; annotation
    /// key. To set maximum instances for this revision, use the
    /// &quot;autoscaling.knative.dev/maxScale&quot; annotation key. To set Cloud SQL
    /// connections for the revision, use the &quot;run.googleapis.com/cloudsql-instances&quot;
    /// annotation key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1beta2ServiceSpecInitProviderTemplateMetadata? Metadata { get; set; }

    /// <summary>
    /// RevisionSpec holds the desired state of the Revision (from the client).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2ServiceSpecInitProviderTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTraffic
{
    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
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
public partial class V1beta2ServiceSpecInitProvider
{
    /// <summary>
    /// If set to true, the revision name (template.metadata.name) will be omitted and
    /// autogenerated by Cloud Run. This cannot be set to true while template.metadata.name
    /// is also set.
    /// (For legacy support, if template.metadata.name is unset in state while
    /// this field is set to false, the revision name will still autogenerate.)
    /// </summary>
    [JsonPropertyName("autogenerateRevisionName")]
    public bool? AutogenerateRevisionName { get; set; }

    /// <summary>
    /// Metadata associated with this Service, including name, namespace, labels,
    /// and annotations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1beta2ServiceSpecInitProviderMetadata? Metadata { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// template holds the latest specification for the Revision to
    /// be stamped out. The template references the container image, and may also
    /// include labels and annotations that should be attached to the Revision.
    /// To correlate a Revision, and/or to force a Revision to be created when the
    /// spec doesn&apos;t otherwise change, a nonce label may be provided in the
    /// template metadata. For more details, see:
    /// https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions
    /// Cloud Run does not currently support referencing a build that is
    /// responsible for materializing the container image from source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("template")]
    public V1beta2ServiceSpecInitProviderTemplate? Template { get; set; }

    /// <summary>
    /// Traffic specifies how to distribute traffic over a collection of Knative Revisions
    /// and Configurations
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta2ServiceSpecInitProviderTraffic>? Traffic { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecManagementPoliciesEnum>))]
public enum V1beta2ServiceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpec
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
    public V1beta2ServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2ServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Metadata associated with this Service, including name, namespace, labels,
/// and annotations.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderMetadata
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field.
    /// Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// (Output)
    /// A sequence number representing a specific generation of the desired state.
    /// </summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&apos;s project.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// (Output)
    /// An opaque value that represents the internal version of this object that
    /// can be used by clients to determine when objects have changed. May be used
    /// for optimistic concurrency, change detection, and the watch operation on a
    /// resource or set of resources. They may only be valid for a
    /// particular resource or set of resources.
    /// </summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>
    /// (Output)
    /// SelfLink is a URL representing this object.
    /// </summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// (Output)
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// (Output)
    /// UID is a unique id generated by the server on successful creation of a resource and is not
    /// allowed to change on PUT operations.
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderStatusConditions
{
    /// <summary>
    /// (Output)
    /// Human readable message indicating details about the current status.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// (Output)
    /// One-word CamelCase reason for the condition&apos;s current status.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// The current status of the Service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// (Output)
    /// Type of domain mapping condition.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderStatusTraffic
{
    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// (Output)
    /// URL displays the URL for accessing tagged traffic targets. URL is displayed in status,
    /// and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname,
    /// but may not contain anything else (e.g. basic auth, url path, etc.)
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderStatus
{
    /// <summary>
    /// (Output)
    /// Array of observed Service Conditions, indicating the current ready state of the service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ServiceStatusAtProviderStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// (Output)
    /// From ConfigurationStatus. LatestCreatedRevisionName is the last revision that was created
    /// from this Service&apos;s Configuration. It might not be ready yet, for that use
    /// LatestReadyRevisionName.
    /// </summary>
    [JsonPropertyName("latestCreatedRevisionName")]
    public string? LatestCreatedRevisionName { get; set; }

    /// <summary>
    /// (Output)
    /// From ConfigurationStatus. LatestReadyRevisionName holds the name of the latest Revision
    /// stamped out from this Service&apos;s Configuration that has had its &quot;Ready&quot; condition become
    /// &quot;True&quot;.
    /// </summary>
    [JsonPropertyName("latestReadyRevisionName")]
    public string? LatestReadyRevisionName { get; set; }

    /// <summary>
    /// (Output)
    /// ObservedGeneration is the &apos;Generation&apos; of the Route that was last processed by the
    /// controller.
    /// Clients polling for completed reconciliation should poll until observedGeneration =
    /// metadata.generation and the Ready condition&apos;s status is True or False.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public double? ObservedGeneration { get; set; }

    /// <summary>
    /// (Output)
    /// Traffic specifies how to distribute traffic over a collection of Knative Revisions
    /// and Configurations
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta2ServiceStatusAtProviderStatusTraffic>? Traffic { get; set; }

    /// <summary>
    /// (Output)
    /// From RouteStatus. URL holds the url that will distribute traffic over the provided traffic
    /// targets. It generally has the form
    /// https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Optional metadata for this Revision, including labels and annotations.
/// Name will be generated by the Configuration. To set minimum instances
/// for this revision, use the &quot;autoscaling.knative.dev/minScale&quot; annotation
/// key. To set maximum instances for this revision, use the
/// &quot;autoscaling.knative.dev/maxScale&quot; annotation key. To set Cloud SQL
/// connections for the revision, use the &quot;run.googleapis.com/cloudsql-instances&quot;
/// annotation key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateMetadata
{
    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field.
    /// Annotations with run.googleapis.com/ and autoscaling.knative.dev are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// (Output)
    /// A sequence number representing a specific generation of the desired state.
    /// </summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&apos;s project.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// (Output)
    /// An opaque value that represents the internal version of this object that
    /// can be used by clients to determine when objects have changed. May be used
    /// for optimistic concurrency, change detection, and the watch operation on a
    /// resource or set of resources. They may only be valid for a
    /// particular resource or set of resources.
    /// </summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>
    /// (Output)
    /// SelfLink is a URL representing this object.
    /// </summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// (Output)
    /// UID is a unique id generated by the server on successful creation of a resource and is not
    /// allowed to change on PUT operations.
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>
/// Selects a key (version) of a secret in Secret Manager.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvValueFromSecretKeyRef
{
    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &apos;latest&apos; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Source for the environment variable&apos;s value. Only supports secret_key_ref.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvValueFrom
{
    /// <summary>
    /// Selects a key (version) of a secret in Secret Manager.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnv
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Source for the environment variable&apos;s value. Only supports secret_key_ref.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("valueFrom")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvValueFrom? ValueFrom { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The ConfigMap to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRef
{
    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The Secret to select from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRef
{
    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localObjectReference")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRefLocalObjectReference? LocalObjectReference { get; set; }

    /// <summary>Specify whether the Secret must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFrom
{
    /// <summary>
    /// The ConfigMap to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("configMapRef")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The Secret to select from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFromSecretRef? SecretRef { get; set; }
}

/// <summary>
/// GRPC specifies an action involving a GRPC port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbeGrpc
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HttpGet specifies the http request to perform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGet
{
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Periodic probe of container liveness. Container will be restarted if the probe fails.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbe
{
    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpc")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbeGrpc? Grpc { get; set; }

    /// <summary>
    /// HttpGet specifies the http request to perform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpGet")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to &quot;8080&quot;.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol for port. Must be &quot;TCP&quot;. Defaults to &quot;TCP&quot;.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Compute Resources required by this container. Used to set values such as max memory
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersResources
{
    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// The values of the map is string form of the &apos;quantity&apos; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is
    /// explicitly specified, otherwise to an implementation-defined value.
    /// The values of the map is string form of the &apos;quantity&apos; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>
/// GRPC specifies an action involving a GRPC port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeGrpc
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The header field value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HttpGet specifies the http request to perform.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGet
{
    /// <summary>
    /// Custom headers to set in the request. HTTP allows repeated headers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// TcpSocket specifies an action involving a TCP port.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeTcpSocket
{
    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Startup probe of application within the container.
/// All other probes are disabled if a startup probe is provided, until it
/// succeeds. Container will not be added to service endpoints if the probe fails.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbe
{
    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public double? FailureThreshold { get; set; }

    /// <summary>
    /// GRPC specifies an action involving a GRPC port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("grpc")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeGrpc? Grpc { get; set; }

    /// <summary>
    /// HttpGet specifies the http request to perform.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpGet")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public double? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public double? PeriodSeconds { get; set; }

    /// <summary>
    /// TcpSocket specifies an action involving a TCP port.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainersVolumeMounts
{
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must
    /// not contain &apos;:&apos;.
    /// </summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecContainers
{
    /// <summary>
    /// Arguments to the entrypoint.
    /// The docker image&apos;s CMD is used if this is not provided.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// Entrypoint array. Not executed within a shell.
    /// The docker image&apos;s ENTRYPOINT is used if this is not provided.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// List of environment variables to set in the container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainersEnv>? Env { get; set; }

    /// <summary>
    /// List of sources to populate environment variables in the container.
    /// All invalid keys will be reported as an event when the container is starting.
    /// When a key exists in multiple sources, the value associated with the last source will
    /// take precedence. Values defined by an Env with a duplicate key will take
    /// precedence.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("envFrom")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainersEnvFrom>? EnvFrom { get; set; }

    /// <summary>
    /// Docker image name. This is most often a reference to a container located
    /// in the container registry, such as gcr.io/cloudrun/hello
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of open ports in the container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainersPorts>? Ports { get; set; }

    /// <summary>
    /// Compute Resources required by this container. Used to set values such as max memory
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersResources? Resources { get; set; }

    /// <summary>
    /// Startup probe of application within the container.
    /// All other probes are disabled if a startup probe is provided, until it
    /// succeeds. Container will not be added to service endpoints if the probe fails.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("startupProbe")]
    public V1beta2ServiceStatusAtProviderTemplateSpecContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>
    /// Volume to mount into the container&apos;s filesystem.
    /// Only supports SecretVolumeSources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>
    /// Container&apos;s working directory.
    /// If not specified, the container runtime&apos;s default will be used, which
    /// might be configured in the container image.
    /// </summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>
/// A filesystem specified by the Container Storage Interface (CSI).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecVolumesCsi
{
    /// <summary>Unique name representing the type of file system to be created. Cloud Run supports the following values:</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Driver-specific attributes. The following options are supported for available drivers:</summary>
    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>
/// Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. The default is &quot; &quot; which means to use the node&apos;s default medium. Must be an empty string (default) or Memory.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field&apos;s values are of the &apos;Quantity&apos; k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>
/// A filesystem backed by a Network File System share. This filesystem requires the
/// run.googleapis.com/execution-environment annotation to be unset or set to &quot;gen2&quot;
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecVolumesNfs
{
    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, mount the NFS volume as read only in all mounts. Defaults to false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>IP address or hostname of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecVolumesSecretItems
{
    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &apos;latest&apos; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Mode bits to use on this file, must be a value between 0000 and 0777. If
    /// not specified, the volume defaultMode will be used. This might be in
    /// conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("mode")]
    public double? Mode { get; set; }

    /// <summary>Path exported by the NFS server</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// The secret&apos;s value will be presented as the content of a file whose
/// name is defined in the item path. If no items are defined, the name of
/// the file is the secret_name.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecVolumesSecret
{
    /// <summary>
    /// Mode bits to use on created files by default. Must be a value between 0000
    /// and 0777. Defaults to 0644. Directories within the path are not affected by
    /// this setting. This might be in conflict with other options that affect the
    /// file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("defaultMode")]
    public double? DefaultMode { get; set; }

    /// <summary>
    /// If unspecified, the volume will expose a file whose name is the
    /// secret_name.
    /// If specified, the key will be used as the version to fetch from Cloud
    /// Secret Manager and the path will be the name of the file exposed in the
    /// volume. When items are defined, they must specify a key and a path.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("items")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecVolumesSecretItems>? Items { get; set; }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. By default, the secret
    /// is assumed to be in the same project.
    /// If the secret is in another project, you must define an alias.
    /// An alias definition has the form:
    /// {alias}:projects/{project-id|project-number}/secrets/{secret-name}.
    /// If multiple alias definitions are needed, they must be separated by
    /// commas.
    /// The alias definitions must be set on the run.googleapis.com/secrets
    /// annotation.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpecVolumes
{
    /// <summary>
    /// A filesystem specified by the Container Storage Interface (CSI).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("csi")]
    public V1beta2ServiceStatusAtProviderTemplateSpecVolumesCsi? Csi { get; set; }

    /// <summary>
    /// Ephemeral storage which can be backed by real disks (HD, SSD), network storage or memory (i.e. tmpfs). For now only in memory (tmpfs) is supported. It is ephemeral in the sense that when the sandbox is taken down, the data is destroyed with it (it does not persist across sandbox runs).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("emptyDir")]
    public V1beta2ServiceStatusAtProviderTemplateSpecVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A filesystem backed by a Network File System share. This filesystem requires the
    /// run.googleapis.com/execution-environment annotation to be unset or set to &quot;gen2&quot;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nfs")]
    public V1beta2ServiceStatusAtProviderTemplateSpecVolumesNfs? Nfs { get; set; }

    /// <summary>
    /// The secret&apos;s value will be presented as the content of a file whose
    /// name is defined in the item path. If no items are defined, the name of
    /// the file is the secret_name.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secret")]
    public V1beta2ServiceStatusAtProviderTemplateSpecVolumesSecret? Secret { get; set; }
}

/// <summary>
/// RevisionSpec holds the desired state of the Revision (from the client).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplateSpec
{
    /// <summary>
    /// ContainerConcurrency specifies the maximum allowed in-flight (concurrent)
    /// requests per container of the Revision. If not specified or 0, defaults to 80 when
    /// requested CPU &gt;= 1 and defaults to 1 when requested CPU &lt; 1.
    /// </summary>
    [JsonPropertyName("containerConcurrency")]
    public double? ContainerConcurrency { get; set; }

    /// <summary>
    /// Containers defines the unit of execution for this Revision.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// Node Selector describes the hardware requirements of the resources.
    /// Use the following node selector keys to configure features on a Revision:
    /// </summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the
    /// service. The service account represents the identity of the running revision,
    /// and determines what permissions the revision has. If not provided, the revision
    /// will use the project&apos;s default service account.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>
    /// (Output, Deprecated)
    /// ServingState holds a value describing the state the resources
    /// are in for this Revision.
    /// It is expected
    /// that the system will manipulate this based on routability and load.
    /// </summary>
    [JsonPropertyName("servingState")]
    public string? ServingState { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// Volume represents a named volume in a container.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2ServiceStatusAtProviderTemplateSpecVolumes>? Volumes { get; set; }
}

/// <summary>
/// template holds the latest specification for the Revision to
/// be stamped out. The template references the container image, and may also
/// include labels and annotations that should be attached to the Revision.
/// To correlate a Revision, and/or to force a Revision to be created when the
/// spec doesn&apos;t otherwise change, a nonce label may be provided in the
/// template metadata. For more details, see:
/// https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions
/// Cloud Run does not currently support referencing a build that is
/// responsible for materializing the container image from source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTemplate
{
    /// <summary>
    /// Optional metadata for this Revision, including labels and annotations.
    /// Name will be generated by the Configuration. To set minimum instances
    /// for this revision, use the &quot;autoscaling.knative.dev/minScale&quot; annotation
    /// key. To set maximum instances for this revision, use the
    /// &quot;autoscaling.knative.dev/maxScale&quot; annotation key. To set Cloud SQL
    /// connections for the revision, use the &quot;run.googleapis.com/cloudsql-instances&quot;
    /// annotation key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1beta2ServiceStatusAtProviderTemplateMetadata? Metadata { get; set; }

    /// <summary>
    /// RevisionSpec holds the desired state of the Revision (from the client).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2ServiceStatusAtProviderTemplateSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderTraffic
{
    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>Percent specifies percent of the traffic to this Revision or Configuration.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }

    /// <summary>RevisionName of a specific revision to which to send this portion of traffic.</summary>
    [JsonPropertyName("revisionName")]
    public string? RevisionName { get; set; }

    /// <summary>Tag is optionally used to expose a dedicated url for referencing this target exclusively.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// (Output)
    /// URL displays the URL for accessing tagged traffic targets. URL is displayed in status,
    /// and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname,
    /// but may not contain anything else (e.g. basic auth, url path, etc.)
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProvider
{
    /// <summary>
    /// If set to true, the revision name (template.metadata.name) will be omitted and
    /// autogenerated by Cloud Run. This cannot be set to true while template.metadata.name
    /// is also set.
    /// (For legacy support, if template.metadata.name is unset in state while
    /// this field is set to false, the revision name will still autogenerate.)
    /// </summary>
    [JsonPropertyName("autogenerateRevisionName")]
    public bool? AutogenerateRevisionName { get; set; }

    /// <summary>an identifier for the resource with format locations/{{location}}/namespaces/{{project}}/services/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Metadata associated with this Service, including name, namespace, labels,
    /// and annotations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadata")]
    public V1beta2ServiceStatusAtProviderMetadata? Metadata { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The current status of the Service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("status")]
    public IList<V1beta2ServiceStatusAtProviderStatus>? Status { get; set; }

    /// <summary>
    /// template holds the latest specification for the Revision to
    /// be stamped out. The template references the container image, and may also
    /// include labels and annotations that should be attached to the Revision.
    /// To correlate a Revision, and/or to force a Revision to be created when the
    /// spec doesn&apos;t otherwise change, a nonce label may be provided in the
    /// template metadata. For more details, see:
    /// https://github.com/knative/serving/blob/main/docs/client-conventions.md#associate-modifications-with-revisions
    /// Cloud Run does not currently support referencing a build that is
    /// responsible for materializing the container image from source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("template")]
    public V1beta2ServiceStatusAtProviderTemplate? Template { get; set; }

    /// <summary>
    /// Traffic specifies how to distribute traffic over a collection of Knative Revisions
    /// and Configurations
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("traffic")]
    public IList<V1beta2ServiceStatusAtProviderTraffic>? Traffic { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusConditions
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

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. A Cloud Run service has a unique endpoint and autoscales containers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ServiceSpec>, IStatus<V1beta2ServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Service";
    public const string KubeGroup = "cloudrun.gcp.upbound.io";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudrun.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Service";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta2ServiceStatus? Status { get; set; }
}