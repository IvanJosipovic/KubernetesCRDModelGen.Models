#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>
/// TLSStore is the CRD implementation of a Traefik TLS Store.
/// For the time being, only the TLSStore named default is supported.
/// This means that you cannot have two stores that are named default in different Kubernetes namespaces.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#certificates-stores
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TLSStoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TLSStore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TLSStoreList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "tlsstores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TLSStoreList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TLSStore objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TLSStore> Items { get; set; }
}

/// <summary>Certificate holds a secret name for the TLSStore resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSStoreSpecCertificates
{
    /// <summary>SecretName is the name of the referenced Kubernetes Secret to specify the certificate details.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>DefaultCertificate defines the default certificate configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSStoreSpecDefaultCertificate
{
    /// <summary>SecretName is the name of the referenced Kubernetes Secret to specify the certificate details.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }
}

/// <summary>Domain is the domain definition for the DefaultCertificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSStoreSpecDefaultGeneratedCertDomain
{
    /// <summary>Main defines the main domain name.</summary>
    [JsonPropertyName("main")]
    public string? Main { get; set; }

    /// <summary>SANs defines the subject alternative domain names.</summary>
    [JsonPropertyName("sans")]
    public IList<string>? Sans { get; set; }
}

/// <summary>DefaultGeneratedCert defines the default generated certificate configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSStoreSpecDefaultGeneratedCert
{
    /// <summary>Domain is the domain definition for the DefaultCertificate.</summary>
    [JsonPropertyName("domain")]
    public V1alpha1TLSStoreSpecDefaultGeneratedCertDomain? Domain { get; set; }

    /// <summary>Resolver is the name of the resolver that will be used to issue the DefaultCertificate.</summary>
    [JsonPropertyName("resolver")]
    public string? Resolver { get; set; }
}

/// <summary>TLSStoreSpec defines the desired state of a TLSStore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TLSStoreSpec
{
    /// <summary>Certificates is a list of secret names, each secret holding a key/certificate pair to add to the store.</summary>
    [JsonPropertyName("certificates")]
    public IList<V1alpha1TLSStoreSpecCertificates>? Certificates { get; set; }

    /// <summary>DefaultCertificate defines the default certificate configuration.</summary>
    [JsonPropertyName("defaultCertificate")]
    public V1alpha1TLSStoreSpecDefaultCertificate? DefaultCertificate { get; set; }

    /// <summary>DefaultGeneratedCert defines the default generated certificate configuration.</summary>
    [JsonPropertyName("defaultGeneratedCert")]
    public V1alpha1TLSStoreSpecDefaultGeneratedCert? DefaultGeneratedCert { get; set; }
}

/// <summary>
/// TLSStore is the CRD implementation of a Traefik TLS Store.
/// For the time being, only the TLSStore named default is supported.
/// This means that you cannot have two stores that are named default in different Kubernetes namespaces.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/tls/tls-certificates/#certificates-stores#certificates-stores
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TLSStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TLSStoreSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TLSStore";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "tlsstores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TLSStore";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TLSStoreSpec defines the desired state of a TLSStore.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1TLSStoreSpec Spec { get; set; }
}