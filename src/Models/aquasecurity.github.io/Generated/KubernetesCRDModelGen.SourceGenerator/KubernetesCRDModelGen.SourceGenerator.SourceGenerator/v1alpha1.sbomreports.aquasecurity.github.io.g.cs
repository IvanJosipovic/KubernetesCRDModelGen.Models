#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aquasecurity.github.io;
/// <summary>SbomReport summarizes components and dependencies found in container image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SbomReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SbomReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SbomReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "sbomreports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aquasecurity.github.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SbomReportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SbomReport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SbomReport> Items { get; set; }
}

/// <summary>
/// Artifact represents a standalone, executable package of software that includes everything needed to
/// run an application.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportArtifact
{
    /// <summary>Digest is a unique and immutable identifier of an Artifact.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>MimeType represents a type and format of an Artifact.</summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>Repository is the name of the repository in the Artifact registry.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Tag is a mutable, human-readable string used to identify an Artifact.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsHashes
{
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsLicensesLicense
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsLicenses
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("license")]
    public V1alpha1SbomReportReportComponentsComponentsLicensesLicense? License { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsProperties
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsSupplierContact
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponentsSupplier
{
    [JsonPropertyName("contact")]
    public IList<V1alpha1SbomReportReportComponentsComponentsSupplierContact>? Contact { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsComponents
{
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("hashes")]
    public IList<V1alpha1SbomReportReportComponentsComponentsHashes>? Hashes { get; set; }

    [JsonPropertyName("licenses")]
    public IList<V1alpha1SbomReportReportComponentsComponentsLicenses>? Licenses { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public IList<V1alpha1SbomReportReportComponentsComponentsProperties>? Properties { get; set; }

    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    [JsonPropertyName("supplier")]
    public V1alpha1SbomReportReportComponentsComponentsSupplier? Supplier { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsDependencies
{
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    [JsonPropertyName("ref")]
    public string? Ref { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentHashes
{
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentLicensesLicense
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentLicenses
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("license")]
    public V1alpha1SbomReportReportComponentsMetadataComponentLicensesLicense? License { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentProperties
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentSupplierContact
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponentSupplier
{
    [JsonPropertyName("contact")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentSupplierContact>? Contact { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataComponent
{
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("hashes")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentHashes>? Hashes { get; set; }

    [JsonPropertyName("licenses")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentLicenses>? Licenses { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public IList<V1alpha1SbomReportReportComponentsMetadataComponentProperties>? Properties { get; set; }

    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    [JsonPropertyName("supplier")]
    public V1alpha1SbomReportReportComponentsMetadataComponentSupplier? Supplier { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsHashes
{
    [JsonPropertyName("alg")]
    public string? Alg { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicensesLicense
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicenses
{
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("license")]
    public V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicensesLicense? License { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsProperties
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplierContact
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplier
{
    [JsonPropertyName("contact")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplierContact>? Contact { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public IList<string>? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataToolsComponents
{
    [JsonPropertyName("bom-ref")]
    public string? BomRef { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("hashes")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsHashes>? Hashes { get; set; }

    [JsonPropertyName("licenses")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsLicenses>? Licenses { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponentsProperties>? Properties { get; set; }

    [JsonPropertyName("purl")]
    public string? Purl { get; set; }

    [JsonPropertyName("supplier")]
    public V1alpha1SbomReportReportComponentsMetadataToolsComponentsSupplier? Supplier { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadataTools
{
    [JsonPropertyName("components")]
    public IList<V1alpha1SbomReportReportComponentsMetadataToolsComponents>? Components { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponentsMetadata
{
    [JsonPropertyName("component")]
    public V1alpha1SbomReportReportComponentsMetadataComponent? Component { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    [JsonPropertyName("tools")]
    public V1alpha1SbomReportReportComponentsMetadataTools? Tools { get; set; }
}

/// <summary>Bom is artifact bill of materials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportComponents
{
    [JsonPropertyName("bomFormat")]
    public required string BomFormat { get; set; }

    [JsonPropertyName("components")]
    public IList<V1alpha1SbomReportReportComponentsComponents>? Components { get; set; }

    [JsonPropertyName("dependencies")]
    public IList<V1alpha1SbomReportReportComponentsDependencies>? Dependencies { get; set; }

    [JsonPropertyName("metadata")]
    public V1alpha1SbomReportReportComponentsMetadata? Metadata { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("specVersion")]
    public required string SpecVersion { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>Registry is the registry the Artifact was pulled from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportRegistry
{
    /// <summary>Server the FQDN of registry server.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>Scanner is the scanner that generated this report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportScanner
{
    /// <summary>Name the name of the scanner.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Vendor the name of the vendor providing the scanner.</summary>
    [JsonPropertyName("vendor")]
    public required string Vendor { get; set; }

    /// <summary>Version the version of the scanner.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>Summary is a summary of sbom report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReportSummary
{
    /// <summary>ComponentsCount is the number of components in bom.</summary>
    [JsonPropertyName("componentsCount")]
    public required int ComponentsCount { get; set; }

    /// <summary>DependenciesCount is the number of dependencies in bom.</summary>
    [JsonPropertyName("dependenciesCount")]
    public required int DependenciesCount { get; set; }
}

/// <summary>Report is the actual sbom report data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SbomReportReport
{
    /// <summary>
    /// Artifact represents a standalone, executable package of software that includes everything needed to
    /// run an application.
    /// </summary>
    [JsonPropertyName("artifact")]
    public required V1alpha1SbomReportReportArtifact Artifact { get; set; }

    /// <summary>Bom is artifact bill of materials.</summary>
    [JsonPropertyName("components")]
    public required V1alpha1SbomReportReportComponents Components { get; set; }

    /// <summary>Registry is the registry the Artifact was pulled from.</summary>
    [JsonPropertyName("registry")]
    public V1alpha1SbomReportReportRegistry? Registry { get; set; }

    /// <summary>Scanner is the scanner that generated this report.</summary>
    [JsonPropertyName("scanner")]
    public required V1alpha1SbomReportReportScanner Scanner { get; set; }

    /// <summary>Summary is a summary of sbom report.</summary>
    [JsonPropertyName("summary")]
    public required V1alpha1SbomReportReportSummary Summary { get; set; }

    /// <summary>UpdateTimestamp is a timestamp representing the server time in UTC when this report was updated.</summary>
    [JsonPropertyName("updateTimestamp")]
    public required DateTime UpdateTimestamp { get; set; }
}

/// <summary>SbomReport summarizes components and dependencies found in container image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SbomReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SbomReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "sbomreports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aquasecurity.github.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SbomReport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }

    /// <summary>Report is the actual sbom report data.</summary>
    [JsonPropertyName("report")]
    public required V1alpha1SbomReportReport Report { get; set; }
}