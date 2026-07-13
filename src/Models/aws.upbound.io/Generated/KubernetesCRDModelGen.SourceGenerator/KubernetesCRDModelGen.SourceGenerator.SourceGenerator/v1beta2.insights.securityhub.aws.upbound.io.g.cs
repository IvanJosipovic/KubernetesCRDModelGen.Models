#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securityhub.aws.upbound.io;
/// <summary>Insight is the Schema for the Insights API. Provides a Security Hub custom insight resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InsightList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Insight>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InsightList";
    public const string KubeGroup = "securityhub.aws.upbound.io";
    public const string KubePluralName = "insights";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securityhub.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InsightList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Insight objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Insight> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InsightSpecDeletionPolicyEnum>))]
public enum V1beta2InsightSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersAwsAccountId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersCompanyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersComplianceStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersCreatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersDescription
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsSeverityOriginal
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFindingProviderFieldsTypes
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFirstObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersFirstObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersFirstObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersGeneratorId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersKeyword
{
    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersLastObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersMalwareName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersMalwarePath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersMalwareState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersMalwareType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkDestinationDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkDestinationIpv4
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkDestinationIpv6
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkDestinationPort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkDirection
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkProtocol
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkSourceDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkSourceIpv4
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkSourceIpv6
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkSourceMac
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNetworkSourcePort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNoteText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNoteUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNoteUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersNoteUpdatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersNoteUpdatedBy
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersProcessLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessParentPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessPath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessTerminatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProcessTerminatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersProcessTerminatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProductFields
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersProductName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersRecommendationText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersRecordState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv4Addresses
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv6Addresses
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceKeyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceSubnetId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceVpcId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyUserName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsS3BucketOwnerId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceAwsS3BucketOwnerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceContainerImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceContainerImageName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceContainerLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceContainerLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersResourceContainerLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceContainerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceDetailsOther
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourcePartition
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceRegion
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceTags
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersResourceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorCategory
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorSource
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorValue
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersTitle
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecForProviderFiltersUpdatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersUserDefinedValues
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersVerificationState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFiltersWorkflowStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProviderFilters
{
    /// <summary>AWS account ID that a finding is generated in. See String_Filter below for more details.</summary>
    [JsonPropertyName("awsAccountId")]
    public IList<V1beta2InsightSpecForProviderFiltersAwsAccountId>? AwsAccountId { get; set; }

    /// <summary>The name of the findings provider (company) that owns the solution (product) that generates findings. See String_Filter below for more details.</summary>
    [JsonPropertyName("companyName")]
    public IList<V1beta2InsightSpecForProviderFiltersCompanyName>? CompanyName { get; set; }

    /// <summary>Exclusive to findings that are generated as the result of a check run against a specific rule in a supported standard, such as CIS AWS Foundations. Contains security standard-related finding details. See String Filter below for more details.</summary>
    [JsonPropertyName("complianceStatus")]
    public IList<V1beta2InsightSpecForProviderFiltersComplianceStatus>? ComplianceStatus { get; set; }

    /// <summary>A finding&apos;s confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("confidence")]
    public IList<V1beta2InsightSpecForProviderFiltersConfidence>? Confidence { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider captured the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("createdAt")]
    public IList<V1beta2InsightSpecForProviderFiltersCreatedAt>? CreatedAt { get; set; }

    /// <summary>The level of importance assigned to the resources associated with the finding. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("criticality")]
    public IList<V1beta2InsightSpecForProviderFiltersCriticality>? Criticality { get; set; }

    /// <summary>A finding&apos;s description. See String Filter below for more details.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta2InsightSpecForProviderFiltersDescription>? Description { get; set; }

    /// <summary>The finding provider value for the finding confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsConfidence")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsConfidence>? FindingProviderFieldsConfidence { get; set; }

    /// <summary>The finding provider value for the level of importance assigned to the resources associated with the findings. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsCriticality")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsCriticality>? FindingProviderFieldsCriticality { get; set; }

    /// <summary>The finding identifier of a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsId")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsId>? FindingProviderFieldsRelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsProductArn")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsRelatedFindingsProductArn>? FindingProviderFieldsRelatedFindingsProductArn { get; set; }

    /// <summary>The finding provider value for the severity label. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityLabel")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsSeverityLabel>? FindingProviderFieldsSeverityLabel { get; set; }

    /// <summary>The finding provider&apos;s original value for the severity. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityOriginal")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsSeverityOriginal>? FindingProviderFieldsSeverityOriginal { get; set; }

    /// <summary>One or more finding types that the finding provider assigned to the finding. Uses the format of namespace/category/classifier that classify a finding. Valid namespace values include: Software and Configuration Checks, TTPs, Effects, Unusual Behaviors, and Sensitive Data Identifications. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsTypes")]
    public IList<V1beta2InsightSpecForProviderFiltersFindingProviderFieldsTypes>? FindingProviderFieldsTypes { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider first observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("firstObservedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersFirstObservedAt>? FirstObservedAt { get; set; }

    /// <summary>The identifier for the solution-specific component (a discrete unit of logic) that generated a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("generatorId")]
    public IList<V1beta2InsightSpecForProviderFiltersGeneratorId>? GeneratorId { get; set; }

    /// <summary>The security findings provider-specific identifier for a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("id")]
    public IList<V1beta2InsightSpecForProviderFiltersId>? Id { get; set; }

    /// <summary>A keyword for a finding. See Keyword Filter below for more details.</summary>
    [JsonPropertyName("keyword")]
    public IList<V1beta2InsightSpecForProviderFiltersKeyword>? Keyword { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider most recently observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("lastObservedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersLastObservedAt>? LastObservedAt { get; set; }

    /// <summary>The name of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareName")]
    public IList<V1beta2InsightSpecForProviderFiltersMalwareName>? MalwareName { get; set; }

    /// <summary>The filesystem path of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwarePath")]
    public IList<V1beta2InsightSpecForProviderFiltersMalwarePath>? MalwarePath { get; set; }

    /// <summary>The state of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareState")]
    public IList<V1beta2InsightSpecForProviderFiltersMalwareState>? MalwareState { get; set; }

    /// <summary>The type of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareType")]
    public IList<V1beta2InsightSpecForProviderFiltersMalwareType>? MalwareType { get; set; }

    /// <summary>The destination domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationDomain")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkDestinationDomain>? NetworkDestinationDomain { get; set; }

    /// <summary>The destination IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv4")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkDestinationIpv4>? NetworkDestinationIpv4 { get; set; }

    /// <summary>The destination IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv6")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkDestinationIpv6>? NetworkDestinationIpv6 { get; set; }

    /// <summary>The destination port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationPort")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkDestinationPort>? NetworkDestinationPort { get; set; }

    /// <summary>Indicates the direction of network traffic associated with a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDirection")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkDirection>? NetworkDirection { get; set; }

    /// <summary>The protocol of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkProtocol")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkProtocol>? NetworkProtocol { get; set; }

    /// <summary>The source domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceDomain")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkSourceDomain>? NetworkSourceDomain { get; set; }

    /// <summary>The source IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv4")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkSourceIpv4>? NetworkSourceIpv4 { get; set; }

    /// <summary>The source IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv6")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkSourceIpv6>? NetworkSourceIpv6 { get; set; }

    /// <summary>The source media access control (MAC) address of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceMac")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkSourceMac>? NetworkSourceMac { get; set; }

    /// <summary>The source port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkSourcePort")]
    public IList<V1beta2InsightSpecForProviderFiltersNetworkSourcePort>? NetworkSourcePort { get; set; }

    /// <summary>The text of a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteText")]
    public IList<V1beta2InsightSpecForProviderFiltersNoteText>? NoteText { get; set; }

    /// <summary>The timestamp of when the note was updated. See Date Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersNoteUpdatedAt>? NoteUpdatedAt { get; set; }

    /// <summary>The principal that created a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedBy")]
    public IList<V1beta2InsightSpecForProviderFiltersNoteUpdatedBy>? NoteUpdatedBy { get; set; }

    /// <summary>The date/time that the process was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("processLaunchedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersProcessLaunchedAt>? ProcessLaunchedAt { get; set; }

    /// <summary>The name of the process. See String Filter below for more details.</summary>
    [JsonPropertyName("processName")]
    public IList<V1beta2InsightSpecForProviderFiltersProcessName>? ProcessName { get; set; }

    /// <summary>The parent process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processParentPid")]
    public IList<V1beta2InsightSpecForProviderFiltersProcessParentPid>? ProcessParentPid { get; set; }

    /// <summary>The path to the process executable. See String Filter below for more details.</summary>
    [JsonPropertyName("processPath")]
    public IList<V1beta2InsightSpecForProviderFiltersProcessPath>? ProcessPath { get; set; }

    /// <summary>The process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processPid")]
    public IList<V1beta2InsightSpecForProviderFiltersProcessPid>? ProcessPid { get; set; }

    /// <summary>The date/time that the process was terminated. See Date Filter below for more details.</summary>
    [JsonPropertyName("processTerminatedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersProcessTerminatedAt>? ProcessTerminatedAt { get; set; }

    /// <summary>The ARN generated by Security Hub that uniquely identifies a third-party company (security findings provider) after this provider&apos;s product (solution that generates findings) is registered with Security Hub. See String Filter below for more details.</summary>
    [JsonPropertyName("productArn")]
    public IList<V1beta2InsightSpecForProviderFiltersProductArn>? ProductArn { get; set; }

    /// <summary>A data type where security-findings providers can include additional solution-specific details that aren&apos;t part of the defined AwsSecurityFinding format. See Map Filter below for more details.</summary>
    [JsonPropertyName("productFields")]
    public IList<V1beta2InsightSpecForProviderFiltersProductFields>? ProductFields { get; set; }

    /// <summary>The name of the solution (product) that generates findings. See String Filter below for more details.</summary>
    [JsonPropertyName("productName")]
    public IList<V1beta2InsightSpecForProviderFiltersProductName>? ProductName { get; set; }

    /// <summary>The recommendation of what to do about the issue described in a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recommendationText")]
    public IList<V1beta2InsightSpecForProviderFiltersRecommendationText>? RecommendationText { get; set; }

    /// <summary>The updated record state for the finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recordState")]
    public IList<V1beta2InsightSpecForProviderFiltersRecordState>? RecordState { get; set; }

    /// <summary>The solution-generated identifier for a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsId")]
    public IList<V1beta2InsightSpecForProviderFiltersRelatedFindingsId>? RelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsProductArn")]
    public IList<V1beta2InsightSpecForProviderFiltersRelatedFindingsProductArn>? RelatedFindingsProductArn { get; set; }

    /// <summary>The IAM profile ARN of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIamInstanceProfileArn")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn>? ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceImageId")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceImageId>? ResourceAwsEc2InstanceImageId { get; set; }

    /// <summary>The IPv4 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv4Addresses")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv4Addresses>? ResourceAwsEc2InstanceIpv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv6Addresses")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceIpv6Addresses>? ResourceAwsEc2InstanceIpv6Addresses { get; set; }

    /// <summary>The key name associated with the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceKeyName")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceKeyName>? ResourceAwsEc2InstanceKeyName { get; set; }

    /// <summary>The date and time the instance was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceLaunchedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceLaunchedAt>? ResourceAwsEc2InstanceLaunchedAt { get; set; }

    /// <summary>The identifier of the subnet that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceSubnetId")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceSubnetId>? ResourceAwsEc2InstanceSubnetId { get; set; }

    /// <summary>The instance type of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceType")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceType>? ResourceAwsEc2InstanceType { get; set; }

    /// <summary>The identifier of the VPC that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceVpcId")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsEc2InstanceVpcId>? ResourceAwsEc2InstanceVpcId { get; set; }

    /// <summary>The creation date/time of the IAM access key related to a finding. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyCreatedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyCreatedAt>? ResourceAwsIamAccessKeyCreatedAt { get; set; }

    /// <summary>The status of the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyStatus")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyStatus>? ResourceAwsIamAccessKeyStatus { get; set; }

    /// <summary>The user associated with the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyUserName")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsIamAccessKeyUserName>? ResourceAwsIamAccessKeyUserName { get; set; }

    /// <summary>The canonical user ID of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerId")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsS3BucketOwnerId>? ResourceAwsS3BucketOwnerId { get; set; }

    /// <summary>The display name of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerName")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceAwsS3BucketOwnerName>? ResourceAwsS3BucketOwnerName { get; set; }

    /// <summary>The identifier of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageId")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceContainerImageId>? ResourceContainerImageId { get; set; }

    /// <summary>The name of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageName")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceContainerImageName>? ResourceContainerImageName { get; set; }

    /// <summary>The date/time that the container was started. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerLaunchedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceContainerLaunchedAt>? ResourceContainerLaunchedAt { get; set; }

    /// <summary>The name of the container related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerName")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceContainerName>? ResourceContainerName { get; set; }

    /// <summary>The details of a resource that doesn&apos;t have a specific subfield for the resource type defined. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceDetailsOther")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceDetailsOther>? ResourceDetailsOther { get; set; }

    /// <summary>The canonical identifier for the given resource type. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceId")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceId>? ResourceId { get; set; }

    /// <summary>The canonical AWS partition name that the Region is assigned to. See String Filter below for more details.</summary>
    [JsonPropertyName("resourcePartition")]
    public IList<V1beta2InsightSpecForProviderFiltersResourcePartition>? ResourcePartition { get; set; }

    /// <summary>The canonical AWS external Region name where this resource is located. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceRegion")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceRegion>? ResourceRegion { get; set; }

    /// <summary>A list of AWS tags associated with a resource at the time the finding was processed. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceTags>? ResourceTags { get; set; }

    /// <summary>Specifies the type of the resource that details are provided for. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceType")]
    public IList<V1beta2InsightSpecForProviderFiltersResourceType>? ResourceType { get; set; }

    /// <summary>The label of a finding&apos;s severity. See String Filter below for more details.</summary>
    [JsonPropertyName("severityLabel")]
    public IList<V1beta2InsightSpecForProviderFiltersSeverityLabel>? SeverityLabel { get; set; }

    /// <summary>A URL that links to a page about the current finding in the security-findings provider&apos;s solution. See String Filter below for more details.</summary>
    [JsonPropertyName("sourceUrl")]
    public IList<V1beta2InsightSpecForProviderFiltersSourceUrl>? SourceUrl { get; set; }

    /// <summary>The category of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorCategory")]
    public IList<V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorCategory>? ThreatIntelIndicatorCategory { get; set; }

    /// <summary>The date/time of the last observation of a threat intelligence indicator. See Date Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorLastObservedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorLastObservedAt>? ThreatIntelIndicatorLastObservedAt { get; set; }

    /// <summary>The source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSource")]
    public IList<V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorSource>? ThreatIntelIndicatorSource { get; set; }

    /// <summary>The URL for more details from the source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSourceUrl")]
    public IList<V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorSourceUrl>? ThreatIntelIndicatorSourceUrl { get; set; }

    /// <summary>The type of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorType")]
    public IList<V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorType>? ThreatIntelIndicatorType { get; set; }

    /// <summary>The value of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorValue")]
    public IList<V1beta2InsightSpecForProviderFiltersThreatIntelIndicatorValue>? ThreatIntelIndicatorValue { get; set; }

    /// <summary>A finding&apos;s title. See String Filter below for more details.</summary>
    [JsonPropertyName("title")]
    public IList<V1beta2InsightSpecForProviderFiltersTitle>? Title { get; set; }

    /// <summary>A finding type in the format of namespace/category/classifier that classifies a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("type")]
    public IList<V1beta2InsightSpecForProviderFiltersType>? Type { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider last updated the finding record. See Date Filter below for more details.</summary>
    [JsonPropertyName("updatedAt")]
    public IList<V1beta2InsightSpecForProviderFiltersUpdatedAt>? UpdatedAt { get; set; }

    /// <summary>A list of name/value string pairs associated with the finding. These are custom, user-defined fields added to a finding. See Map Filter below for more details.</summary>
    [JsonPropertyName("userDefinedValues")]
    public IList<V1beta2InsightSpecForProviderFiltersUserDefinedValues>? UserDefinedValues { get; set; }

    /// <summary>The veracity of a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("verificationState")]
    public IList<V1beta2InsightSpecForProviderFiltersVerificationState>? VerificationState { get; set; }

    /// <summary>The status of the investigation into a finding. See Workflow Status Filter below for more details.</summary>
    [JsonPropertyName("workflowStatus")]
    public IList<V1beta2InsightSpecForProviderFiltersWorkflowStatus>? WorkflowStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecForProvider
{
    /// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
    [JsonPropertyName("filters")]
    public V1beta2InsightSpecForProviderFilters? Filters { get; set; }

    /// <summary>The attribute used to group the findings for the insight e.g., if an insight is grouped by ResourceId, then the insight produces a list of resource identifiers.</summary>
    [JsonPropertyName("groupByAttribute")]
    public string? GroupByAttribute { get; set; }

    /// <summary>The name of the custom insight.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersAwsAccountId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersCompanyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersComplianceStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersCreatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersDescription
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsSeverityOriginal
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsTypes
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFirstObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersFirstObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersFirstObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersGeneratorId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersKeyword
{
    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersLastObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersMalwareName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersMalwarePath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersMalwareState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersMalwareType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkDestinationDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkDestinationIpv4
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkDestinationIpv6
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkDestinationPort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkDirection
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkProtocol
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkSourceDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkSourceIpv4
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkSourceIpv6
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkSourceMac
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNetworkSourcePort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNoteText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNoteUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNoteUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersNoteUpdatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersNoteUpdatedBy
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersProcessLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessParentPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessPath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessTerminatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProcessTerminatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersProcessTerminatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProductFields
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersProductName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersRecommendationText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersRecordState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv4Addresses
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv6Addresses
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceKeyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceSubnetId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceVpcId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyUserName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceContainerImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceContainerImageName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceContainerLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceContainerLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersResourceContainerLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceContainerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceDetailsOther
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourcePartition
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceRegion
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceTags
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersResourceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorCategory
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorSource
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorValue
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersTitle
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightSpecInitProviderFiltersUpdatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersUserDefinedValues
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersVerificationState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFiltersWorkflowStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecInitProviderFilters
{
    /// <summary>AWS account ID that a finding is generated in. See String_Filter below for more details.</summary>
    [JsonPropertyName("awsAccountId")]
    public IList<V1beta2InsightSpecInitProviderFiltersAwsAccountId>? AwsAccountId { get; set; }

    /// <summary>The name of the findings provider (company) that owns the solution (product) that generates findings. See String_Filter below for more details.</summary>
    [JsonPropertyName("companyName")]
    public IList<V1beta2InsightSpecInitProviderFiltersCompanyName>? CompanyName { get; set; }

    /// <summary>Exclusive to findings that are generated as the result of a check run against a specific rule in a supported standard, such as CIS AWS Foundations. Contains security standard-related finding details. See String Filter below for more details.</summary>
    [JsonPropertyName("complianceStatus")]
    public IList<V1beta2InsightSpecInitProviderFiltersComplianceStatus>? ComplianceStatus { get; set; }

    /// <summary>A finding&apos;s confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("confidence")]
    public IList<V1beta2InsightSpecInitProviderFiltersConfidence>? Confidence { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider captured the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("createdAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersCreatedAt>? CreatedAt { get; set; }

    /// <summary>The level of importance assigned to the resources associated with the finding. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("criticality")]
    public IList<V1beta2InsightSpecInitProviderFiltersCriticality>? Criticality { get; set; }

    /// <summary>A finding&apos;s description. See String Filter below for more details.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta2InsightSpecInitProviderFiltersDescription>? Description { get; set; }

    /// <summary>The finding provider value for the finding confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsConfidence")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsConfidence>? FindingProviderFieldsConfidence { get; set; }

    /// <summary>The finding provider value for the level of importance assigned to the resources associated with the findings. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsCriticality")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsCriticality>? FindingProviderFieldsCriticality { get; set; }

    /// <summary>The finding identifier of a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsId")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsId>? FindingProviderFieldsRelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsProductArn")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsRelatedFindingsProductArn>? FindingProviderFieldsRelatedFindingsProductArn { get; set; }

    /// <summary>The finding provider value for the severity label. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityLabel")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsSeverityLabel>? FindingProviderFieldsSeverityLabel { get; set; }

    /// <summary>The finding provider&apos;s original value for the severity. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityOriginal")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsSeverityOriginal>? FindingProviderFieldsSeverityOriginal { get; set; }

    /// <summary>One or more finding types that the finding provider assigned to the finding. Uses the format of namespace/category/classifier that classify a finding. Valid namespace values include: Software and Configuration Checks, TTPs, Effects, Unusual Behaviors, and Sensitive Data Identifications. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsTypes")]
    public IList<V1beta2InsightSpecInitProviderFiltersFindingProviderFieldsTypes>? FindingProviderFieldsTypes { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider first observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("firstObservedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersFirstObservedAt>? FirstObservedAt { get; set; }

    /// <summary>The identifier for the solution-specific component (a discrete unit of logic) that generated a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("generatorId")]
    public IList<V1beta2InsightSpecInitProviderFiltersGeneratorId>? GeneratorId { get; set; }

    /// <summary>The security findings provider-specific identifier for a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("id")]
    public IList<V1beta2InsightSpecInitProviderFiltersId>? Id { get; set; }

    /// <summary>A keyword for a finding. See Keyword Filter below for more details.</summary>
    [JsonPropertyName("keyword")]
    public IList<V1beta2InsightSpecInitProviderFiltersKeyword>? Keyword { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider most recently observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("lastObservedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersLastObservedAt>? LastObservedAt { get; set; }

    /// <summary>The name of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareName")]
    public IList<V1beta2InsightSpecInitProviderFiltersMalwareName>? MalwareName { get; set; }

    /// <summary>The filesystem path of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwarePath")]
    public IList<V1beta2InsightSpecInitProviderFiltersMalwarePath>? MalwarePath { get; set; }

    /// <summary>The state of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareState")]
    public IList<V1beta2InsightSpecInitProviderFiltersMalwareState>? MalwareState { get; set; }

    /// <summary>The type of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareType")]
    public IList<V1beta2InsightSpecInitProviderFiltersMalwareType>? MalwareType { get; set; }

    /// <summary>The destination domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationDomain")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkDestinationDomain>? NetworkDestinationDomain { get; set; }

    /// <summary>The destination IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv4")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkDestinationIpv4>? NetworkDestinationIpv4 { get; set; }

    /// <summary>The destination IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv6")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkDestinationIpv6>? NetworkDestinationIpv6 { get; set; }

    /// <summary>The destination port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationPort")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkDestinationPort>? NetworkDestinationPort { get; set; }

    /// <summary>Indicates the direction of network traffic associated with a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDirection")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkDirection>? NetworkDirection { get; set; }

    /// <summary>The protocol of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkProtocol")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkProtocol>? NetworkProtocol { get; set; }

    /// <summary>The source domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceDomain")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkSourceDomain>? NetworkSourceDomain { get; set; }

    /// <summary>The source IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv4")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkSourceIpv4>? NetworkSourceIpv4 { get; set; }

    /// <summary>The source IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv6")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkSourceIpv6>? NetworkSourceIpv6 { get; set; }

    /// <summary>The source media access control (MAC) address of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceMac")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkSourceMac>? NetworkSourceMac { get; set; }

    /// <summary>The source port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkSourcePort")]
    public IList<V1beta2InsightSpecInitProviderFiltersNetworkSourcePort>? NetworkSourcePort { get; set; }

    /// <summary>The text of a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteText")]
    public IList<V1beta2InsightSpecInitProviderFiltersNoteText>? NoteText { get; set; }

    /// <summary>The timestamp of when the note was updated. See Date Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersNoteUpdatedAt>? NoteUpdatedAt { get; set; }

    /// <summary>The principal that created a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedBy")]
    public IList<V1beta2InsightSpecInitProviderFiltersNoteUpdatedBy>? NoteUpdatedBy { get; set; }

    /// <summary>The date/time that the process was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("processLaunchedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersProcessLaunchedAt>? ProcessLaunchedAt { get; set; }

    /// <summary>The name of the process. See String Filter below for more details.</summary>
    [JsonPropertyName("processName")]
    public IList<V1beta2InsightSpecInitProviderFiltersProcessName>? ProcessName { get; set; }

    /// <summary>The parent process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processParentPid")]
    public IList<V1beta2InsightSpecInitProviderFiltersProcessParentPid>? ProcessParentPid { get; set; }

    /// <summary>The path to the process executable. See String Filter below for more details.</summary>
    [JsonPropertyName("processPath")]
    public IList<V1beta2InsightSpecInitProviderFiltersProcessPath>? ProcessPath { get; set; }

    /// <summary>The process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processPid")]
    public IList<V1beta2InsightSpecInitProviderFiltersProcessPid>? ProcessPid { get; set; }

    /// <summary>The date/time that the process was terminated. See Date Filter below for more details.</summary>
    [JsonPropertyName("processTerminatedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersProcessTerminatedAt>? ProcessTerminatedAt { get; set; }

    /// <summary>The ARN generated by Security Hub that uniquely identifies a third-party company (security findings provider) after this provider&apos;s product (solution that generates findings) is registered with Security Hub. See String Filter below for more details.</summary>
    [JsonPropertyName("productArn")]
    public IList<V1beta2InsightSpecInitProviderFiltersProductArn>? ProductArn { get; set; }

    /// <summary>A data type where security-findings providers can include additional solution-specific details that aren&apos;t part of the defined AwsSecurityFinding format. See Map Filter below for more details.</summary>
    [JsonPropertyName("productFields")]
    public IList<V1beta2InsightSpecInitProviderFiltersProductFields>? ProductFields { get; set; }

    /// <summary>The name of the solution (product) that generates findings. See String Filter below for more details.</summary>
    [JsonPropertyName("productName")]
    public IList<V1beta2InsightSpecInitProviderFiltersProductName>? ProductName { get; set; }

    /// <summary>The recommendation of what to do about the issue described in a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recommendationText")]
    public IList<V1beta2InsightSpecInitProviderFiltersRecommendationText>? RecommendationText { get; set; }

    /// <summary>The updated record state for the finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recordState")]
    public IList<V1beta2InsightSpecInitProviderFiltersRecordState>? RecordState { get; set; }

    /// <summary>The solution-generated identifier for a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsId")]
    public IList<V1beta2InsightSpecInitProviderFiltersRelatedFindingsId>? RelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsProductArn")]
    public IList<V1beta2InsightSpecInitProviderFiltersRelatedFindingsProductArn>? RelatedFindingsProductArn { get; set; }

    /// <summary>The IAM profile ARN of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIamInstanceProfileArn")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn>? ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceImageId")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceImageId>? ResourceAwsEc2InstanceImageId { get; set; }

    /// <summary>The IPv4 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv4Addresses")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv4Addresses>? ResourceAwsEc2InstanceIpv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv6Addresses")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceIpv6Addresses>? ResourceAwsEc2InstanceIpv6Addresses { get; set; }

    /// <summary>The key name associated with the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceKeyName")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceKeyName>? ResourceAwsEc2InstanceKeyName { get; set; }

    /// <summary>The date and time the instance was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceLaunchedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceLaunchedAt>? ResourceAwsEc2InstanceLaunchedAt { get; set; }

    /// <summary>The identifier of the subnet that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceSubnetId")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceSubnetId>? ResourceAwsEc2InstanceSubnetId { get; set; }

    /// <summary>The instance type of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceType")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceType>? ResourceAwsEc2InstanceType { get; set; }

    /// <summary>The identifier of the VPC that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceVpcId")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsEc2InstanceVpcId>? ResourceAwsEc2InstanceVpcId { get; set; }

    /// <summary>The creation date/time of the IAM access key related to a finding. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyCreatedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyCreatedAt>? ResourceAwsIamAccessKeyCreatedAt { get; set; }

    /// <summary>The status of the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyStatus")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyStatus>? ResourceAwsIamAccessKeyStatus { get; set; }

    /// <summary>The user associated with the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyUserName")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsIamAccessKeyUserName>? ResourceAwsIamAccessKeyUserName { get; set; }

    /// <summary>The canonical user ID of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerId")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerId>? ResourceAwsS3BucketOwnerId { get; set; }

    /// <summary>The display name of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerName")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceAwsS3BucketOwnerName>? ResourceAwsS3BucketOwnerName { get; set; }

    /// <summary>The identifier of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageId")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceContainerImageId>? ResourceContainerImageId { get; set; }

    /// <summary>The name of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageName")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceContainerImageName>? ResourceContainerImageName { get; set; }

    /// <summary>The date/time that the container was started. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerLaunchedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceContainerLaunchedAt>? ResourceContainerLaunchedAt { get; set; }

    /// <summary>The name of the container related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerName")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceContainerName>? ResourceContainerName { get; set; }

    /// <summary>The details of a resource that doesn&apos;t have a specific subfield for the resource type defined. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceDetailsOther")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceDetailsOther>? ResourceDetailsOther { get; set; }

    /// <summary>The canonical identifier for the given resource type. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceId")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceId>? ResourceId { get; set; }

    /// <summary>The canonical AWS partition name that the Region is assigned to. See String Filter below for more details.</summary>
    [JsonPropertyName("resourcePartition")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourcePartition>? ResourcePartition { get; set; }

    /// <summary>The canonical AWS external Region name where this resource is located. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceRegion")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceRegion>? ResourceRegion { get; set; }

    /// <summary>A list of AWS tags associated with a resource at the time the finding was processed. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceTags>? ResourceTags { get; set; }

    /// <summary>Specifies the type of the resource that details are provided for. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceType")]
    public IList<V1beta2InsightSpecInitProviderFiltersResourceType>? ResourceType { get; set; }

    /// <summary>The label of a finding&apos;s severity. See String Filter below for more details.</summary>
    [JsonPropertyName("severityLabel")]
    public IList<V1beta2InsightSpecInitProviderFiltersSeverityLabel>? SeverityLabel { get; set; }

    /// <summary>A URL that links to a page about the current finding in the security-findings provider&apos;s solution. See String Filter below for more details.</summary>
    [JsonPropertyName("sourceUrl")]
    public IList<V1beta2InsightSpecInitProviderFiltersSourceUrl>? SourceUrl { get; set; }

    /// <summary>The category of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorCategory")]
    public IList<V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorCategory>? ThreatIntelIndicatorCategory { get; set; }

    /// <summary>The date/time of the last observation of a threat intelligence indicator. See Date Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorLastObservedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorLastObservedAt>? ThreatIntelIndicatorLastObservedAt { get; set; }

    /// <summary>The source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSource")]
    public IList<V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorSource>? ThreatIntelIndicatorSource { get; set; }

    /// <summary>The URL for more details from the source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSourceUrl")]
    public IList<V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorSourceUrl>? ThreatIntelIndicatorSourceUrl { get; set; }

    /// <summary>The type of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorType")]
    public IList<V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorType>? ThreatIntelIndicatorType { get; set; }

    /// <summary>The value of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorValue")]
    public IList<V1beta2InsightSpecInitProviderFiltersThreatIntelIndicatorValue>? ThreatIntelIndicatorValue { get; set; }

    /// <summary>A finding&apos;s title. See String Filter below for more details.</summary>
    [JsonPropertyName("title")]
    public IList<V1beta2InsightSpecInitProviderFiltersTitle>? Title { get; set; }

    /// <summary>A finding type in the format of namespace/category/classifier that classifies a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("type")]
    public IList<V1beta2InsightSpecInitProviderFiltersType>? Type { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider last updated the finding record. See Date Filter below for more details.</summary>
    [JsonPropertyName("updatedAt")]
    public IList<V1beta2InsightSpecInitProviderFiltersUpdatedAt>? UpdatedAt { get; set; }

    /// <summary>A list of name/value string pairs associated with the finding. These are custom, user-defined fields added to a finding. See Map Filter below for more details.</summary>
    [JsonPropertyName("userDefinedValues")]
    public IList<V1beta2InsightSpecInitProviderFiltersUserDefinedValues>? UserDefinedValues { get; set; }

    /// <summary>The veracity of a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("verificationState")]
    public IList<V1beta2InsightSpecInitProviderFiltersVerificationState>? VerificationState { get; set; }

    /// <summary>The status of the investigation into a finding. See Workflow Status Filter below for more details.</summary>
    [JsonPropertyName("workflowStatus")]
    public IList<V1beta2InsightSpecInitProviderFiltersWorkflowStatus>? WorkflowStatus { get; set; }
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
public partial class V1beta2InsightSpecInitProvider
{
    /// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
    [JsonPropertyName("filters")]
    public V1beta2InsightSpecInitProviderFilters? Filters { get; set; }

    /// <summary>The attribute used to group the findings for the insight e.g., if an insight is grouped by ResourceId, then the insight produces a list of resource identifiers.</summary>
    [JsonPropertyName("groupByAttribute")]
    public string? GroupByAttribute { get; set; }

    /// <summary>The name of the custom insight.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InsightSpecManagementPoliciesEnum>))]
public enum V1beta2InsightSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InsightSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InsightSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InsightSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InsightSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InsightSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InsightSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InsightSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InsightSpec defines the desired state of Insight</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightSpec
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
    public V1beta2InsightSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InsightSpecForProvider ForProvider { get; set; }

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
    public V1beta2InsightSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InsightSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InsightSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InsightSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersAwsAccountId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersCompanyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersComplianceStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersCreatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersDescription
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsConfidence
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsCriticality
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsSeverityOriginal
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsTypes
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFirstObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersFirstObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersFirstObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersGeneratorId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersKeyword
{
    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersLastObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersMalwareName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersMalwarePath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersMalwareState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersMalwareType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkDestinationDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkDestinationIpv4
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkDestinationIpv6
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkDestinationPort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkDirection
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkProtocol
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkSourceDomain
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkSourceIpv4
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkSourceIpv6
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkSourceMac
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNetworkSourcePort
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNoteText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNoteUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNoteUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersNoteUpdatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersNoteUpdatedBy
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersProcessLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessParentPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessPath
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessPid
{
    /// <summary>The equal-to condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>The greater-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>The less-than-equal condition to be applied to a single field when querying for findings, provided as a String.</summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessTerminatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProcessTerminatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersProcessTerminatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProductFields
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersProductName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersRecommendationText
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersRecordState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersRelatedFindingsId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersRelatedFindingsProductArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv4Addresses
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv6Addresses
{
    /// <summary>A finding&apos;s CIDR value.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceKeyName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceSubnetId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceVpcId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyUserName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceContainerImageId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceContainerImageName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceContainerLaunchedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceContainerLaunchedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersResourceContainerLaunchedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceContainerName
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceDetailsOther
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceId
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourcePartition
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceRegion
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceTags
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersResourceType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersSeverityLabel
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorCategory
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorSource
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorSourceUrl
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorValue
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersTitle
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersType
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersUpdatedAtDateRange
{
    /// <summary>A date range unit for the date filter. Valid values: DAYS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersUpdatedAt
{
    /// <summary>A configuration block of the date range for the date filter. See date_range below for more details.</summary>
    [JsonPropertyName("dateRange")]
    public V1beta2InsightStatusAtProviderFiltersUpdatedAtDateRange? DateRange { get; set; }

    /// <summary>An end date for the date filter. Required with start if date_range is not specified.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>A start date for the date filter. Required with end if date_range is not specified.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersUserDefinedValues
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The key of the map filter. For example, for ResourceTags, Key identifies the name of the tag. For UserDefinedFields, Key is the name of the field.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersVerificationState
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFiltersWorkflowStatus
{
    /// <summary>The condition to apply to a string value when querying for findings. Valid values include: EQUALS and NOT_EQUALS.</summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>A value for the keyword.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProviderFilters
{
    /// <summary>AWS account ID that a finding is generated in. See String_Filter below for more details.</summary>
    [JsonPropertyName("awsAccountId")]
    public IList<V1beta2InsightStatusAtProviderFiltersAwsAccountId>? AwsAccountId { get; set; }

    /// <summary>The name of the findings provider (company) that owns the solution (product) that generates findings. See String_Filter below for more details.</summary>
    [JsonPropertyName("companyName")]
    public IList<V1beta2InsightStatusAtProviderFiltersCompanyName>? CompanyName { get; set; }

    /// <summary>Exclusive to findings that are generated as the result of a check run against a specific rule in a supported standard, such as CIS AWS Foundations. Contains security standard-related finding details. See String Filter below for more details.</summary>
    [JsonPropertyName("complianceStatus")]
    public IList<V1beta2InsightStatusAtProviderFiltersComplianceStatus>? ComplianceStatus { get; set; }

    /// <summary>A finding&apos;s confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("confidence")]
    public IList<V1beta2InsightStatusAtProviderFiltersConfidence>? Confidence { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider captured the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("createdAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersCreatedAt>? CreatedAt { get; set; }

    /// <summary>The level of importance assigned to the resources associated with the finding. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("criticality")]
    public IList<V1beta2InsightStatusAtProviderFiltersCriticality>? Criticality { get; set; }

    /// <summary>A finding&apos;s description. See String Filter below for more details.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta2InsightStatusAtProviderFiltersDescription>? Description { get; set; }

    /// <summary>The finding provider value for the finding confidence. Confidence is defined as the likelihood that a finding accurately identifies the behavior or issue that it was intended to identify. Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent confidence and 100 means 100 percent confidence. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsConfidence")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsConfidence>? FindingProviderFieldsConfidence { get; set; }

    /// <summary>The finding provider value for the level of importance assigned to the resources associated with the findings. A score of 0 means that the underlying resources have no criticality, and a score of 100 is reserved for the most critical resources. See Number Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsCriticality")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsCriticality>? FindingProviderFieldsCriticality { get; set; }

    /// <summary>The finding identifier of a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsId")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsId>? FindingProviderFieldsRelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding that is identified by the finding provider. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsRelatedFindingsProductArn")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsRelatedFindingsProductArn>? FindingProviderFieldsRelatedFindingsProductArn { get; set; }

    /// <summary>The finding provider value for the severity label. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityLabel")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsSeverityLabel>? FindingProviderFieldsSeverityLabel { get; set; }

    /// <summary>The finding provider&apos;s original value for the severity. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsSeverityOriginal")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsSeverityOriginal>? FindingProviderFieldsSeverityOriginal { get; set; }

    /// <summary>One or more finding types that the finding provider assigned to the finding. Uses the format of namespace/category/classifier that classify a finding. Valid namespace values include: Software and Configuration Checks, TTPs, Effects, Unusual Behaviors, and Sensitive Data Identifications. See String Filter below for more details.</summary>
    [JsonPropertyName("findingProviderFieldsTypes")]
    public IList<V1beta2InsightStatusAtProviderFiltersFindingProviderFieldsTypes>? FindingProviderFieldsTypes { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider first observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("firstObservedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersFirstObservedAt>? FirstObservedAt { get; set; }

    /// <summary>The identifier for the solution-specific component (a discrete unit of logic) that generated a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("generatorId")]
    public IList<V1beta2InsightStatusAtProviderFiltersGeneratorId>? GeneratorId { get; set; }

    /// <summary>The security findings provider-specific identifier for a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("id")]
    public IList<V1beta2InsightStatusAtProviderFiltersId>? Id { get; set; }

    /// <summary>A keyword for a finding. See Keyword Filter below for more details.</summary>
    [JsonPropertyName("keyword")]
    public IList<V1beta2InsightStatusAtProviderFiltersKeyword>? Keyword { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider most recently observed the potential security issue that a finding captured. See Date Filter below for more details.</summary>
    [JsonPropertyName("lastObservedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersLastObservedAt>? LastObservedAt { get; set; }

    /// <summary>The name of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareName")]
    public IList<V1beta2InsightStatusAtProviderFiltersMalwareName>? MalwareName { get; set; }

    /// <summary>The filesystem path of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwarePath")]
    public IList<V1beta2InsightStatusAtProviderFiltersMalwarePath>? MalwarePath { get; set; }

    /// <summary>The state of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareState")]
    public IList<V1beta2InsightStatusAtProviderFiltersMalwareState>? MalwareState { get; set; }

    /// <summary>The type of the malware that was observed. See String Filter below for more details.</summary>
    [JsonPropertyName("malwareType")]
    public IList<V1beta2InsightStatusAtProviderFiltersMalwareType>? MalwareType { get; set; }

    /// <summary>The destination domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationDomain")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkDestinationDomain>? NetworkDestinationDomain { get; set; }

    /// <summary>The destination IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv4")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkDestinationIpv4>? NetworkDestinationIpv4 { get; set; }

    /// <summary>The destination IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationIpv6")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkDestinationIpv6>? NetworkDestinationIpv6 { get; set; }

    /// <summary>The destination port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkDestinationPort")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkDestinationPort>? NetworkDestinationPort { get; set; }

    /// <summary>Indicates the direction of network traffic associated with a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkDirection")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkDirection>? NetworkDirection { get; set; }

    /// <summary>The protocol of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkProtocol")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkProtocol>? NetworkProtocol { get; set; }

    /// <summary>The source domain of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceDomain")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkSourceDomain>? NetworkSourceDomain { get; set; }

    /// <summary>The source IPv4 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv4")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkSourceIpv4>? NetworkSourceIpv4 { get; set; }

    /// <summary>The source IPv6 address of network-related information about a finding. See Ip Filter below for more details.</summary>
    [JsonPropertyName("networkSourceIpv6")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkSourceIpv6>? NetworkSourceIpv6 { get; set; }

    /// <summary>The source media access control (MAC) address of network-related information about a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("networkSourceMac")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkSourceMac>? NetworkSourceMac { get; set; }

    /// <summary>The source port of network-related information about a finding. See Number Filter below for more details.</summary>
    [JsonPropertyName("networkSourcePort")]
    public IList<V1beta2InsightStatusAtProviderFiltersNetworkSourcePort>? NetworkSourcePort { get; set; }

    /// <summary>The text of a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteText")]
    public IList<V1beta2InsightStatusAtProviderFiltersNoteText>? NoteText { get; set; }

    /// <summary>The timestamp of when the note was updated. See Date Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersNoteUpdatedAt>? NoteUpdatedAt { get; set; }

    /// <summary>The principal that created a note. See String Filter below for more details.</summary>
    [JsonPropertyName("noteUpdatedBy")]
    public IList<V1beta2InsightStatusAtProviderFiltersNoteUpdatedBy>? NoteUpdatedBy { get; set; }

    /// <summary>The date/time that the process was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("processLaunchedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersProcessLaunchedAt>? ProcessLaunchedAt { get; set; }

    /// <summary>The name of the process. See String Filter below for more details.</summary>
    [JsonPropertyName("processName")]
    public IList<V1beta2InsightStatusAtProviderFiltersProcessName>? ProcessName { get; set; }

    /// <summary>The parent process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processParentPid")]
    public IList<V1beta2InsightStatusAtProviderFiltersProcessParentPid>? ProcessParentPid { get; set; }

    /// <summary>The path to the process executable. See String Filter below for more details.</summary>
    [JsonPropertyName("processPath")]
    public IList<V1beta2InsightStatusAtProviderFiltersProcessPath>? ProcessPath { get; set; }

    /// <summary>The process ID. See Number Filter below for more details.</summary>
    [JsonPropertyName("processPid")]
    public IList<V1beta2InsightStatusAtProviderFiltersProcessPid>? ProcessPid { get; set; }

    /// <summary>The date/time that the process was terminated. See Date Filter below for more details.</summary>
    [JsonPropertyName("processTerminatedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersProcessTerminatedAt>? ProcessTerminatedAt { get; set; }

    /// <summary>The ARN generated by Security Hub that uniquely identifies a third-party company (security findings provider) after this provider&apos;s product (solution that generates findings) is registered with Security Hub. See String Filter below for more details.</summary>
    [JsonPropertyName("productArn")]
    public IList<V1beta2InsightStatusAtProviderFiltersProductArn>? ProductArn { get; set; }

    /// <summary>A data type where security-findings providers can include additional solution-specific details that aren&apos;t part of the defined AwsSecurityFinding format. See Map Filter below for more details.</summary>
    [JsonPropertyName("productFields")]
    public IList<V1beta2InsightStatusAtProviderFiltersProductFields>? ProductFields { get; set; }

    /// <summary>The name of the solution (product) that generates findings. See String Filter below for more details.</summary>
    [JsonPropertyName("productName")]
    public IList<V1beta2InsightStatusAtProviderFiltersProductName>? ProductName { get; set; }

    /// <summary>The recommendation of what to do about the issue described in a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recommendationText")]
    public IList<V1beta2InsightStatusAtProviderFiltersRecommendationText>? RecommendationText { get; set; }

    /// <summary>The updated record state for the finding. See String Filter below for more details.</summary>
    [JsonPropertyName("recordState")]
    public IList<V1beta2InsightStatusAtProviderFiltersRecordState>? RecordState { get; set; }

    /// <summary>The solution-generated identifier for a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsId")]
    public IList<V1beta2InsightStatusAtProviderFiltersRelatedFindingsId>? RelatedFindingsId { get; set; }

    /// <summary>The ARN of the solution that generated a related finding. See String Filter below for more details.</summary>
    [JsonPropertyName("relatedFindingsProductArn")]
    public IList<V1beta2InsightStatusAtProviderFiltersRelatedFindingsProductArn>? RelatedFindingsProductArn { get; set; }

    /// <summary>The IAM profile ARN of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIamInstanceProfileArn")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceIamInstanceProfileArn>? ResourceAwsEc2InstanceIamInstanceProfileArn { get; set; }

    /// <summary>The Amazon Machine Image (AMI) ID of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceImageId")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceImageId>? ResourceAwsEc2InstanceImageId { get; set; }

    /// <summary>The IPv4 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv4Addresses")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv4Addresses>? ResourceAwsEc2InstanceIpv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with the instance. See Ip Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceIpv6Addresses")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceIpv6Addresses>? ResourceAwsEc2InstanceIpv6Addresses { get; set; }

    /// <summary>The key name associated with the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceKeyName")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceKeyName>? ResourceAwsEc2InstanceKeyName { get; set; }

    /// <summary>The date and time the instance was launched. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceLaunchedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceLaunchedAt>? ResourceAwsEc2InstanceLaunchedAt { get; set; }

    /// <summary>The identifier of the subnet that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceSubnetId")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceSubnetId>? ResourceAwsEc2InstanceSubnetId { get; set; }

    /// <summary>The instance type of the instance. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceType")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceType>? ResourceAwsEc2InstanceType { get; set; }

    /// <summary>The identifier of the VPC that the instance was launched in. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsEc2InstanceVpcId")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsEc2InstanceVpcId>? ResourceAwsEc2InstanceVpcId { get; set; }

    /// <summary>The creation date/time of the IAM access key related to a finding. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyCreatedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyCreatedAt>? ResourceAwsIamAccessKeyCreatedAt { get; set; }

    /// <summary>The status of the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyStatus")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyStatus>? ResourceAwsIamAccessKeyStatus { get; set; }

    /// <summary>The user associated with the IAM access key related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsIamAccessKeyUserName")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsIamAccessKeyUserName>? ResourceAwsIamAccessKeyUserName { get; set; }

    /// <summary>The canonical user ID of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerId")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerId>? ResourceAwsS3BucketOwnerId { get; set; }

    /// <summary>The display name of the owner of the S3 bucket. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceAwsS3BucketOwnerName")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceAwsS3BucketOwnerName>? ResourceAwsS3BucketOwnerName { get; set; }

    /// <summary>The identifier of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageId")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceContainerImageId>? ResourceContainerImageId { get; set; }

    /// <summary>The name of the image related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerImageName")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceContainerImageName>? ResourceContainerImageName { get; set; }

    /// <summary>The date/time that the container was started. See Date Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerLaunchedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceContainerLaunchedAt>? ResourceContainerLaunchedAt { get; set; }

    /// <summary>The name of the container related to a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceContainerName")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceContainerName>? ResourceContainerName { get; set; }

    /// <summary>The details of a resource that doesn&apos;t have a specific subfield for the resource type defined. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceDetailsOther")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceDetailsOther>? ResourceDetailsOther { get; set; }

    /// <summary>The canonical identifier for the given resource type. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceId")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceId>? ResourceId { get; set; }

    /// <summary>The canonical AWS partition name that the Region is assigned to. See String Filter below for more details.</summary>
    [JsonPropertyName("resourcePartition")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourcePartition>? ResourcePartition { get; set; }

    /// <summary>The canonical AWS external Region name where this resource is located. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceRegion")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceRegion>? ResourceRegion { get; set; }

    /// <summary>A list of AWS tags associated with a resource at the time the finding was processed. See Map Filter below for more details.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceTags>? ResourceTags { get; set; }

    /// <summary>Specifies the type of the resource that details are provided for. See String Filter below for more details.</summary>
    [JsonPropertyName("resourceType")]
    public IList<V1beta2InsightStatusAtProviderFiltersResourceType>? ResourceType { get; set; }

    /// <summary>The label of a finding&apos;s severity. See String Filter below for more details.</summary>
    [JsonPropertyName("severityLabel")]
    public IList<V1beta2InsightStatusAtProviderFiltersSeverityLabel>? SeverityLabel { get; set; }

    /// <summary>A URL that links to a page about the current finding in the security-findings provider&apos;s solution. See String Filter below for more details.</summary>
    [JsonPropertyName("sourceUrl")]
    public IList<V1beta2InsightStatusAtProviderFiltersSourceUrl>? SourceUrl { get; set; }

    /// <summary>The category of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorCategory")]
    public IList<V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorCategory>? ThreatIntelIndicatorCategory { get; set; }

    /// <summary>The date/time of the last observation of a threat intelligence indicator. See Date Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorLastObservedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorLastObservedAt>? ThreatIntelIndicatorLastObservedAt { get; set; }

    /// <summary>The source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSource")]
    public IList<V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorSource>? ThreatIntelIndicatorSource { get; set; }

    /// <summary>The URL for more details from the source of the threat intelligence. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorSourceUrl")]
    public IList<V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorSourceUrl>? ThreatIntelIndicatorSourceUrl { get; set; }

    /// <summary>The type of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorType")]
    public IList<V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorType>? ThreatIntelIndicatorType { get; set; }

    /// <summary>The value of a threat intelligence indicator. See String Filter below for more details.</summary>
    [JsonPropertyName("threatIntelIndicatorValue")]
    public IList<V1beta2InsightStatusAtProviderFiltersThreatIntelIndicatorValue>? ThreatIntelIndicatorValue { get; set; }

    /// <summary>A finding&apos;s title. See String Filter below for more details.</summary>
    [JsonPropertyName("title")]
    public IList<V1beta2InsightStatusAtProviderFiltersTitle>? Title { get; set; }

    /// <summary>A finding type in the format of namespace/category/classifier that classifies a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("type")]
    public IList<V1beta2InsightStatusAtProviderFiltersType>? Type { get; set; }

    /// <summary>An ISO8601-formatted timestamp that indicates when the security-findings provider last updated the finding record. See Date Filter below for more details.</summary>
    [JsonPropertyName("updatedAt")]
    public IList<V1beta2InsightStatusAtProviderFiltersUpdatedAt>? UpdatedAt { get; set; }

    /// <summary>A list of name/value string pairs associated with the finding. These are custom, user-defined fields added to a finding. See Map Filter below for more details.</summary>
    [JsonPropertyName("userDefinedValues")]
    public IList<V1beta2InsightStatusAtProviderFiltersUserDefinedValues>? UserDefinedValues { get; set; }

    /// <summary>The veracity of a finding. See String Filter below for more details.</summary>
    [JsonPropertyName("verificationState")]
    public IList<V1beta2InsightStatusAtProviderFiltersVerificationState>? VerificationState { get; set; }

    /// <summary>The status of the investigation into a finding. See Workflow Status Filter below for more details.</summary>
    [JsonPropertyName("workflowStatus")]
    public IList<V1beta2InsightStatusAtProviderFiltersWorkflowStatus>? WorkflowStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusAtProvider
{
    /// <summary>ARN of the insight.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A configuration block including one or more (up to 10 distinct) attributes used to filter the findings included in the insight. The insight only includes findings that match criteria defined in the filters. See filters below for more details.</summary>
    [JsonPropertyName("filters")]
    public V1beta2InsightStatusAtProviderFilters? Filters { get; set; }

    /// <summary>The attribute used to group the findings for the insight e.g., if an insight is grouped by ResourceId, then the insight produces a list of resource identifiers.</summary>
    [JsonPropertyName("groupByAttribute")]
    public string? GroupByAttribute { get; set; }

    /// <summary>ARN of the insight.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the custom insight.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatusConditions
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

/// <summary>InsightStatus defines the observed state of Insight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InsightStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InsightStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InsightStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Insight is the Schema for the Insights API. Provides a Security Hub custom insight resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Insight : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InsightSpec>, IStatus<V1beta2InsightStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Insight";
    public const string KubeGroup = "securityhub.aws.upbound.io";
    public const string KubePluralName = "insights";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securityhub.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Insight";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InsightSpec defines the desired state of Insight</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InsightSpec Spec { get; set; }

    /// <summary>InsightStatus defines the observed state of Insight.</summary>
    [JsonPropertyName("status")]
    public V1beta2InsightStatus? Status { get; set; }
}