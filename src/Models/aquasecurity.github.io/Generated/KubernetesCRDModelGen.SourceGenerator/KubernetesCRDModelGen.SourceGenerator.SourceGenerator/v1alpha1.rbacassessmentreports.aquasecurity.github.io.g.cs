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
/// <summary>RbacAssessmentReport is a specification for the RbacAssessmentReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RbacAssessmentReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RbacAssessmentReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RbacAssessmentReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "rbacassessmentreports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aquasecurity.github.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RbacAssessmentReportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RbacAssessmentReport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RbacAssessmentReport> Items { get; set; }
}

/// <summary>Scope indicates the section of config that was audited.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RbacAssessmentReportReportChecksScope
{
    /// <summary>Type indicates type of this scope, e.g. Container, ConfigMapKey or JSONPath.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>Value indicates value of this scope that depends on Type, e.g. container name, ConfigMap key or JSONPath expression</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Check provides the result of conducting a single audit step.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RbacAssessmentReportReportChecks
{
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("checkID")]
    public required string CheckID { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("messages")]
    public IList<string>? Messages { get; set; }

    /// <summary>Remediation provides description or links to external resources to remediate failing check.</summary>
    [JsonPropertyName("remediation")]
    public string? Remediation { get; set; }

    /// <summary>Scope indicates the section of config that was audited.</summary>
    [JsonPropertyName("scope")]
    public V1alpha1RbacAssessmentReportReportChecksScope? Scope { get; set; }

    /// <summary>Severity level of a vulnerability or a configuration audit check.</summary>
    [JsonPropertyName("severity")]
    public required string Severity { get; set; }

    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Scanner is the spec for a scanner generating a security assessment report.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RbacAssessmentReportReportScanner
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

/// <summary>RbacAssessmentSummary counts failed checks by severity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RbacAssessmentReportReportSummary
{
    /// <summary>CriticalCount is the number of failed checks with critical severity.</summary>
    [JsonPropertyName("criticalCount")]
    public required int CriticalCount { get; set; }

    /// <summary>HighCount is the number of failed checks with high severity.</summary>
    [JsonPropertyName("highCount")]
    public required int HighCount { get; set; }

    /// <summary>LowCount is the number of failed check with low severity.</summary>
    [JsonPropertyName("lowCount")]
    public required int LowCount { get; set; }

    /// <summary>MediumCount is the number of failed checks with medium severity.</summary>
    [JsonPropertyName("mediumCount")]
    public required int MediumCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RbacAssessmentReportReport
{
    /// <summary>Checks provides results of conducting audit steps.</summary>
    [JsonPropertyName("checks")]
    public required IList<V1alpha1RbacAssessmentReportReportChecks> Checks { get; set; }

    /// <summary>Scanner is the spec for a scanner generating a security assessment report.</summary>
    [JsonPropertyName("scanner")]
    public required V1alpha1RbacAssessmentReportReportScanner Scanner { get; set; }

    /// <summary>RbacAssessmentSummary counts failed checks by severity.</summary>
    [JsonPropertyName("summary")]
    public required V1alpha1RbacAssessmentReportReportSummary Summary { get; set; }
}

/// <summary>RbacAssessmentReport is a specification for the RbacAssessmentReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RbacAssessmentReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RbacAssessmentReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "rbacassessmentreports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aquasecurity.github.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RbacAssessmentReport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }

    [JsonPropertyName("report")]
    public required V1alpha1RbacAssessmentReportReport Report { get; set; }
}