#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identitygovernance.azuread.m.upbound.io;
/// <summary>AccessPackageAssignmentPolicy is the Schema for the AccessPackageAssignmentPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessPackageAssignmentPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccessPackageAssignmentPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessPackageAssignmentPolicyList";
    public const string KubeGroup = "identitygovernance.azuread.m.upbound.io";
    public const string KubePluralName = "accesspackageassignmentpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identitygovernance.azuread.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessPackageAssignmentPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccessPackageAssignmentPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccessPackageAssignmentPolicy> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPackage in identitygovernance to populate accessPackageId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPackage in identitygovernance to populate accessPackageId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApprover
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApprover
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStage
{
    /// <summary>
    /// Whether alternative approvers are enabled.
    /// If no action taken, forward to alternate approvers?
    /// </summary>
    [JsonPropertyName("alternativeApprovalEnabled")]
    public bool? AlternativeApprovalEnabled { get; set; }

    /// <summary>
    /// A block specifying alternative approvers when escalation is enabled and the primary approvers do not respond before the escalation time, as documented below.
    /// If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, if there are no escalation approvers, or escalation approvers are not required for the stage, the value of this property should be an empty collection
    /// </summary>
    [JsonPropertyName("alternativeApprover")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStageAlternativeApprover>? AlternativeApprover { get; set; }

    /// <summary>
    /// Maximum number of days within which a request must be approved. If a request is not approved within this time period after it is made, it will be automatically rejected.
    /// Decision must be made in how many days? If a request is not approved within this time period after it is made, it will be automatically rejected
    /// </summary>
    [JsonPropertyName("approvalTimeoutInDays")]
    public double? ApprovalTimeoutInDays { get; set; }

    /// <summary>
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor.
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor
    /// </summary>
    [JsonPropertyName("approverJustificationRequired")]
    public bool? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// Number of days before the request is forwarded to alternative approvers.
    /// Forward to alternate approver(s) after how many days?
    /// </summary>
    [JsonPropertyName("enableAlternativeApprovalInDays")]
    public double? EnableAlternativeApprovalInDays { get; set; }

    /// <summary>
    /// A block specifying the users who will be asked to approve requests, as documented below.
    /// The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, include at least one userSet in this collection
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An approval_settings block to specify whether approvals are required and how they are obtained, as documented below.
/// Settings of whether approvals are required and how they are obtained
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettings
{
    /// <summary>
    /// Whether an approval is required.
    /// Whether an approval is required
    /// </summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply.
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    [JsonPropertyName("approvalRequiredForExtension")]
    public bool? ApprovalRequiredForExtension { get; set; }

    /// <summary>
    /// An approval_stage block specifying the process to obtain an approval, as documented below.
    /// The process to obtain an approval
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettingsApprovalStage>? ApprovalStage { get; set; }

    /// <summary>
    /// Whether a requestor is required to provide a justification to request an access package. Justification is visible to approvers and the requestor.
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    [JsonPropertyName("requestorJustificationRequired")]
    public bool? RequestorJustificationRequired { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewer
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewerObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// An assignment_review_settings block, to specify whether assignment review is needed and how it is conducted, as documented below.
/// The settings of whether assignment review is needed and how it&apos;s conducted
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettings
{
    /// <summary>
    /// in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days.
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&apos; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    [JsonPropertyName("accessRecommendationEnabled")]
    public bool? AccessRecommendationEnabled { get; set; }

    /// <summary>
    /// Specifies the actions the system takes if reviewers don&apos;t respond in time. Valid values are keepAccess, removeAccess, or acceptAccessRecommendation.
    /// What actions the system takes if reviewers don&apos;t respond in time
    /// </summary>
    [JsonPropertyName("accessReviewTimeoutBehavior")]
    public string? AccessReviewTimeoutBehavior { get; set; }

    /// <summary>
    /// Whether a reviewer needs to provide a justification for their decision. Justification is visible to other reviewers and the requestor.
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    [JsonPropertyName("approverJustificationRequired")]
    public bool? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// (Number) How many days each occurrence of the access review series will run.
    /// How many days each occurrence of the access review series will run
    /// </summary>
    [JsonPropertyName("durationInDays")]
    public double? DurationInDays { get; set; }

    /// <summary>
    /// Whether to enable assignment review.
    /// Whether to enable assignment review
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This will determine how often the access review campaign runs, valid values are weekly, monthly, quarterly, halfyearly, or annual.
    /// This will determine how often the access review campaign runs
    /// </summary>
    [JsonPropertyName("reviewFrequency")]
    public string? ReviewFrequency { get; set; }

    /// <summary>
    /// review or specific reviewers. Valid values are Manager, Reviewers, or Self.
    /// Self review or specific reviewers
    /// </summary>
    [JsonPropertyName("reviewType")]
    public string? ReviewType { get; set; }

    /// <summary>
    /// One or more reviewer blocks to specify the users who will be reviewers (when review_type is Reviewers), as documented below.
    /// If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers
    /// </summary>
    [JsonPropertyName("reviewer")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettingsReviewer>? Reviewer { get; set; }

    /// <summary>
    /// 01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    [JsonPropertyName("startingOn")]
    public string? StartingOn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionChoiceDisplayValueLocalizedText
{
    /// <summary>
    /// The localized content of this question choice.
    /// The localized content of this question
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The ISO 639 language code for this question choice content.
    /// The language code of this question content
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// A block describing the display text of this choice, as documented below.
/// The display text of this choice
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionChoiceDisplayValue
{
    /// <summary>
    /// The default text of this question choice.
    /// The default text of this question
    /// </summary>
    [JsonPropertyName("defaultText")]
    public string? DefaultText { get; set; }

    /// <summary>
    /// One or more blocks describing localized text of this question choice, as documented below.
    /// The localized text of this question
    /// </summary>
    [JsonPropertyName("localizedText")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionChoiceDisplayValueLocalizedText>? LocalizedText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionChoice
{
    /// <summary>
    /// The actual value of this choice.
    /// The actual value of this choice
    /// </summary>
    [JsonPropertyName("actualValue")]
    public string? ActualValue { get; set; }

    /// <summary>
    /// A block describing the display text of this choice, as documented below.
    /// The display text of this choice
    /// </summary>
    [JsonPropertyName("displayValue")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionChoiceDisplayValue? DisplayValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionTextLocalizedText
{
    /// <summary>
    /// The localized content of this question.
    /// The localized content of this question
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The ISO 639 language code for this question content.
    /// The language code of this question content
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// A block describing the content of this question, as documented below.
/// The content of this question
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionText
{
    /// <summary>
    /// The default text of this question.
    /// The default text of this question
    /// </summary>
    [JsonPropertyName("defaultText")]
    public string? DefaultText { get; set; }

    /// <summary>
    /// One or more blocks describing localized text of this question, as documented below.
    /// The localized text of this question
    /// </summary>
    [JsonPropertyName("localizedText")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionTextLocalizedText>? LocalizedText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderQuestion
{
    /// <summary>
    /// One or more blocks configuring a choice to the question, as documented below.
    /// Configuration of a choice to the question
    /// </summary>
    [JsonPropertyName("choice")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionChoice>? Choice { get; set; }

    /// <summary>
    /// Whether this question is required.
    /// Whether this question is required
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The sequence number of this question.
    /// The sequence number of this question
    /// </summary>
    [JsonPropertyName("sequence")]
    public double? Sequence { get; set; }

    /// <summary>
    /// A block describing the content of this question, as documented below.
    /// The content of this question
    /// </summary>
    [JsonPropertyName("text")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderQuestionText? Text { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestor
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestorObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// A requestor_settings block to configure the users who can request access, as documented below.
/// This block configures the users who can request access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettings
{
    /// <summary>
    /// A block specifying the users who are allowed to request on this policy, as documented below.
    /// The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers
    /// </summary>
    [JsonPropertyName("requestor")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettingsRequestor>? Requestor { get; set; }

    /// <summary>
    /// Whether to accept requests using this policy. When false, no new requests can be made using this policy.
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    [JsonPropertyName("requestsAccepted")]
    public bool? RequestsAccepted { get; set; }

    /// <summary>
    /// Specifies the scopes of the requestors. Valid values are AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects, AllExternalSubjects, NoSubjects, SpecificConnectedOrganizationSubjects, or SpecificDirectorySubjects.
    /// Specify the scopes of the requestors
    /// </summary>
    [JsonPropertyName("scopeType")]
    public string? ScopeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecForProvider
{
    /// <summary>
    /// The ID of the access package that will contain the policy.
    /// The ID of the access package that will contain the policy
    /// </summary>
    [JsonPropertyName("accessPackageId")]
    public string? AccessPackageId { get; set; }

    /// <summary>Reference to a AccessPackage in identitygovernance to populate accessPackageId.</summary>
    [JsonPropertyName("accessPackageIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdRef? AccessPackageIdRef { get; set; }

    /// <summary>Selector for a AccessPackage in identitygovernance to populate accessPackageId.</summary>
    [JsonPropertyName("accessPackageIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAccessPackageIdSelector? AccessPackageIdSelector { get; set; }

    /// <summary>
    /// An approval_settings block to specify whether approvals are required and how they are obtained, as documented below.
    /// Settings of whether approvals are required and how they are obtained
    /// </summary>
    [JsonPropertyName("approvalSettings")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderApprovalSettings? ApprovalSettings { get; set; }

    /// <summary>
    /// An assignment_review_settings block, to specify whether assignment review is needed and how it is conducted, as documented below.
    /// The settings of whether assignment review is needed and how it&apos;s conducted
    /// </summary>
    [JsonPropertyName("assignmentReviewSettings")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderAssignmentReviewSettings? AssignmentReviewSettings { get; set; }

    /// <summary>
    /// The description of the policy.
    /// The description of the policy
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The display name of the policy.
    /// The display name of the policy
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// How many days this assignment is valid for.
    /// How many days this assignment is valid for
    /// </summary>
    [JsonPropertyName("durationInDays")]
    public double? DurationInDays { get; set; }

    /// <summary>
    /// 01-01T01:02:03Z).
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// Whether users will be able to request extension of their access to this package before their access expires.
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    [JsonPropertyName("extensionEnabled")]
    public bool? ExtensionEnabled { get; set; }

    /// <summary>
    /// One or more question blocks for the requestor, as documented below.
    /// One or more questions to the requestor
    /// </summary>
    [JsonPropertyName("question")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecForProviderQuestion>? Question { get; set; }

    /// <summary>
    /// A requestor_settings block to configure the users who can request access, as documented below.
    /// This block configures the users who can request access
    /// </summary>
    [JsonPropertyName("requestorSettings")]
    public V1beta1AccessPackageAssignmentPolicySpecForProviderRequestorSettings? RequestorSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AccessPackage in identitygovernance to populate accessPackageId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AccessPackage in identitygovernance to populate accessPackageId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApprover
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApproverObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApprover
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApproverObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStage
{
    /// <summary>
    /// Whether alternative approvers are enabled.
    /// If no action taken, forward to alternate approvers?
    /// </summary>
    [JsonPropertyName("alternativeApprovalEnabled")]
    public bool? AlternativeApprovalEnabled { get; set; }

    /// <summary>
    /// A block specifying alternative approvers when escalation is enabled and the primary approvers do not respond before the escalation time, as documented below.
    /// If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, if there are no escalation approvers, or escalation approvers are not required for the stage, the value of this property should be an empty collection
    /// </summary>
    [JsonPropertyName("alternativeApprover")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStageAlternativeApprover>? AlternativeApprover { get; set; }

    /// <summary>
    /// Maximum number of days within which a request must be approved. If a request is not approved within this time period after it is made, it will be automatically rejected.
    /// Decision must be made in how many days? If a request is not approved within this time period after it is made, it will be automatically rejected
    /// </summary>
    [JsonPropertyName("approvalTimeoutInDays")]
    public double? ApprovalTimeoutInDays { get; set; }

    /// <summary>
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor.
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor
    /// </summary>
    [JsonPropertyName("approverJustificationRequired")]
    public bool? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// Number of days before the request is forwarded to alternative approvers.
    /// Forward to alternate approver(s) after how many days?
    /// </summary>
    [JsonPropertyName("enableAlternativeApprovalInDays")]
    public double? EnableAlternativeApprovalInDays { get; set; }

    /// <summary>
    /// A block specifying the users who will be asked to approve requests, as documented below.
    /// The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, include at least one userSet in this collection
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An approval_settings block to specify whether approvals are required and how they are obtained, as documented below.
/// Settings of whether approvals are required and how they are obtained
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettings
{
    /// <summary>
    /// Whether an approval is required.
    /// Whether an approval is required
    /// </summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply.
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    [JsonPropertyName("approvalRequiredForExtension")]
    public bool? ApprovalRequiredForExtension { get; set; }

    /// <summary>
    /// An approval_stage block specifying the process to obtain an approval, as documented below.
    /// The process to obtain an approval
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettingsApprovalStage>? ApprovalStage { get; set; }

    /// <summary>
    /// Whether a requestor is required to provide a justification to request an access package. Justification is visible to approvers and the requestor.
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    [JsonPropertyName("requestorJustificationRequired")]
    public bool? RequestorJustificationRequired { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewer
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewerObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// An assignment_review_settings block, to specify whether assignment review is needed and how it is conducted, as documented below.
/// The settings of whether assignment review is needed and how it&apos;s conducted
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettings
{
    /// <summary>
    /// in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days.
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&apos; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    [JsonPropertyName("accessRecommendationEnabled")]
    public bool? AccessRecommendationEnabled { get; set; }

    /// <summary>
    /// Specifies the actions the system takes if reviewers don&apos;t respond in time. Valid values are keepAccess, removeAccess, or acceptAccessRecommendation.
    /// What actions the system takes if reviewers don&apos;t respond in time
    /// </summary>
    [JsonPropertyName("accessReviewTimeoutBehavior")]
    public string? AccessReviewTimeoutBehavior { get; set; }

    /// <summary>
    /// Whether a reviewer needs to provide a justification for their decision. Justification is visible to other reviewers and the requestor.
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    [JsonPropertyName("approverJustificationRequired")]
    public bool? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// (Number) How many days each occurrence of the access review series will run.
    /// How many days each occurrence of the access review series will run
    /// </summary>
    [JsonPropertyName("durationInDays")]
    public double? DurationInDays { get; set; }

    /// <summary>
    /// Whether to enable assignment review.
    /// Whether to enable assignment review
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This will determine how often the access review campaign runs, valid values are weekly, monthly, quarterly, halfyearly, or annual.
    /// This will determine how often the access review campaign runs
    /// </summary>
    [JsonPropertyName("reviewFrequency")]
    public string? ReviewFrequency { get; set; }

    /// <summary>
    /// review or specific reviewers. Valid values are Manager, Reviewers, or Self.
    /// Self review or specific reviewers
    /// </summary>
    [JsonPropertyName("reviewType")]
    public string? ReviewType { get; set; }

    /// <summary>
    /// One or more reviewer blocks to specify the users who will be reviewers (when review_type is Reviewers), as documented below.
    /// If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers
    /// </summary>
    [JsonPropertyName("reviewer")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettingsReviewer>? Reviewer { get; set; }

    /// <summary>
    /// 01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    [JsonPropertyName("startingOn")]
    public string? StartingOn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionChoiceDisplayValueLocalizedText
{
    /// <summary>
    /// The localized content of this question choice.
    /// The localized content of this question
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The ISO 639 language code for this question choice content.
    /// The language code of this question content
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// A block describing the display text of this choice, as documented below.
/// The display text of this choice
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionChoiceDisplayValue
{
    /// <summary>
    /// The default text of this question choice.
    /// The default text of this question
    /// </summary>
    [JsonPropertyName("defaultText")]
    public string? DefaultText { get; set; }

    /// <summary>
    /// One or more blocks describing localized text of this question choice, as documented below.
    /// The localized text of this question
    /// </summary>
    [JsonPropertyName("localizedText")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionChoiceDisplayValueLocalizedText>? LocalizedText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionChoice
{
    /// <summary>
    /// The actual value of this choice.
    /// The actual value of this choice
    /// </summary>
    [JsonPropertyName("actualValue")]
    public string? ActualValue { get; set; }

    /// <summary>
    /// A block describing the display text of this choice, as documented below.
    /// The display text of this choice
    /// </summary>
    [JsonPropertyName("displayValue")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionChoiceDisplayValue? DisplayValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionTextLocalizedText
{
    /// <summary>
    /// The localized content of this question.
    /// The localized content of this question
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The ISO 639 language code for this question content.
    /// The language code of this question content
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// A block describing the content of this question, as documented below.
/// The content of this question
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionText
{
    /// <summary>
    /// The default text of this question.
    /// The default text of this question
    /// </summary>
    [JsonPropertyName("defaultText")]
    public string? DefaultText { get; set; }

    /// <summary>
    /// One or more blocks describing localized text of this question, as documented below.
    /// The localized text of this question
    /// </summary>
    [JsonPropertyName("localizedText")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionTextLocalizedText>? LocalizedText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestion
{
    /// <summary>
    /// One or more blocks configuring a choice to the question, as documented below.
    /// Configuration of a choice to the question
    /// </summary>
    [JsonPropertyName("choice")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionChoice>? Choice { get; set; }

    /// <summary>
    /// Whether this question is required.
    /// Whether this question is required
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The sequence number of this question.
    /// The sequence number of this question
    /// </summary>
    [JsonPropertyName("sequence")]
    public double? Sequence { get; set; }

    /// <summary>
    /// A block describing the content of this question, as documented below.
    /// The content of this question
    /// </summary>
    [JsonPropertyName("text")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestionText? Text { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in groups to populate objectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelector
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
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestor
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a Group in groups to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestorObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// A requestor_settings block to configure the users who can request access, as documented below.
/// This block configures the users who can request access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettings
{
    /// <summary>
    /// A block specifying the users who are allowed to request on this policy, as documented below.
    /// The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers
    /// </summary>
    [JsonPropertyName("requestor")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettingsRequestor>? Requestor { get; set; }

    /// <summary>
    /// Whether to accept requests using this policy. When false, no new requests can be made using this policy.
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    [JsonPropertyName("requestsAccepted")]
    public bool? RequestsAccepted { get; set; }

    /// <summary>
    /// Specifies the scopes of the requestors. Valid values are AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects, AllExternalSubjects, NoSubjects, SpecificConnectedOrganizationSubjects, or SpecificDirectorySubjects.
    /// Specify the scopes of the requestors
    /// </summary>
    [JsonPropertyName("scopeType")]
    public string? ScopeType { get; set; }
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
public partial class V1beta1AccessPackageAssignmentPolicySpecInitProvider
{
    /// <summary>
    /// The ID of the access package that will contain the policy.
    /// The ID of the access package that will contain the policy
    /// </summary>
    [JsonPropertyName("accessPackageId")]
    public string? AccessPackageId { get; set; }

    /// <summary>Reference to a AccessPackage in identitygovernance to populate accessPackageId.</summary>
    [JsonPropertyName("accessPackageIdRef")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdRef? AccessPackageIdRef { get; set; }

    /// <summary>Selector for a AccessPackage in identitygovernance to populate accessPackageId.</summary>
    [JsonPropertyName("accessPackageIdSelector")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAccessPackageIdSelector? AccessPackageIdSelector { get; set; }

    /// <summary>
    /// An approval_settings block to specify whether approvals are required and how they are obtained, as documented below.
    /// Settings of whether approvals are required and how they are obtained
    /// </summary>
    [JsonPropertyName("approvalSettings")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderApprovalSettings? ApprovalSettings { get; set; }

    /// <summary>
    /// An assignment_review_settings block, to specify whether assignment review is needed and how it is conducted, as documented below.
    /// The settings of whether assignment review is needed and how it&apos;s conducted
    /// </summary>
    [JsonPropertyName("assignmentReviewSettings")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderAssignmentReviewSettings? AssignmentReviewSettings { get; set; }

    /// <summary>
    /// The description of the policy.
    /// The description of the policy
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The display name of the policy.
    /// The display name of the policy
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// How many days this assignment is valid for.
    /// How many days this assignment is valid for
    /// </summary>
    [JsonPropertyName("durationInDays")]
    public double? DurationInDays { get; set; }

    /// <summary>
    /// 01-01T01:02:03Z).
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// Whether users will be able to request extension of their access to this package before their access expires.
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    [JsonPropertyName("extensionEnabled")]
    public bool? ExtensionEnabled { get; set; }

    /// <summary>
    /// One or more question blocks for the requestor, as documented below.
    /// One or more questions to the requestor
    /// </summary>
    [JsonPropertyName("question")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecInitProviderQuestion>? Question { get; set; }

    /// <summary>
    /// A requestor_settings block to configure the users who can request access, as documented below.
    /// This block configures the users who can request access
    /// </summary>
    [JsonPropertyName("requestorSettings")]
    public V1beta1AccessPackageAssignmentPolicySpecInitProviderRequestorSettings? RequestorSettings { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccessPackageAssignmentPolicySpecManagementPoliciesEnum>))]
public enum V1beta1AccessPackageAssignmentPolicySpecManagementPoliciesEnum
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
public partial class V1beta1AccessPackageAssignmentPolicySpecProviderConfigRef
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
public partial class V1beta1AccessPackageAssignmentPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AccessPackageAssignmentPolicySpec defines the desired state of AccessPackageAssignmentPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1AccessPackageAssignmentPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1AccessPackageAssignmentPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AccessPackageAssignmentPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccessPackageAssignmentPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccessPackageAssignmentPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettingsApprovalStageAlternativeApprover
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettingsApprovalStagePrimaryApprover
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettingsApprovalStage
{
    /// <summary>
    /// Whether alternative approvers are enabled.
    /// If no action taken, forward to alternate approvers?
    /// </summary>
    [JsonPropertyName("alternativeApprovalEnabled")]
    public bool? AlternativeApprovalEnabled { get; set; }

    /// <summary>
    /// A block specifying alternative approvers when escalation is enabled and the primary approvers do not respond before the escalation time, as documented below.
    /// If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, if there are no escalation approvers, or escalation approvers are not required for the stage, the value of this property should be an empty collection
    /// </summary>
    [JsonPropertyName("alternativeApprover")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettingsApprovalStageAlternativeApprover>? AlternativeApprover { get; set; }

    /// <summary>
    /// Maximum number of days within which a request must be approved. If a request is not approved within this time period after it is made, it will be automatically rejected.
    /// Decision must be made in how many days? If a request is not approved within this time period after it is made, it will be automatically rejected
    /// </summary>
    [JsonPropertyName("approvalTimeoutInDays")]
    public double? ApprovalTimeoutInDays { get; set; }

    /// <summary>
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor.
    /// Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor
    /// </summary>
    [JsonPropertyName("approverJustificationRequired")]
    public bool? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// Number of days before the request is forwarded to alternative approvers.
    /// Forward to alternate approver(s) after how many days?
    /// </summary>
    [JsonPropertyName("enableAlternativeApprovalInDays")]
    public double? EnableAlternativeApprovalInDays { get; set; }

    /// <summary>
    /// A block specifying the users who will be asked to approve requests, as documented below.
    /// The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors. When creating or updating a policy, include at least one userSet in this collection
    /// </summary>
    [JsonPropertyName("primaryApprover")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettingsApprovalStagePrimaryApprover>? PrimaryApprover { get; set; }
}

/// <summary>
/// An approval_settings block to specify whether approvals are required and how they are obtained, as documented below.
/// Settings of whether approvals are required and how they are obtained
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettings
{
    /// <summary>
    /// Whether an approval is required.
    /// Whether an approval is required
    /// </summary>
    [JsonPropertyName("approvalRequired")]
    public bool? ApprovalRequired { get; set; }

    /// <summary>
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply.
    /// Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply
    /// </summary>
    [JsonPropertyName("approvalRequiredForExtension")]
    public bool? ApprovalRequiredForExtension { get; set; }

    /// <summary>
    /// An approval_stage block specifying the process to obtain an approval, as documented below.
    /// The process to obtain an approval
    /// </summary>
    [JsonPropertyName("approvalStage")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettingsApprovalStage>? ApprovalStage { get; set; }

    /// <summary>
    /// Whether a requestor is required to provide a justification to request an access package. Justification is visible to approvers and the requestor.
    /// Whether requestor are required to provide a justification to request an access package. Justification is visible to other approvers and the requestor
    /// </summary>
    [JsonPropertyName("requestorJustificationRequired")]
    public bool? RequestorJustificationRequired { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderAssignmentReviewSettingsReviewer
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// An assignment_review_settings block, to specify whether assignment review is needed and how it is conducted, as documented below.
/// The settings of whether assignment review is needed and how it&apos;s conducted
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderAssignmentReviewSettings
{
    /// <summary>
    /// in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days.
    /// Whether to show Show reviewer decision helpers. If enabled, system recommendations based on users&apos; access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
    /// </summary>
    [JsonPropertyName("accessRecommendationEnabled")]
    public bool? AccessRecommendationEnabled { get; set; }

    /// <summary>
    /// Specifies the actions the system takes if reviewers don&apos;t respond in time. Valid values are keepAccess, removeAccess, or acceptAccessRecommendation.
    /// What actions the system takes if reviewers don&apos;t respond in time
    /// </summary>
    [JsonPropertyName("accessReviewTimeoutBehavior")]
    public string? AccessReviewTimeoutBehavior { get; set; }

    /// <summary>
    /// Whether a reviewer needs to provide a justification for their decision. Justification is visible to other reviewers and the requestor.
    /// Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor
    /// </summary>
    [JsonPropertyName("approverJustificationRequired")]
    public bool? ApproverJustificationRequired { get; set; }

    /// <summary>
    /// (Number) How many days each occurrence of the access review series will run.
    /// How many days each occurrence of the access review series will run
    /// </summary>
    [JsonPropertyName("durationInDays")]
    public double? DurationInDays { get; set; }

    /// <summary>
    /// Whether to enable assignment review.
    /// Whether to enable assignment review
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This will determine how often the access review campaign runs, valid values are weekly, monthly, quarterly, halfyearly, or annual.
    /// This will determine how often the access review campaign runs
    /// </summary>
    [JsonPropertyName("reviewFrequency")]
    public string? ReviewFrequency { get; set; }

    /// <summary>
    /// review or specific reviewers. Valid values are Manager, Reviewers, or Self.
    /// Self review or specific reviewers
    /// </summary>
    [JsonPropertyName("reviewType")]
    public string? ReviewType { get; set; }

    /// <summary>
    /// One or more reviewer blocks to specify the users who will be reviewers (when review_type is Reviewers), as documented below.
    /// If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers
    /// </summary>
    [JsonPropertyName("reviewer")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderAssignmentReviewSettingsReviewer>? Reviewer { get; set; }

    /// <summary>
    /// 01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date
    /// </summary>
    [JsonPropertyName("startingOn")]
    public string? StartingOn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionChoiceDisplayValueLocalizedText
{
    /// <summary>
    /// The localized content of this question choice.
    /// The localized content of this question
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The ISO 639 language code for this question choice content.
    /// The language code of this question content
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// A block describing the display text of this choice, as documented below.
/// The display text of this choice
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionChoiceDisplayValue
{
    /// <summary>
    /// The default text of this question choice.
    /// The default text of this question
    /// </summary>
    [JsonPropertyName("defaultText")]
    public string? DefaultText { get; set; }

    /// <summary>
    /// One or more blocks describing localized text of this question choice, as documented below.
    /// The localized text of this question
    /// </summary>
    [JsonPropertyName("localizedText")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionChoiceDisplayValueLocalizedText>? LocalizedText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionChoice
{
    /// <summary>
    /// The actual value of this choice.
    /// The actual value of this choice
    /// </summary>
    [JsonPropertyName("actualValue")]
    public string? ActualValue { get; set; }

    /// <summary>
    /// A block describing the display text of this choice, as documented below.
    /// The display text of this choice
    /// </summary>
    [JsonPropertyName("displayValue")]
    public V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionChoiceDisplayValue? DisplayValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionTextLocalizedText
{
    /// <summary>
    /// The localized content of this question.
    /// The localized content of this question
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The ISO 639 language code for this question content.
    /// The language code of this question content
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }
}

/// <summary>
/// A block describing the content of this question, as documented below.
/// The content of this question
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionText
{
    /// <summary>
    /// The default text of this question.
    /// The default text of this question
    /// </summary>
    [JsonPropertyName("defaultText")]
    public string? DefaultText { get; set; }

    /// <summary>
    /// One or more blocks describing localized text of this question, as documented below.
    /// The localized text of this question
    /// </summary>
    [JsonPropertyName("localizedText")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionTextLocalizedText>? LocalizedText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestion
{
    /// <summary>
    /// One or more blocks configuring a choice to the question, as documented below.
    /// Configuration of a choice to the question
    /// </summary>
    [JsonPropertyName("choice")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionChoice>? Choice { get; set; }

    /// <summary>
    /// Whether this question is required.
    /// Whether this question is required
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The sequence number of this question.
    /// The sequence number of this question
    /// </summary>
    [JsonPropertyName("sequence")]
    public double? Sequence { get; set; }

    /// <summary>
    /// A block describing the content of this question, as documented below.
    /// The content of this question
    /// </summary>
    [JsonPropertyName("text")]
    public V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestionText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderRequestorSettingsRequestor
{
    /// <summary>
    /// For a user in an approval stage, this property indicates whether the user is a backup approver.
    /// For a user in an approval stage, this property indicates whether the user is a backup fallback approver
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>
    /// The ID of the subject.
    /// The object ID of the subject
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Specifies the type of users. Valid values are singleUser, groupMembers, connectedOrganizationMembers, requestorManager, internalSponsors, or externalSponsors.
    /// Type of users
    /// </summary>
    [JsonPropertyName("subjectType")]
    public string? SubjectType { get; set; }
}

/// <summary>
/// A requestor_settings block to configure the users who can request access, as documented below.
/// This block configures the users who can request access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProviderRequestorSettings
{
    /// <summary>
    /// A block specifying the users who are allowed to request on this policy, as documented below.
    /// The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers
    /// </summary>
    [JsonPropertyName("requestor")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderRequestorSettingsRequestor>? Requestor { get; set; }

    /// <summary>
    /// Whether to accept requests using this policy. When false, no new requests can be made using this policy.
    /// Whether to accept requests now, when disabled, no new requests can be made using this policy
    /// </summary>
    [JsonPropertyName("requestsAccepted")]
    public bool? RequestsAccepted { get; set; }

    /// <summary>
    /// Specifies the scopes of the requestors. Valid values are AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects, AllExternalSubjects, NoSubjects, SpecificConnectedOrganizationSubjects, or SpecificDirectorySubjects.
    /// Specify the scopes of the requestors
    /// </summary>
    [JsonPropertyName("scopeType")]
    public string? ScopeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusAtProvider
{
    /// <summary>
    /// The ID of the access package that will contain the policy.
    /// The ID of the access package that will contain the policy
    /// </summary>
    [JsonPropertyName("accessPackageId")]
    public string? AccessPackageId { get; set; }

    /// <summary>
    /// An approval_settings block to specify whether approvals are required and how they are obtained, as documented below.
    /// Settings of whether approvals are required and how they are obtained
    /// </summary>
    [JsonPropertyName("approvalSettings")]
    public V1beta1AccessPackageAssignmentPolicyStatusAtProviderApprovalSettings? ApprovalSettings { get; set; }

    /// <summary>
    /// An assignment_review_settings block, to specify whether assignment review is needed and how it is conducted, as documented below.
    /// The settings of whether assignment review is needed and how it&apos;s conducted
    /// </summary>
    [JsonPropertyName("assignmentReviewSettings")]
    public V1beta1AccessPackageAssignmentPolicyStatusAtProviderAssignmentReviewSettings? AssignmentReviewSettings { get; set; }

    /// <summary>
    /// The description of the policy.
    /// The description of the policy
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The display name of the policy.
    /// The display name of the policy
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// How many days this assignment is valid for.
    /// How many days this assignment is valid for
    /// </summary>
    [JsonPropertyName("durationInDays")]
    public double? DurationInDays { get; set; }

    /// <summary>
    /// 01-01T01:02:03Z).
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// Whether users will be able to request extension of their access to this package before their access expires.
    /// When enabled, users will be able to request extension of their access to this package before their access expires
    /// </summary>
    [JsonPropertyName("extensionEnabled")]
    public bool? ExtensionEnabled { get; set; }

    /// <summary>(String) The ID of this resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// One or more question blocks for the requestor, as documented below.
    /// One or more questions to the requestor
    /// </summary>
    [JsonPropertyName("question")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusAtProviderQuestion>? Question { get; set; }

    /// <summary>
    /// A requestor_settings block to configure the users who can request access, as documented below.
    /// This block configures the users who can request access
    /// </summary>
    [JsonPropertyName("requestorSettings")]
    public V1beta1AccessPackageAssignmentPolicyStatusAtProviderRequestorSettings? RequestorSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatusConditions
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

/// <summary>AccessPackageAssignmentPolicyStatus defines the observed state of AccessPackageAssignmentPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessPackageAssignmentPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AccessPackageAssignmentPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessPackageAssignmentPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccessPackageAssignmentPolicy is the Schema for the AccessPackageAssignmentPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessPackageAssignmentPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessPackageAssignmentPolicySpec>, IStatus<V1beta1AccessPackageAssignmentPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessPackageAssignmentPolicy";
    public const string KubeGroup = "identitygovernance.azuread.m.upbound.io";
    public const string KubePluralName = "accesspackageassignmentpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identitygovernance.azuread.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessPackageAssignmentPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessPackageAssignmentPolicySpec defines the desired state of AccessPackageAssignmentPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccessPackageAssignmentPolicySpec Spec { get; set; }

    /// <summary>AccessPackageAssignmentPolicyStatus defines the observed state of AccessPackageAssignmentPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessPackageAssignmentPolicyStatus? Status { get; set; }
}