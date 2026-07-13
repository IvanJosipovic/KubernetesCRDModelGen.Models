#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>ClusterImageCatalog is the Schema for the clusterimagecatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterImageCatalogList : IKubernetesObject<V1ListMeta>, IItems<V1ClusterImageCatalog>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterImageCatalogList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "clusterimagecatalogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterImageCatalogList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ClusterImageCatalog objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ClusterImageCatalog> Items { get; set; }
}

/// <summary>CatalogComponentImage is a named image entry for a non-PostgreSQL component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpecComponentImages
{
    /// <summary>Image is the container image reference.</summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }

    /// <summary>Key is the unique identifier for this image within the catalog.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>
/// ExtensionEnvVar defines an environment variable for a specific extension
/// image volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpecImagesExtensionsEnv
{
    /// <summary>
    /// Name of the environment variable to be injected into the
    /// PostgreSQL process.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value of the environment variable. CloudNativePG performs a direct
    /// replacement of this value, with support for placeholder expansion.
    /// The ${`image_root`} placeholder resolves to the absolute mount path
    /// of the extension&apos;s volume (e.g., `/extensions/my-extension`). This
    /// is particularly useful for allowing applications or libraries to
    /// locate specific directories within the mounted image.
    /// Unrecognized placeholders are rejected. To include a literal ${...}
    /// in the value, escape it as $${...}.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>The image containing the extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpecImagesExtensionsImage
{
    /// <summary>
    /// Policy for pulling OCI objects. Possible values are:
    /// Always: the kubelet always attempts to pull the reference. Container creation will fail If the pull fails.
    /// Never: the kubelet never pulls the reference and only uses a local image or artifact. Container creation will fail if the reference isn&apos;t present.
    /// IfNotPresent: the kubelet pulls if the reference isn&apos;t already present on disk. Container creation will fail if the reference isn&apos;t present and the pull fails.
    /// Defaults to Always if :latest tag is specified, or IfNotPresent otherwise.
    /// </summary>
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    /// <summary>
    /// Required: Image or artifact reference to be used.
    /// Behaves in the same way as pod.spec.containers[*].image.
    /// Pull secrets will be assembled in the same way as for the container image by looking up node credentials, SA image pull secrets, and pod spec image pull secrets.
    /// More info: https://kubernetes.io/docs/concepts/containers/images
    /// This field is optional to allow higher level config management to default or override
    /// container images in workload controllers like Deployments and StatefulSets.
    /// </summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

/// <summary>
/// ExtensionConfiguration is the configuration used to add
/// PostgreSQL extensions to the Cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpecImagesExtensions
{
    /// <summary>
    /// A list of directories within the image to be appended to the
    /// PostgreSQL process&apos;s `PATH` environment variable.
    /// </summary>
    [JsonPropertyName("bin_path")]
    public IList<string>? BinPath { get; set; }

    /// <summary>
    /// The list of directories inside the image which should be added to dynamic_library_path.
    /// If not defined, defaults to &quot;/lib&quot;.
    /// </summary>
    [JsonPropertyName("dynamic_library_path")]
    public IList<string>? DynamicLibraryPath { get; set; }

    /// <summary>
    /// Env is a list of custom environment variables to be set in the
    /// PostgreSQL process for this extension. It is the responsibility of the
    /// cluster administrator to ensure the variables are correct for the
    /// specific extension. Note that changes to these variables require
    /// a manual cluster restart to take effect.
    /// </summary>
    [JsonPropertyName("env")]
    public IList<V1ClusterImageCatalogSpecImagesExtensionsEnv>? Env { get; set; }

    /// <summary>
    /// The list of directories inside the image which should be added to extension_control_path.
    /// If not defined, defaults to &quot;/share&quot;.
    /// </summary>
    [JsonPropertyName("extension_control_path")]
    public IList<string>? ExtensionControlPath { get; set; }

    /// <summary>The image containing the extension.</summary>
    [JsonPropertyName("image")]
    public V1ClusterImageCatalogSpecImagesExtensionsImage? Image { get; set; }

    /// <summary>The list of directories inside the image which should be added to ld_library_path.</summary>
    [JsonPropertyName("ld_library_path")]
    public IList<string>? LdLibraryPath { get; set; }

    /// <summary>
    /// The name of the extension, required. The limit of 59 characters
    /// leaves room for the prefix the operator adds when deriving the
    /// extension&apos;s Kubernetes Volume name (capped at 63 characters).
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CatalogImage defines the image and major version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpecImages
{
    /// <summary>The configuration of the extensions to be added</summary>
    [JsonPropertyName("extensions")]
    public IList<V1ClusterImageCatalogSpecImagesExtensions>? Extensions { get; set; }

    /// <summary>The image reference</summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }

    /// <summary>The PostgreSQL major version of the image. Must be unique within the catalog.</summary>
    [JsonPropertyName("major")]
    public required int Major { get; set; }
}

/// <summary>
/// Specification of the desired behavior of the ClusterImageCatalog.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterImageCatalogSpec
{
    /// <summary>
    /// ComponentImages is a list of named images for components other than PostgreSQL
    /// (e.g. pgbouncer). Keys must be unique within a catalog.
    /// </summary>
    [JsonPropertyName("componentImages")]
    public IList<V1ClusterImageCatalogSpecComponentImages>? ComponentImages { get; set; }

    /// <summary>List of CatalogImages available in the catalog</summary>
    [JsonPropertyName("images")]
    public required IList<V1ClusterImageCatalogSpecImages> Images { get; set; }
}

/// <summary>ClusterImageCatalog is the Schema for the clusterimagecatalogs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterImageCatalog : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterImageCatalogSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterImageCatalog";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "clusterimagecatalogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterImageCatalog";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired behavior of the ClusterImageCatalog.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1ClusterImageCatalogSpec Spec { get; set; }
}