#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.@operator.tigera.io;
/// <summary>
/// ImageSet is used to specify image digests for the images that the operator deploys.
/// The name of the ImageSet is expected to be in the format `&lt;variant&gt;-&lt;release&gt;`.
/// The `variant` used is `enterprise` if the InstallationSpec Variant is
/// `TigeraSecureEnterprise` otherwise it is `calico`.
/// The `release` must match the version of the variant that the operator is built to deploy,
/// this version can be obtained by passing the `--version` flag to the operator binary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageSetList : IKubernetesObject<V1ListMeta>, IItems<V1ImageSet>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageSetList";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "imagesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ImageSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ImageSet> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageSetSpecImages
{
    /// <summary>
    /// Digest is the image identifier that will be used for the Image.
    /// The field should not include a leading `@` and must be prefixed with `sha256:`.
    /// </summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>
    /// Image is an image that the operator deploys and instead of using the built in tag
    /// the operator will use the Digest for the image identifier.
    /// The value should be the *original* image name without registry or tag or digest.
    /// For the image `docker.io/calico/node:v3.17.1` it should be represented as `calico/node`
    /// The &quot;Installation&quot; spec allows defining custom image registries, paths or prefixes.
    /// Even for custom images such as example.com/custompath/customprefix-calico-node:v3.17.1,
    /// this value should still be `calico/node`.
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }
}

/// <summary>ImageSetSpec defines the desired state of ImageSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageSetSpec
{
    /// <summary>
    /// Images is the list of images to use digests. All images that the operator will deploy
    /// must be specified.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<V1ImageSetSpecImages>? Images { get; set; }
}

/// <summary>
/// ImageSet is used to specify image digests for the images that the operator deploys.
/// The name of the ImageSet is expected to be in the format `&lt;variant&gt;-&lt;release&gt;`.
/// The `variant` used is `enterprise` if the InstallationSpec Variant is
/// `TigeraSecureEnterprise` otherwise it is `calico`.
/// The `release` must match the version of the variant that the operator is built to deploy,
/// this version can be obtained by passing the `--version` flag to the operator binary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1ImageSetSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageSet";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "imagesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageSetSpec defines the desired state of ImageSet.</summary>
    [JsonPropertyName("spec")]
    public V1ImageSetSpec? Spec { get; set; }
}