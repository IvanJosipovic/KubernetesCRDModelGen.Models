#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.m.upbound.io;
/// <summary>PimActiveRoleAssignment is the Schema for the PimActiveRoleAssignments API. Manages a PIM Active Role Assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PimActiveRoleAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PimActiveRoleAssignment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PimActiveRoleAssignmentList";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "pimactiveroleassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PimActiveRoleAssignmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PimActiveRoleAssignment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PimActiveRoleAssignment> Items { get; set; }
}

/// <summary>An expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScheduleExpiration
{
    /// <summary>
    /// The duration of the role assignment in days. Changing this forces a new resource to be created.
    /// The duration of the role assignment in days
    /// </summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>
    /// The duration of the role assignment in hours. Changing this forces a new resource to be created.
    /// The duration of the role assignment in hours
    /// </summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>
    /// The end date/time of the role assignment. Changing this forces a new resource to be created.
    /// The end date/time of the role assignment
    /// </summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>
/// A schedule block as defined below. Changing this forces a new resource to be created.
/// The schedule details for this role assignment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderSchedule
{
    /// <summary>An expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>
    /// The start date/time of the role assignment. Changing this forces a new resource to be created.
    /// The start date/time of the role assignment
    /// </summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelector
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
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A ticket block as defined below. Changing this forces a new resource to be created.
/// Ticket details relating to the assignment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProviderTicket
{
    /// <summary>
    /// User-supplied ticket number to be included with the request. Changing this forces a new resource to be created.
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// User-supplied ticket system name to be included with the request. Changing this forces a new resource to be created.
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecForProvider
{
    /// <summary>
    /// The justification for the role assignment. Changing this forces a new resource to be created.
    /// The justification for this role assignment
    /// </summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>
    /// Object ID of the principal for this role assignment. Changing this forces a new resource to be created.
    /// Object ID of the principal for this role assignment
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// The role definition ID for this role assignment. Changing this forces a new resource to be created.
    /// Role definition ID for this role assignment
    /// </summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>
    /// A schedule block as defined below. Changing this forces a new resource to be created.
    /// The schedule details for this role assignment
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>
    /// The scope for this role assignment, should be a valid resource ID. Changing this forces a new resource to be created.
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>
    /// A ticket block as defined below. Changing this forces a new resource to be created.
    /// Ticket details relating to the assignment
    /// </summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimActiveRoleAssignmentSpecForProviderTicket? Ticket { get; set; }
}

/// <summary>An expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScheduleExpiration
{
    /// <summary>
    /// The duration of the role assignment in days. Changing this forces a new resource to be created.
    /// The duration of the role assignment in days
    /// </summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>
    /// The duration of the role assignment in hours. Changing this forces a new resource to be created.
    /// The duration of the role assignment in hours
    /// </summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>
    /// The end date/time of the role assignment. Changing this forces a new resource to be created.
    /// The end date/time of the role assignment
    /// </summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>
/// A schedule block as defined below. Changing this forces a new resource to be created.
/// The schedule details for this role assignment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderSchedule
{
    /// <summary>An expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>
    /// The start date/time of the role assignment. Changing this forces a new resource to be created.
    /// The start date/time of the role assignment
    /// </summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelector
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
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A ticket block as defined below. Changing this forces a new resource to be created.
/// Ticket details relating to the assignment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProviderTicket
{
    /// <summary>
    /// User-supplied ticket number to be included with the request. Changing this forces a new resource to be created.
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// User-supplied ticket system name to be included with the request. Changing this forces a new resource to be created.
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecInitProvider
{
    /// <summary>
    /// The justification for the role assignment. Changing this forces a new resource to be created.
    /// The justification for this role assignment
    /// </summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>
    /// Object ID of the principal for this role assignment. Changing this forces a new resource to be created.
    /// Object ID of the principal for this role assignment
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// The role definition ID for this role assignment. Changing this forces a new resource to be created.
    /// Role definition ID for this role assignment
    /// </summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>
    /// A schedule block as defined below. Changing this forces a new resource to be created.
    /// The schedule details for this role assignment
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>
    /// The scope for this role assignment, should be a valid resource ID. Changing this forces a new resource to be created.
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeRef")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeRef? ScopeRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate scope.</summary>
    [JsonPropertyName("scopeSelector")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderScopeSelector? ScopeSelector { get; set; }

    /// <summary>
    /// A ticket block as defined below. Changing this forces a new resource to be created.
    /// Ticket details relating to the assignment
    /// </summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimActiveRoleAssignmentSpecInitProviderTicket? Ticket { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PimActiveRoleAssignmentSpecManagementPoliciesEnum>))]
public enum V1beta1PimActiveRoleAssignmentSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PimActiveRoleAssignmentSpec defines the desired state of PimActiveRoleAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PimActiveRoleAssignmentSpecForProvider ForProvider { get; set; }

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
    public V1beta1PimActiveRoleAssignmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PimActiveRoleAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PimActiveRoleAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PimActiveRoleAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An expiration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProviderScheduleExpiration
{
    /// <summary>
    /// The duration of the role assignment in days. Changing this forces a new resource to be created.
    /// The duration of the role assignment in days
    /// </summary>
    [JsonPropertyName("durationDays")]
    public double? DurationDays { get; set; }

    /// <summary>
    /// The duration of the role assignment in hours. Changing this forces a new resource to be created.
    /// The duration of the role assignment in hours
    /// </summary>
    [JsonPropertyName("durationHours")]
    public double? DurationHours { get; set; }

    /// <summary>
    /// The end date/time of the role assignment. Changing this forces a new resource to be created.
    /// The end date/time of the role assignment
    /// </summary>
    [JsonPropertyName("endDateTime")]
    public string? EndDateTime { get; set; }
}

/// <summary>
/// A schedule block as defined below. Changing this forces a new resource to be created.
/// The schedule details for this role assignment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProviderSchedule
{
    /// <summary>An expiration block as defined above.</summary>
    [JsonPropertyName("expiration")]
    public V1beta1PimActiveRoleAssignmentStatusAtProviderScheduleExpiration? Expiration { get; set; }

    /// <summary>
    /// The start date/time of the role assignment. Changing this forces a new resource to be created.
    /// The start date/time of the role assignment
    /// </summary>
    [JsonPropertyName("startDateTime")]
    public string? StartDateTime { get; set; }
}

/// <summary>
/// A ticket block as defined below. Changing this forces a new resource to be created.
/// Ticket details relating to the assignment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProviderTicket
{
    /// <summary>
    /// User-supplied ticket number to be included with the request. Changing this forces a new resource to be created.
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// User-supplied ticket system name to be included with the request. Changing this forces a new resource to be created.
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusAtProvider
{
    /// <summary>The ID of the PIM Active Role Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The justification for the role assignment. Changing this forces a new resource to be created.
    /// The justification for this role assignment
    /// </summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>
    /// Object ID of the principal for this role assignment. Changing this forces a new resource to be created.
    /// Object ID of the principal for this role assignment
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// Type of principal to which the role will be assigned.
    /// Type of principal to which the role will be assigned
    /// </summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>
    /// The role definition ID for this role assignment. Changing this forces a new resource to be created.
    /// Role definition ID for this role assignment
    /// </summary>
    [JsonPropertyName("roleDefinitionId")]
    public string? RoleDefinitionId { get; set; }

    /// <summary>
    /// A schedule block as defined below. Changing this forces a new resource to be created.
    /// The schedule details for this role assignment
    /// </summary>
    [JsonPropertyName("schedule")]
    public V1beta1PimActiveRoleAssignmentStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>
    /// The scope for this role assignment, should be a valid resource ID. Changing this forces a new resource to be created.
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// A ticket block as defined below. Changing this forces a new resource to be created.
    /// Ticket details relating to the assignment
    /// </summary>
    [JsonPropertyName("ticket")]
    public V1beta1PimActiveRoleAssignmentStatusAtProviderTicket? Ticket { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatusConditions
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

/// <summary>PimActiveRoleAssignmentStatus defines the observed state of PimActiveRoleAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PimActiveRoleAssignmentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PimActiveRoleAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PimActiveRoleAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PimActiveRoleAssignment is the Schema for the PimActiveRoleAssignments API. Manages a PIM Active Role Assignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PimActiveRoleAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PimActiveRoleAssignmentSpec>, IStatus<V1beta1PimActiveRoleAssignmentStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PimActiveRoleAssignment";
    public const string KubeGroup = "authorization.azure.m.upbound.io";
    public const string KubePluralName = "pimactiveroleassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PimActiveRoleAssignment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PimActiveRoleAssignmentSpec defines the desired state of PimActiveRoleAssignment</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PimActiveRoleAssignmentSpec Spec { get; set; }

    /// <summary>PimActiveRoleAssignmentStatus defines the observed state of PimActiveRoleAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta1PimActiveRoleAssignmentStatus? Status { get; set; }
}