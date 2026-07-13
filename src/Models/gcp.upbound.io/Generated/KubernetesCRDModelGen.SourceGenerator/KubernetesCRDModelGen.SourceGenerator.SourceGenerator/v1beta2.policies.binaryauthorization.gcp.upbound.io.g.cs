#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.binaryauthorization.gcp.upbound.io;
/// <summary>Policy is the Schema for the Policys API. A policy for container image binary authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Policy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "binaryauthorization.gcp.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Policy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecDeletionPolicyEnum>))]
public enum V1beta2PolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderAdmissionWhitelistPatterns
{
    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// registry/path/to/image. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelector
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
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderClusterAdmissionRules
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule.
    /// Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated.
    /// Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format projects/*/attestors/*.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }

    /// <summary>References to Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsByRefs")]
    public IList<V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsByRefs>? RequireAttestationsByRefs { get; set; }

    /// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsBySelector")]
    public V1beta2PolicySpecForProviderClusterAdmissionRulesRequireAttestationsBySelector? RequireAttestationsBySelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelector
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
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Default admission rule for a cluster without a per-cluster admission
/// rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderDefaultAdmissionRule
{
    /// <summary>
    /// The action when a pod creation is denied by the admission rule.
    /// Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated.
    /// Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format projects/*/attestors/*.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }

    /// <summary>References to Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsByRefs")]
    public IList<V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsByRefs>? RequireAttestationsByRefs { get; set; }

    /// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsBySelector")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRuleRequireAttestationsBySelector? RequireAttestationsBySelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProvider
{
    /// <summary>
    /// A whitelist of image patterns to exclude from admission rules. If an
    /// image&apos;s name matches a whitelist pattern, the image&apos;s admission
    /// requests will always be permitted regardless of your admission rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta2PolicySpecForProviderAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>
    /// Per-cluster admission rules. An admission rule specifies either that
    /// all container images used in a pod creation request must be attested
    /// to by one or more attestors, that all pod creations will be allowed,
    /// or that all pod creations will be denied. There can be at most one
    /// admission rule per cluster spec.
    /// </summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IList<V1beta2PolicySpecForProviderClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>
    /// Default admission rule for a cluster without a per-cluster admission
    /// rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public V1beta2PolicySpecForProviderDefaultAdmissionRule? DefaultAdmissionRule { get; set; }

    /// <summary>A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy.
    /// Possible values are: ENABLE, DISABLE.
    /// </summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderAdmissionWhitelistPatterns
{
    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// registry/path/to/image. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolutionEnum>))]
public enum V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolveEnum>))]
public enum V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelector
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
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderClusterAdmissionRules
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule.
    /// Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated.
    /// Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format projects/*/attestors/*.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }

    /// <summary>References to Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsByRefs")]
    public IList<V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsByRefs>? RequireAttestationsByRefs { get; set; }

    /// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsBySelector")]
    public V1beta2PolicySpecInitProviderClusterAdmissionRulesRequireAttestationsBySelector? RequireAttestationsBySelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolutionEnum>))]
