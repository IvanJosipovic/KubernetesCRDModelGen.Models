#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accessanalyzer.aws.upbound.io;
/// <summary>Analyzer is the Schema for the Analyzers API. Manages an Access Analyzer Analyzer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AnalyzerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Analyzer>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AnalyzerList";
    public const string KubeGroup = "accessanalyzer.aws.upbound.io";
    public const string KubePluralName = "analyzers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accessanalyzer.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AnalyzerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Analyzer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Analyzer> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyzerSpecDeletionPolicyEnum>))]
public enum V1beta2AnalyzerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRuleInclusion
{
    /// <summary>List of AWS account IDs to apply to the internal access analysis rule criteria. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of resource ARNs to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources that match these ARNs.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>List of resource types to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources of these types. Refer to InternalAccessAnalysisRuleCriteria in the AWS IAM Access Analyzer API Reference for valid values.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRule
{
    /// <summary>List of rules for the internal access analyzer containing criteria to include in analysis. Only resources that meet the rule criteria will generate findings. See inclusion Block for details.</summary>
    [JsonPropertyName("inclusion")]
    public IList<V1beta2AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRuleInclusion>? Inclusion { get; set; }
}

/// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfigurationInternalAccess
{
    /// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta2AnalyzerSpecForProviderConfigurationInternalAccessAnalysisRule? AnalysisRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRuleExclusion
{
    /// <summary>List of AWS account IDs to apply to the analysis rule criteria. The accounts cannot include the organization analyzer owner account. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of key-value pairs for resource tags to exclude from the analysis.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<IDictionary<string, string>>? ResourceTags { get; set; }
}

/// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRule
{
    /// <summary>List of rules for the analyzer containing criteria to exclude from analysis. Entities that meet the rule criteria will not generate findings. See exclusion Block for details.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRuleExclusion>? Exclusion { get; set; }
}

/// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfigurationUnusedAccess
{
    /// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta2AnalyzerSpecForProviderConfigurationUnusedAccessAnalysisRule? AnalysisRule { get; set; }

    /// <summary>Specified access age in days for which to generate findings for unused access.</summary>
    [JsonPropertyName("unusedAccessAge")]
    public double? UnusedAccessAge { get; set; }
}

/// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProviderConfiguration
{
    /// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
    [JsonPropertyName("internalAccess")]
    public V1beta2AnalyzerSpecForProviderConfigurationInternalAccess? InternalAccess { get; set; }

    /// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
    [JsonPropertyName("unusedAccess")]
    public V1beta2AnalyzerSpecForProviderConfigurationUnusedAccess? UnusedAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecForProvider
{
    /// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2AnalyzerSpecForProviderConfiguration? Configuration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type that represents the zone of trust or scope for the analyzer. Valid values are ACCOUNT, ACCOUNT_INTERNAL_ACCESS, ACCOUNT_UNUSED_ACCESS, ORGANIZATION, ORGANIZATION_INTERNAL_ACCESS, ORGANIZATION_UNUSED_ACCESS. Defaults to ACCOUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRuleInclusion
{
    /// <summary>List of AWS account IDs to apply to the internal access analysis rule criteria. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of resource ARNs to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources that match these ARNs.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>List of resource types to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources of these types. Refer to InternalAccessAnalysisRuleCriteria in the AWS IAM Access Analyzer API Reference for valid values.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRule
{
    /// <summary>List of rules for the internal access analyzer containing criteria to include in analysis. Only resources that meet the rule criteria will generate findings. See inclusion Block for details.</summary>
    [JsonPropertyName("inclusion")]
    public IList<V1beta2AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRuleInclusion>? Inclusion { get; set; }
}

/// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfigurationInternalAccess
{
    /// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta2AnalyzerSpecInitProviderConfigurationInternalAccessAnalysisRule? AnalysisRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRuleExclusion
{
    /// <summary>List of AWS account IDs to apply to the analysis rule criteria. The accounts cannot include the organization analyzer owner account. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of key-value pairs for resource tags to exclude from the analysis.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<IDictionary<string, string>>? ResourceTags { get; set; }
}

/// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRule
{
    /// <summary>List of rules for the analyzer containing criteria to exclude from analysis. Entities that meet the rule criteria will not generate findings. See exclusion Block for details.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRuleExclusion>? Exclusion { get; set; }
}

/// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfigurationUnusedAccess
{
    /// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta2AnalyzerSpecInitProviderConfigurationUnusedAccessAnalysisRule? AnalysisRule { get; set; }

    /// <summary>Specified access age in days for which to generate findings for unused access.</summary>
    [JsonPropertyName("unusedAccessAge")]
    public double? UnusedAccessAge { get; set; }
}

/// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecInitProviderConfiguration
{
    /// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
    [JsonPropertyName("internalAccess")]
    public V1beta2AnalyzerSpecInitProviderConfigurationInternalAccess? InternalAccess { get; set; }

    /// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
    [JsonPropertyName("unusedAccess")]
    public V1beta2AnalyzerSpecInitProviderConfigurationUnusedAccess? UnusedAccess { get; set; }
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
public partial class V1beta2AnalyzerSpecInitProvider
{
    /// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2AnalyzerSpecInitProviderConfiguration? Configuration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type that represents the zone of trust or scope for the analyzer. Valid values are ACCOUNT, ACCOUNT_INTERNAL_ACCESS, ACCOUNT_UNUSED_ACCESS, ORGANIZATION, ORGANIZATION_INTERNAL_ACCESS, ORGANIZATION_UNUSED_ACCESS. Defaults to ACCOUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyzerSpecManagementPoliciesEnum>))]
public enum V1beta2AnalyzerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyzerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AnalyzerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AnalyzerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AnalyzerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AnalyzerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AnalyzerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AnalyzerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AnalyzerSpec defines the desired state of Analyzer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerSpec
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
    public V1beta2AnalyzerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AnalyzerSpecForProvider ForProvider { get; set; }

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
    public V1beta2AnalyzerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AnalyzerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AnalyzerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AnalyzerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRuleInclusion
{
    /// <summary>List of AWS account IDs to apply to the internal access analysis rule criteria. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of resource ARNs to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources that match these ARNs.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>List of resource types to apply to the internal access analysis rule criteria. The analyzer will only generate findings for resources of these types. Refer to InternalAccessAnalysisRuleCriteria in the AWS IAM Access Analyzer API Reference for valid values.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRule
{
    /// <summary>List of rules for the internal access analyzer containing criteria to include in analysis. Only resources that meet the rule criteria will generate findings. See inclusion Block for details.</summary>
    [JsonPropertyName("inclusion")]
    public IList<V1beta2AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRuleInclusion>? Inclusion { get; set; }
}

/// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfigurationInternalAccess
{
    /// <summary>Information about analysis rules for the internal access analyzer. These rules determine which resources and access patterns will be analyzed. See analysis_rule Block for Internal Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta2AnalyzerStatusAtProviderConfigurationInternalAccessAnalysisRule? AnalysisRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRuleExclusion
{
    /// <summary>List of AWS account IDs to apply to the analysis rule criteria. The accounts cannot include the organization analyzer owner account. Account IDs can only be applied to the analysis rule criteria for organization-level analyzers.</summary>
    [JsonPropertyName("accountIds")]
    public IList<string>? AccountIds { get; set; }

    /// <summary>List of key-value pairs for resource tags to exclude from the analysis.</summary>
    [JsonPropertyName("resourceTags")]
    public IList<IDictionary<string, string>>? ResourceTags { get; set; }
}

/// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRule
{
    /// <summary>List of rules for the analyzer containing criteria to exclude from analysis. Entities that meet the rule criteria will not generate findings. See exclusion Block for details.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRuleExclusion>? Exclusion { get; set; }
}

/// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfigurationUnusedAccess
{
    /// <summary>Information about analysis rules for the analyzer. Analysis rules determine which entities will generate findings based on the criteria you define when you create the rule. See analysis_rule Block for Unused Access Analyzer for details.</summary>
    [JsonPropertyName("analysisRule")]
    public V1beta2AnalyzerStatusAtProviderConfigurationUnusedAccessAnalysisRule? AnalysisRule { get; set; }

    /// <summary>Specified access age in days for which to generate findings for unused access.</summary>
    [JsonPropertyName("unusedAccessAge")]
    public double? UnusedAccessAge { get; set; }
}

/// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProviderConfiguration
{
    /// <summary>Specifies the configuration of an internal access analyzer for an AWS organization or account. This configuration determines how the analyzer evaluates access within your AWS environment. See internal_access Block for details.</summary>
    [JsonPropertyName("internalAccess")]
    public V1beta2AnalyzerStatusAtProviderConfigurationInternalAccess? InternalAccess { get; set; }

    /// <summary>Specifies the configuration of an unused access analyzer for an AWS organization or account. See unused_access Block for details.</summary>
    [JsonPropertyName("unusedAccess")]
    public V1beta2AnalyzerStatusAtProviderConfigurationUnusedAccess? UnusedAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusAtProvider
{
    /// <summary>ARN of the Analyzer.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A block that specifies the configuration of the analyzer. See configuration Block for details.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2AnalyzerStatusAtProviderConfiguration? Configuration { get; set; }

    /// <summary>Name of the analyzer.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Type that represents the zone of trust or scope for the analyzer. Valid values are ACCOUNT, ACCOUNT_INTERNAL_ACCESS, ACCOUNT_UNUSED_ACCESS, ORGANIZATION, ORGANIZATION_INTERNAL_ACCESS, ORGANIZATION_UNUSED_ACCESS. Defaults to ACCOUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatusConditions
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

/// <summary>AnalyzerStatus defines the observed state of Analyzer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AnalyzerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AnalyzerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AnalyzerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Analyzer is the Schema for the Analyzers API. Manages an Access Analyzer Analyzer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Analyzer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AnalyzerSpec>, IStatus<V1beta2AnalyzerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Analyzer";
    public const string KubeGroup = "accessanalyzer.aws.upbound.io";
    public const string KubePluralName = "analyzers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accessanalyzer.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Analyzer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AnalyzerSpec defines the desired state of Analyzer</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AnalyzerSpec Spec { get; set; }

    /// <summary>AnalyzerStatus defines the observed state of Analyzer.</summary>
    [JsonPropertyName("status")]
    public V1beta2AnalyzerStatus? Status { get; set; }
}