#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.authorization.azure.upbound.io;
/// <summary>ResourcePolicyAssignment is the Schema for the ResourcePolicyAssignments API. Manages a Policy Assignment to a Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourcePolicyAssignmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ResourcePolicyAssignment>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourcePolicyAssignmentList";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "resourcepolicyassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourcePolicyAssignmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ResourcePolicyAssignment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ResourcePolicyAssignment> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecDeletionPolicyEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta2ResourcePolicyAssignmentSpecForProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolutionEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolveEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolveEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta2ResourcePolicyAssignmentSpecForProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecForProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name which should be used for this Policy Assignment. Changing this forces a new Resource Policy Assignment to be created. Cannot exceed 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta2ResourcePolicyAssignmentSpecForProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta2ResourcePolicyAssignmentSpecForProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta2ResourcePolicyAssignmentSpecForProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>The ID of the Resource (or Resource Scope) where this should be applied. Changing this forces a new Resource Policy Assignment to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta2ResourcePolicyAssignmentSpecForProviderResourceSelectors>? ResourceSelectors { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta2ResourcePolicyAssignmentSpecInitProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolutionEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolveEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolveEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecInitProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta2ResourcePolicyAssignmentSpecInitProviderResourceSelectorsSelectors>? Selectors { get; set; }
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
public partial class V1beta2ResourcePolicyAssignmentSpecInitProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name which should be used for this Policy Assignment. Changing this forces a new Resource Policy Assignment to be created. Cannot exceed 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta2ResourcePolicyAssignmentSpecInitProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta2ResourcePolicyAssignmentSpecInitProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>Reference to a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdRef")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdRef? PolicyDefinitionIdRef { get; set; }

    /// <summary>Selector for a PolicyDefinition in authorization to populate policyDefinitionId.</summary>
    [JsonPropertyName("policyDefinitionIdSelector")]
    public V1beta2ResourcePolicyAssignmentSpecInitProviderPolicyDefinitionIdSelector? PolicyDefinitionIdSelector { get; set; }

    /// <summary>The ID of the Resource (or Resource Scope) where this should be applied. Changing this forces a new Resource Policy Assignment to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta2ResourcePolicyAssignmentSpecInitProviderResourceSelectors>? ResourceSelectors { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecManagementPoliciesEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResourcePolicyAssignmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResourcePolicyAssignmentSpec defines the desired state of ResourcePolicyAssignment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentSpec
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
    public V1beta2ResourcePolicyAssignmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ResourcePolicyAssignmentSpecForProvider ForProvider { get; set; }

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
    public V1beta2ResourcePolicyAssignmentSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ResourcePolicyAssignmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ResourcePolicyAssignmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ResourcePolicyAssignmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProviderIdentity
{
    /// <summary>A list of User Managed Identity IDs which should be assigned to the Policy Definition.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID of the Policy Assignment for this Resource.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID of the Policy Assignment for this Resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The Type of Managed Identity which should be added to this Policy Definition. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProviderNonComplianceMessage
{
    /// <summary>The non-compliance message text. When assigning policy sets (initiatives), unless policy_definition_reference_id is specified then this message will be the default for all policies.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>When assigning policy sets (initiatives), this is the ID of the policy definition that the non-compliance message applies to.</summary>
    [JsonPropertyName("policyDefinitionReferenceId")]
    public string? PolicyDefinitionReferenceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProviderOverridesSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProviderOverrides
{
    /// <summary>One or more override_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta2ResourcePolicyAssignmentStatusAtProviderOverridesSelectors>? Selectors { get; set; }

    /// <summary>Specifies the value to override the policy property. Possible values for policyEffect override listed policy effects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProviderResourceSelectorsSelectors
{
    /// <summary>The list of allowed values for the specified kind. Cannot be used with not_in. Can contain up to 50 values.</summary>
    [JsonPropertyName("in")]
    public IList<string>? In { get; set; }

    /// <summary>Specifies which characteristic will narrow down the set of evaluated resources. Possible values are resourceLocation, resourceType and resourceWithoutLocation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The list of not-allowed values for the specified kind. Cannot be used with in. Can contain up to 50 values.</summary>
    [JsonPropertyName("notIn")]
    public IList<string>? NotIn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProviderResourceSelectors
{
    /// <summary>Specifies a name for the resource selector.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more resource_selector block as defined below.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1beta2ResourcePolicyAssignmentStatusAtProviderResourceSelectorsSelectors>? Selectors { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusAtProvider
{
    /// <summary>A description which should be used for this Policy Assignment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this Policy Assignment.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies if this Policy should be enforced or not? Defaults to true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>The ID of the Resource Policy Assignment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ResourcePolicyAssignmentStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the Policy Assignment should exist. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Policy.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>The name which should be used for this Policy Assignment. Changing this forces a new Resource Policy Assignment to be created. Cannot exceed 64 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more non_compliance_message blocks as defined below.</summary>
    [JsonPropertyName("nonComplianceMessage")]
    public IList<V1beta2ResourcePolicyAssignmentStatusAtProviderNonComplianceMessage>? NonComplianceMessage { get; set; }

    /// <summary>Specifies a list of Resource Scopes (for example a Subscription, or a Resource Group) within this Management Group which are excluded from this Policy.</summary>
    [JsonPropertyName("notScopes")]
    public IList<string>? NotScopes { get; set; }

    /// <summary>One or more overrides blocks as defined below. More detail about overrides and resource_selectors see policy assignment structure</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta2ResourcePolicyAssignmentStatusAtProviderOverrides>? Overrides { get; set; }

    /// <summary>A JSON mapping of any Parameters for this Policy.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>The ID of the Policy Definition or Policy Definition Set. Changing this forces a new Policy Assignment to be created.</summary>
    [JsonPropertyName("policyDefinitionId")]
    public string? PolicyDefinitionId { get; set; }

    /// <summary>The ID of the Resource (or Resource Scope) where this should be applied. Changing this forces a new Resource Policy Assignment to be created.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>One or more resource_selectors blocks as defined below to filter polices by resource properties.</summary>
    [JsonPropertyName("resourceSelectors")]
    public IList<V1beta2ResourcePolicyAssignmentStatusAtProviderResourceSelectors>? ResourceSelectors { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatusConditions
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

/// <summary>ResourcePolicyAssignmentStatus defines the observed state of ResourcePolicyAssignment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResourcePolicyAssignmentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ResourcePolicyAssignmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ResourcePolicyAssignmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourcePolicyAssignment is the Schema for the ResourcePolicyAssignments API. Manages a Policy Assignment to a Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResourcePolicyAssignment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ResourcePolicyAssignmentSpec>, IStatus<V1beta2ResourcePolicyAssignmentStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResourcePolicyAssignment";
    public const string KubeGroup = "authorization.azure.upbound.io";
    public const string KubePluralName = "resourcepolicyassignments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "authorization.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourcePolicyAssignment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourcePolicyAssignmentSpec defines the desired state of ResourcePolicyAssignment</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ResourcePolicyAssignmentSpec Spec { get; set; }

    /// <summary>ResourcePolicyAssignmentStatus defines the observed state of ResourcePolicyAssignment.</summary>
    [JsonPropertyName("status")]
    public V1beta2ResourcePolicyAssignmentStatus? Status { get; set; }
}