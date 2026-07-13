#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.m.upbound.io;
/// <summary>A ClusterProviderConfig configures an Upbound provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterProviderConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterProviderConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterProviderConfigList";
    public const string KubeGroup = "m.upbound.io";
    public const string KubePluralName = "clusterproviderconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterProviderConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ClusterProviderConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ClusterProviderConfig> Items { get; set; }
}

/// <summary>
/// Env is a reference to an environment variable that contains credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigSpecCredentialsEnv
{
    /// <summary>Name is the name of an environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Fs is a reference to a filesystem location that contains credentials that
/// must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigSpecCredentialsFs
{
    /// <summary>Path is a filesystem path.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>
/// A SecretRef is a reference to a secret key that contains the credentials
/// that must be used to connect to the provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigSpecCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Source of the provider credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterProviderConfigSpecCredentialsSourceEnum>))]
public enum V1alpha1ClusterProviderConfigSpecCredentialsSourceEnum
{
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret
}

/// <summary>Credentials required to authenticate to this provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigSpecCredentials
{
    /// <summary>
    /// Env is a reference to an environment variable that contains credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("env")]
    public V1alpha1ClusterProviderConfigSpecCredentialsEnv? Env { get; set; }

    /// <summary>
    /// Fs is a reference to a filesystem location that contains credentials that
    /// must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("fs")]
    public V1alpha1ClusterProviderConfigSpecCredentialsFs? Fs { get; set; }

    /// <summary>
    /// A SecretRef is a reference to a secret key that contains the credentials
    /// that must be used to connect to the provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1ClusterProviderConfigSpecCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the provider credentials.</summary>
    [JsonPropertyName("source")]
    public required V1alpha1ClusterProviderConfigSpecCredentialsSourceEnum Source { get; set; }
}

/// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigSpec
{
    /// <summary>Credentials required to authenticate to this provider.</summary>
    [JsonPropertyName("credentials")]
    public required V1alpha1ClusterProviderConfigSpecCredentials Credentials { get; set; }

    /// <summary>
    /// Upbound endpoint.
    /// Defaults to https://upbound.io
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Upbound Organization.</summary>
    [JsonPropertyName("organization")]
    public required string Organization { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigStatusConditions
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

/// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterProviderConfigStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterProviderConfigStatusConditions>? Conditions { get; set; }

    /// <summary>Users of this provider configuration.</summary>
    [JsonPropertyName("users")]
    public long? Users { get; set; }
}

/// <summary>A ClusterProviderConfig configures an Upbound provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterProviderConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterProviderConfigSpec>, IStatus<V1alpha1ClusterProviderConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterProviderConfig";
    public const string KubeGroup = "m.upbound.io";
    public const string KubePluralName = "clusterproviderconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterProviderConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ProviderConfigSpec defines the desired state of a ProviderConfig.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ClusterProviderConfigSpec Spec { get; set; }

    /// <summary>A ProviderConfigStatus reflects the observed state of a ProviderConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterProviderConfigStatus? Status { get; set; }
}