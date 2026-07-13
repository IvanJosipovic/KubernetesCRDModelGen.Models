#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretsstore.csi.xk8s.io;
/// <summary>SecretProviderClass is the Schema for the secretproviderclasses API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretProviderClassList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretProviderClass>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretProviderClassList";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "secrets-store.csi.x-k8s.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretProviderClassList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretProviderClass objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretProviderClass> Items { get; set; }
}

/// <summary>SecretObjectData defines the desired state of synced K8s secret object data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
public partial class V1alpha1SecretProviderClassSpecSecretObjectsData
{
    /// <summary>data field to populate</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name of the object to sync</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>SecretObject defines the desired state of synced K8s secret objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
public partial class V1alpha1SecretProviderClassSpecSecretObjects
{
    /// <summary>annotations of k8s secret object</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("data")]
    public IList<V1alpha1SecretProviderClassSpecSecretObjectsData>? Data { get; set; }

    /// <summary>labels of K8s secret object</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>name of the K8s secret object</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>type of K8s secret object</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SecretProviderClassSpec defines the desired state of SecretProviderClass</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
public partial class V1alpha1SecretProviderClassSpec
{
    /// <summary>Configuration for specific provider</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration for provider name</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("secretObjects")]
    public IList<V1alpha1SecretProviderClassSpecSecretObjects>? SecretObjects { get; set; }
}

/// <summary>
/// ByPodStatus defines the state of SecretProviderClass as seen by
/// an individual controller
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
public partial class V1alpha1SecretProviderClassStatusByPod
{
    /// <summary>id of the pod that wrote the status</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>namespace of the pod that wrote the status</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SecretProviderClassStatus defines the observed state of SecretProviderClass</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
public partial class V1alpha1SecretProviderClassStatus
{
    [JsonPropertyName("byPod")]
    public IList<V1alpha1SecretProviderClassStatusByPod>? ByPod { get; set; }
}

/// <summary>SecretProviderClass is the Schema for the secretproviderclasses API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("secrets-store.csi.x-k8s.io/v1alpha1 is deprecated. Use secrets-store.csi.x-k8s.io/v1 instead.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretProviderClass : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretProviderClassSpec?>, IStatus<V1alpha1SecretProviderClassStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretProviderClass";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "secrets-store.csi.x-k8s.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretProviderClass";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretProviderClassSpec defines the desired state of SecretProviderClass</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SecretProviderClassSpec? Spec { get; set; }

    /// <summary>SecretProviderClassStatus defines the observed state of SecretProviderClass</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretProviderClassStatus? Status { get; set; }
}