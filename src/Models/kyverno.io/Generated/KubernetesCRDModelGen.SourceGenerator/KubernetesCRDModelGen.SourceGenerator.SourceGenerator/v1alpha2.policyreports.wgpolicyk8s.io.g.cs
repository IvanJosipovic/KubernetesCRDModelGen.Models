#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wgpolicyk8s.io;
/// <summary>PolicyReport is the Schema for the policyreports API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2PolicyReportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha2PolicyReport>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "PolicyReportList";
    public const string KubeGroup = "wgpolicyk8s.io";
    public const string KubePluralName = "policyreports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wgpolicyk8s.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyReportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha2PolicyReport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha2PolicyReport> Items { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportResultsResourceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// SubjectSelector is an optional label selector for checked Kubernetes resources.
/// For example, a policy result may apply to all pods that match a label.
/// Either a Subject or a SubjectSelector can be specified.
/// If neither are provided, the result is assumed to be for the policy report scope.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportResultsResourceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2PolicyReportResultsResourceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportResultsResources
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// If referring to a piece of an object instead of an entire object, this string
    /// should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2].
    /// For example, if the object reference is to a container within a pod, this would take on a value like:
    /// &quot;spec.containers{name}&quot; (where &quot;name&quot; refers to the name of the container that triggered
    /// the event) or if no container name is specified &quot;spec.containers[2]&quot; (container with
    /// index 2 in this pod). This syntax is chosen only to have some well-defined way of
    /// referencing a part of an object.
    /// </summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>
    /// Kind of the referent.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Name of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specific resourceVersion to which this reference is made, if any.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>
    /// UID of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Result indicates the outcome of the policy rule execution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2PolicyReportResultsResultEnum>))]
public enum V1alpha2PolicyReportResultsResultEnum
{
    [EnumMember(Value = "pass"), JsonStringEnumMemberName("pass")]
    Pass,
    [EnumMember(Value = "fail"), JsonStringEnumMemberName("fail")]
    Fail,
    [EnumMember(Value = "warn"), JsonStringEnumMemberName("warn")]
    Warn,
    [EnumMember(Value = "error"), JsonStringEnumMemberName("error")]
    Error,
    [EnumMember(Value = "skip"), JsonStringEnumMemberName("skip")]
    Skip
}

/// <summary>Severity indicates policy check result criticality</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2PolicyReportResultsSeverityEnum>))]
public enum V1alpha2PolicyReportResultsSeverityEnum
{
    [EnumMember(Value = "critical"), JsonStringEnumMemberName("critical")]
    Critical,
    [EnumMember(Value = "high"), JsonStringEnumMemberName("high")]
    High,
    [EnumMember(Value = "low"), JsonStringEnumMemberName("low")]
    Low,
    [EnumMember(Value = "medium"), JsonStringEnumMemberName("medium")]
    Medium,
    [EnumMember(Value = "info"), JsonStringEnumMemberName("info")]
    Info
}

/// <summary>Timestamp indicates the time the result was found</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportResultsTimestamp
{
    /// <summary>
    /// Non-negative fractions of a second at nanosecond resolution. Negative
    /// second values with fractions must still have non-negative nanos values
    /// that count forward in time. Must be from 0 to 999,999,999
    /// inclusive. This field may be limited in precision depending on context.
    /// </summary>
    [JsonPropertyName("nanos")]
    public required int Nanos { get; set; }

    /// <summary>
    /// Represents seconds of UTC time since Unix epoch
    /// 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to
    /// 9999-12-31T23:59:59Z inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public required long Seconds { get; set; }
}

