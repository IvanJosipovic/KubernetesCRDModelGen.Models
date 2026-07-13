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
/// <summary>ClusterComplianceReport is a specification for the ClusterComplianceReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterComplianceReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterComplianceReport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterComplianceReportList";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clustercompliancereports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aquasecurity.github.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterComplianceReportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ClusterComplianceReport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ClusterComplianceReport> Items { get; set; }
}

/// <summary>SpecCheck represent the scanner who perform the control check</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecComplianceControlsChecks
{
    /// <summary>id define the check id as produced by scanner</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>Commands represent the commands to be executed by the node-collector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecComplianceControlsCommands
{
    /// <summary>id define the commands id</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>define the default value for check status in case resource not found</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterComplianceReportSpecComplianceControlsDefaultStatusEnum>))]
public enum V1alpha1ClusterComplianceReportSpecComplianceControlsDefaultStatusEnum
{
    [EnumMember(Value = "PASS"), JsonStringEnumMemberName("PASS")]
    PASS,
    [EnumMember(Value = "WARN"), JsonStringEnumMemberName("WARN")]
    WARN,
    [EnumMember(Value = "FAIL"), JsonStringEnumMemberName("FAIL")]
    FAIL
}

/// <summary>define the severity of the control</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterComplianceReportSpecComplianceControlsSeverityEnum>))]
public enum V1alpha1ClusterComplianceReportSpecComplianceControlsSeverityEnum
{
    [EnumMember(Value = "CRITICAL"), JsonStringEnumMemberName("CRITICAL")]
    CRITICAL,
    [EnumMember(Value = "HIGH"), JsonStringEnumMemberName("HIGH")]
    HIGH,
    [EnumMember(Value = "MEDIUM"), JsonStringEnumMemberName("MEDIUM")]
    MEDIUM,
    [EnumMember(Value = "LOW"), JsonStringEnumMemberName("LOW")]
    LOW,
    [EnumMember(Value = "UNKNOWN"), JsonStringEnumMemberName("UNKNOWN")]
    UNKNOWN
}

/// <summary>Control represent the cps controls data and mapping checks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecComplianceControls
{
    [JsonPropertyName("checks")]
    public IList<V1alpha1ClusterComplianceReportSpecComplianceControlsChecks>? Checks { get; set; }

    [JsonPropertyName("commands")]
    public IList<V1alpha1ClusterComplianceReportSpecComplianceControlsCommands>? Commands { get; set; }

    /// <summary>define the default value for check status in case resource not found</summary>
    [JsonPropertyName("defaultStatus")]
    public V1alpha1ClusterComplianceReportSpecComplianceControlsDefaultStatusEnum? DefaultStatus { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>id define the control check id</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>define the severity of the control</summary>
    [JsonPropertyName("severity")]
    public required V1alpha1ClusterComplianceReportSpecComplianceControlsSeverityEnum Severity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpecCompliance
{
    /// <summary>Control represent the cps controls data and mapping checks</summary>
    [JsonPropertyName("controls")]
    public required IList<V1alpha1ClusterComplianceReportSpecComplianceControls> Controls { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("platform")]
    public required string Platform { get; set; }

    [JsonPropertyName("relatedResources")]
    public required IList<string> RelatedResources { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterComplianceReportSpecReportTypeEnum>))]
public enum V1alpha1ClusterComplianceReportSpecReportTypeEnum
{
    [EnumMember(Value = "summary"), JsonStringEnumMemberName("summary")]
    Summary,
    [EnumMember(Value = "all"), JsonStringEnumMemberName("all")]
    All
}

/// <summary>ReportSpec represent the compliance specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportSpec
{
    [JsonPropertyName("compliance")]
    public required V1alpha1ClusterComplianceReportSpecCompliance Compliance { get; set; }

    /// <summary>cron define the intervals for report generation</summary>
    [JsonPropertyName("cron")]
    public required string Cron { get; set; }

    [JsonPropertyName("reportType")]
    public required V1alpha1ClusterComplianceReportSpecReportTypeEnum ReportType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportStatusSummary
{
    [JsonPropertyName("failCount")]
    public int? FailCount { get; set; }

    [JsonPropertyName("passCount")]
    public int? PassCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterComplianceReportStatus
{
    /// <summary>ComplianceReport represents a kubernetes scan report</summary>
    [JsonPropertyName("detailReport")]
    public JsonNode? DetailReport { get; set; }

    [JsonPropertyName("summary")]
    public V1alpha1ClusterComplianceReportStatusSummary? Summary { get; set; }

    /// <summary>SummaryReport represents a kubernetes scan report with consolidated findings</summary>
    [JsonPropertyName("summaryReport")]
    public JsonNode? SummaryReport { get; set; }

    [JsonPropertyName("updateTimestamp")]
    public required DateTime UpdateTimestamp { get; set; }
}

/// <summary>ClusterComplianceReport is a specification for the ClusterComplianceReport resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterComplianceReport : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterComplianceReportSpec?>, IStatus<V1alpha1ClusterComplianceReportStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterComplianceReport";
    public const string KubeGroup = "aquasecurity.github.io";
    public const string KubePluralName = "clustercompliancereports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aquasecurity.github.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterComplianceReport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }

    /// <summary>ReportSpec represent the compliance specification</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterComplianceReportSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1ClusterComplianceReportStatus? Status { get; set; }
}