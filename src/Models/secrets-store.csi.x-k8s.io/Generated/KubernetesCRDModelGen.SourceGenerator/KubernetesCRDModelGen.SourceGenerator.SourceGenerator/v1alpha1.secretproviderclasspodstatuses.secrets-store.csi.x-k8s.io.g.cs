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
/// <summary>SecretProviderClassPodStatus is the Schema for the secretproviderclassespodstatus API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretProviderClassPodStatusList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretProviderClassPodStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretProviderClassPodStatusList";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasspodstatuses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "secrets-store.csi.x-k8s.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretProviderClassPodStatusList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretProviderClassPodStatus objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretProviderClassPodStatus> Items { get; set; }
}

/// <summary>SecretProviderClassObject defines the object fetched from external secrets store</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1SecretProviderClassPodStatusStatusObjects
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>SecretProviderClassPodStatusStatus defines the observed state of SecretProviderClassPodStatus</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1SecretProviderClassPodStatusStatus
{
    [JsonPropertyName("mounted")]
    public bool? Mounted { get; set; }

    [JsonPropertyName("objects")]
    public IList<V1alpha1SecretProviderClassPodStatusStatusObjects>? Objects { get; set; }

    [JsonPropertyName("podName")]
    public string? PodName { get; set; }

    [JsonPropertyName("secretProviderClassName")]
    public string? SecretProviderClassName { get; set; }

    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }
}

/// <summary>SecretProviderClassPodStatus is the Schema for the secretproviderclassespodstatus API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretProviderClassPodStatus : IKubernetesObject<V1ObjectMeta>, IStatus<V1alpha1SecretProviderClassPodStatusStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretProviderClassPodStatus";
    public const string KubeGroup = "secrets-store.csi.x-k8s.io";
    public const string KubePluralName = "secretproviderclasspodstatuses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "secrets-store.csi.x-k8s.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretProviderClassPodStatus";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretProviderClassPodStatusStatus defines the observed state of SecretProviderClassPodStatus</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretProviderClassPodStatusStatus? Status { get; set; }
}