public enum V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolveEnum>))]
public enum V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelector
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
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Default admission rule for a cluster without a per-cluster admission
/// rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderDefaultAdmissionRule
{
    /// <summary>
    /// The action when a pod creation is denied by the admission rule.
    /// Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated.
    /// Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format projects/*/attestors/*.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }

    /// <summary>References to Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsByRefs")]
    public IList<V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsByRefs>? RequireAttestationsByRefs { get; set; }

    /// <summary>Selector for a list of Attestor in binaryauthorization to populate requireAttestationsBy.</summary>
    [JsonPropertyName("requireAttestationsBySelector")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRuleRequireAttestationsBySelector? RequireAttestationsBySelector { get; set; }
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
public partial class V1beta2PolicySpecInitProvider
{
    /// <summary>
    /// A whitelist of image patterns to exclude from admission rules. If an
    /// image&apos;s name matches a whitelist pattern, the image&apos;s admission
    /// requests will always be permitted regardless of your admission rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta2PolicySpecInitProviderAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>
    /// Per-cluster admission rules. An admission rule specifies either that
    /// all container images used in a pod creation request must be attested
    /// to by one or more attestors, that all pod creations will be allowed,
    /// or that all pod creations will be denied. There can be at most one
    /// admission rule per cluster spec.
    /// </summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IList<V1beta2PolicySpecInitProviderClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>
    /// Default admission rule for a cluster without a per-cluster admission
    /// rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public V1beta2PolicySpecInitProviderDefaultAdmissionRule? DefaultAdmissionRule { get; set; }

    /// <summary>A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy.
    /// Possible values are: ENABLE, DISABLE.
    /// </summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecManagementPoliciesEnum>))]
public enum V1beta2PolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PolicySpec defines the desired state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpec
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
    public V1beta2PolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2PolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderAdmissionWhitelistPatterns
{
    /// <summary>
    /// An image name pattern to whitelist, in the form
    /// registry/path/to/image. This supports a trailing * as a
    /// wildcard, but this is allowed only in text after the registry/
    /// part.
    /// </summary>
    [JsonPropertyName("namePattern")]
    public string? NamePattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderClusterAdmissionRules
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>
    /// The action when a pod creation is denied by the admission rule.
    /// Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated.
    /// Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format projects/*/attestors/*.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

/// <summary>
/// Default admission rule for a cluster without a per-cluster admission
/// rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderDefaultAdmissionRule
{
    /// <summary>
    /// The action when a pod creation is denied by the admission rule.
    /// Possible values are: ENFORCED_BLOCK_AND_AUDIT_LOG, DRYRUN_AUDIT_LOG_ONLY.
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }

    /// <summary>
    /// How this admission rule will be evaluated.
    /// Possible values are: ALWAYS_ALLOW, REQUIRE_ATTESTATION, ALWAYS_DENY.
    /// </summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }

    /// <summary>
    /// The resource names of the attestors that must attest to a
    /// container image. If the attestor is in a different project from the
    /// policy, it should be specified in the format projects/*/attestors/*.
    /// Each attestor must exist before a policy can reference it. To add an
    /// attestor to a policy the principal issuing the policy change
    /// request must be able to read the attestor resource.
    /// Note: this field must be non-empty when the evaluation_mode field
    /// specifies REQUIRE_ATTESTATION, otherwise it must be empty.
    /// </summary>
    [JsonPropertyName("requireAttestationsBy")]
    public IList<string>? RequireAttestationsBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProvider
{
    /// <summary>
    /// A whitelist of image patterns to exclude from admission rules. If an
    /// image&apos;s name matches a whitelist pattern, the image&apos;s admission
    /// requests will always be permitted regardless of your admission rules.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("admissionWhitelistPatterns")]
    public IList<V1beta2PolicyStatusAtProviderAdmissionWhitelistPatterns>? AdmissionWhitelistPatterns { get; set; }

    /// <summary>
    /// Per-cluster admission rules. An admission rule specifies either that
    /// all container images used in a pod creation request must be attested
    /// to by one or more attestors, that all pod creations will be allowed,
    /// or that all pod creations will be denied. There can be at most one
    /// admission rule per cluster spec.
    /// </summary>
    [JsonPropertyName("clusterAdmissionRules")]
    public IList<V1beta2PolicyStatusAtProviderClusterAdmissionRules>? ClusterAdmissionRules { get; set; }

    /// <summary>
    /// Default admission rule for a cluster without a per-cluster admission
    /// rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultAdmissionRule")]
    public V1beta2PolicyStatusAtProviderDefaultAdmissionRule? DefaultAdmissionRule { get; set; }

    /// <summary>A descriptive comment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Controls the evaluation of a Google-maintained global admission policy
    /// for common system-level images. Images not covered by the global
    /// policy will be subject to the project admission policy.
    /// Possible values are: ENABLE, DISABLE.
    /// </summary>
    [JsonPropertyName("globalPolicyEvaluationMode")]
    public string? GlobalPolicyEvaluationMode { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusConditions
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

/// <summary>PolicyStatus defines the observed state of Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Policy is the Schema for the Policys API. A policy for container image binary authorization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PolicySpec>, IStatus<V1beta2PolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "binaryauthorization.gcp.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "binaryauthorization.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta2PolicyStatus? Status { get; set; }
}