/// <summary>PolicyReportResult provides the result for an individual policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportResults
{
    /// <summary>Category indicates policy category</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Description is a short user friendly message for the policy rule</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Policy is the name or identifier of the policy</summary>
    [JsonPropertyName("policy")]
    public required string Policy { get; set; }

    /// <summary>Properties provides additional information for the policy rule</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// SubjectSelector is an optional label selector for checked Kubernetes resources.
    /// For example, a policy result may apply to all pods that match a label.
    /// Either a Subject or a SubjectSelector can be specified.
    /// If neither are provided, the result is assumed to be for the policy report scope.
    /// </summary>
    [JsonPropertyName("resourceSelector")]
    public V1alpha2PolicyReportResultsResourceSelector? ResourceSelector { get; set; }

    /// <summary>Subjects is an optional reference to the checked Kubernetes resources</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha2PolicyReportResultsResources>? Resources { get; set; }

    /// <summary>Result indicates the outcome of the policy rule execution</summary>
    [JsonPropertyName("result")]
    public V1alpha2PolicyReportResultsResultEnum? Result { get; set; }

    /// <summary>Rule is the name or identifier of the rule within the policy</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }

    /// <summary>Scored indicates if this result is scored</summary>
    [JsonPropertyName("scored")]
    public bool? Scored { get; set; }

    /// <summary>Severity indicates policy check result criticality</summary>
    [JsonPropertyName("severity")]
    public V1alpha2PolicyReportResultsSeverityEnum? Severity { get; set; }

    /// <summary>Source is an identifier for the policy engine that manages this report</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Timestamp indicates the time the result was found</summary>
    [JsonPropertyName("timestamp")]
    public V1alpha2PolicyReportResultsTimestamp? Timestamp { get; set; }
}

/// <summary>Scope is an optional reference to the report scope (e.g. a Deployment, Namespace, or Node)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportScope
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// If referring to a piece of an object instead of an entire object, this string
    /// should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2].
    /// For example, if the object reference is to a container within a pod, this would take on a value like:
    /// &quot;spec.containers{name}&quot; (where &quot;name&quot; refers to the name of the container that triggered
    /// the event) or if no container name is specified &quot;spec.containers[2]&quot; (container with
    /// index 2 in this pod). This syntax is chosen only to have some well-defined way of
    /// referencing a part of an object.
    /// </summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>
    /// Kind of the referent.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Name of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specific resourceVersion to which this reference is made, if any.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>
    /// UID of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportScopeSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// ScopeSelector is an optional selector for multiple scopes (e.g. Pods).
/// Either one of, or none of, but not both of, Scope or ScopeSelector should be specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportScopeSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2PolicyReportScopeSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>PolicyReportSummary provides a summary of results</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2PolicyReportSummary
{
    /// <summary>Error provides the count of policies that could not be evaluated</summary>
    [JsonPropertyName("error")]
    public int? Error { get; set; }

    /// <summary>Fail provides the count of policies whose requirements were not met</summary>
    [JsonPropertyName("fail")]
    public int? Fail { get; set; }

    /// <summary>Pass provides the count of policies whose requirements were met</summary>
    [JsonPropertyName("pass")]
    public int? Pass { get; set; }

    /// <summary>Skip indicates the count of policies that were not selected for evaluation</summary>
    [JsonPropertyName("skip")]
    public int? Skip { get; set; }

    /// <summary>Warn provides the count of non-scored policies whose requirements were not met</summary>
    [JsonPropertyName("warn")]
    public int? Warn { get; set; }
}

/// <summary>PolicyReport is the Schema for the policyreports API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2PolicyReport : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "PolicyReport";
    public const string KubeGroup = "wgpolicyk8s.io";
    public const string KubePluralName = "policyreports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wgpolicyk8s.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyReport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicyReportResult provides result details</summary>
    [JsonPropertyName("results")]
    public IList<V1alpha2PolicyReportResults>? Results { get; set; }

    /// <summary>Scope is an optional reference to the report scope (e.g. a Deployment, Namespace, or Node)</summary>
    [JsonPropertyName("scope")]
    public V1alpha2PolicyReportScope? Scope { get; set; }

    /// <summary>
    /// ScopeSelector is an optional selector for multiple scopes (e.g. Pods).
    /// Either one of, or none of, but not both of, Scope or ScopeSelector should be specified.
    /// </summary>
    [JsonPropertyName("scopeSelector")]
    public V1alpha2PolicyReportScopeSelector? ScopeSelector { get; set; }

    /// <summary>PolicyReportSummary provides a summary of results</summary>
    [JsonPropertyName("summary")]
    public V1alpha2PolicyReportSummary? Summary { get; set; }
}