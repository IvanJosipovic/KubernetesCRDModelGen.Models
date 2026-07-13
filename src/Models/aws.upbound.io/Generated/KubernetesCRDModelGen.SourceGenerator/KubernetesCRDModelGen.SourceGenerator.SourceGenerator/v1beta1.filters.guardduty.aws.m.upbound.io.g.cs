#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.guardduty.aws.m.upbound.io;
/// <summary>Filter is the Schema for the Filters API. Provides a resource to manage a GuardDuty filter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FilterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Filter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FilterList";
    public const string KubeGroup = "guardduty.aws.m.upbound.io";
    public const string KubePluralName = "filters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "guardduty.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FilterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Filter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Filter> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FilterSpecForProviderDetectorIdRefPolicyResolutionEnum>))]
public enum V1beta1FilterSpecForProviderDetectorIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FilterSpecForProviderDetectorIdRefPolicyResolveEnum>))]
public enum V1beta1FilterSpecForProviderDetectorIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FilterSpecForProviderDetectorIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FilterSpecForProviderDetectorIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Detector in guardduty to populate detectorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FilterSpecForProviderDetectorIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FilterSpecForProviderDetectorIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FilterSpecForProviderDetectorIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FilterSpecForProviderDetectorIdSelectorPolicyResolveEnum>))]
public enum V1beta1FilterSpecForProviderDetectorIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FilterSpecForProviderDetectorIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FilterSpecForProviderDetectorIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Detector in guardduty to populate detectorId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderDetectorIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FilterSpecForProviderDetectorIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderFindingCriteriaCriterion
{
    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>The name of the field to be evaluated. The full list of field names can be found in AWS documentation.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThan")]
    public string? GreaterThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThanOrEqual")]
    public string? GreaterThanOrEqual { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThan")]
    public string? LessThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThanOrEqual")]
    public string? LessThanOrEqual { get; set; }

    /// <summary>List of string values to be evaluated as matching conditions.</summary>
    [JsonPropertyName("matches")]
    public IList<string>? Matches { get; set; }

    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>List of string values to be evaluated as non-matching conditions.</summary>
    [JsonPropertyName("notMatches")]
    public IList<string>? NotMatches { get; set; }
}

/// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProviderFindingCriteria
{
    [JsonPropertyName("criterion")]
    public IList<V1beta1FilterSpecForProviderFindingCriteriaCriterion>? Criterion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecForProvider
{
    /// <summary>Specifies the action that is to be applied to the findings that match the filter. Can be one of ARCHIVE or NOOP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the filter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ID of a GuardDuty detector, attached to your account.</summary>
    [JsonPropertyName("detectorId")]
    public string? DetectorId { get; set; }

    /// <summary>Reference to a Detector in guardduty to populate detectorId.</summary>
    [JsonPropertyName("detectorIdRef")]
    public V1beta1FilterSpecForProviderDetectorIdRef? DetectorIdRef { get; set; }

    /// <summary>Selector for a Detector in guardduty to populate detectorId.</summary>
    [JsonPropertyName("detectorIdSelector")]
    public V1beta1FilterSpecForProviderDetectorIdSelector? DetectorIdSelector { get; set; }

    /// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FilterSpecForProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>Specifies the position of the filter in the list of current filters. Also specifies the order in which this filter is applied to the findings.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecInitProviderFindingCriteriaCriterion
{
    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>The name of the field to be evaluated. The full list of field names can be found in AWS documentation.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThan")]
    public string? GreaterThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThanOrEqual")]
    public string? GreaterThanOrEqual { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThan")]
    public string? LessThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThanOrEqual")]
    public string? LessThanOrEqual { get; set; }

    /// <summary>List of string values to be evaluated as matching conditions.</summary>
    [JsonPropertyName("matches")]
    public IList<string>? Matches { get; set; }

    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>List of string values to be evaluated as non-matching conditions.</summary>
    [JsonPropertyName("notMatches")]
    public IList<string>? NotMatches { get; set; }
}

/// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecInitProviderFindingCriteria
{
    [JsonPropertyName("criterion")]
    public IList<V1beta1FilterSpecInitProviderFindingCriteriaCriterion>? Criterion { get; set; }
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
public partial class V1beta1FilterSpecInitProvider
{
    /// <summary>Specifies the action that is to be applied to the findings that match the filter. Can be one of ARCHIVE or NOOP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Description of the filter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FilterSpecInitProviderFindingCriteria? FindingCriteria { get; set; }

    /// <summary>Specifies the position of the filter in the list of current filters. Also specifies the order in which this filter is applied to the findings.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FilterSpecManagementPoliciesEnum>))]
public enum V1beta1FilterSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FilterSpec defines the desired state of Filter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1FilterSpecForProvider ForProvider { get; set; }

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
    public V1beta1FilterSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FilterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FilterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FilterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusAtProviderFindingCriteriaCriterion
{
    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>The name of the field to be evaluated. The full list of field names can be found in AWS documentation.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThan")]
    public string? GreaterThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("greaterThanOrEqual")]
    public string? GreaterThanOrEqual { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThan")]
    public string? LessThan { get; set; }

    /// <summary>A value to be evaluated. Accepts either an integer or a date in RFC 3339 format.</summary>
    [JsonPropertyName("lessThanOrEqual")]
    public string? LessThanOrEqual { get; set; }

    /// <summary>List of string values to be evaluated as matching conditions.</summary>
    [JsonPropertyName("matches")]
    public IList<string>? Matches { get; set; }

    /// <summary>List of string values to be evaluated.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>List of string values to be evaluated as non-matching conditions.</summary>
    [JsonPropertyName("notMatches")]
    public IList<string>? NotMatches { get; set; }
}

/// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusAtProviderFindingCriteria
{
    [JsonPropertyName("criterion")]
    public IList<V1beta1FilterStatusAtProviderFindingCriteriaCriterion>? Criterion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusAtProvider
{
    /// <summary>Specifies the action that is to be applied to the findings that match the filter. Can be one of ARCHIVE or NOOP.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The ARN of the GuardDuty filter.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the filter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ID of a GuardDuty detector, attached to your account.</summary>
    [JsonPropertyName("detectorId")]
    public string? DetectorId { get; set; }

    /// <summary>Represents the criteria to be used in the filter for querying findings. Contains one or more criterion blocks, documented below.</summary>
    [JsonPropertyName("findingCriteria")]
    public V1beta1FilterStatusAtProviderFindingCriteria? FindingCriteria { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the position of the filter in the list of current filters. Also specifies the order in which this filter is applied to the findings.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatusConditions
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

/// <summary>FilterStatus defines the observed state of Filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FilterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1FilterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FilterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Filter is the Schema for the Filters API. Provides a resource to manage a GuardDuty filter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Filter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FilterSpec>, IStatus<V1beta1FilterStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Filter";
    public const string KubeGroup = "guardduty.aws.m.upbound.io";
    public const string KubePluralName = "filters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "guardduty.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Filter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FilterSpec defines the desired state of Filter</summary>
    [JsonPropertyName("spec")]
    public required V1beta1FilterSpec Spec { get; set; }

    /// <summary>FilterStatus defines the observed state of Filter.</summary>
    [JsonPropertyName("status")]
    public V1beta1FilterStatus? Status { get; set; }
}