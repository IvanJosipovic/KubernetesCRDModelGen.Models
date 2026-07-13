#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudformation.aws.m.upbound.io;
/// <summary>StackSetInstance is the Schema for the StackSetInstances API. Manages a CloudFormation StackSet Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StackSetInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StackSetInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StackSetInstanceList";
    public const string KubeGroup = "cloudformation.aws.m.upbound.io";
    public const string KubePluralName = "stacksetinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudformation.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StackSetInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1StackSetInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1StackSetInstance> Items { get; set; }
}

/// <summary>AWS Organizations accounts to which StackSets deploys. StackSets doesn&apos;t deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderDeploymentTargets
{
    /// <summary>Limit deployment targets to individual accounts or include additional accounts with provided OUs. Valid values: INTERSECTION, DIFFERENCE, UNION, NONE.</summary>
    [JsonPropertyName("accountFilterType")]
    public string? AccountFilterType { get; set; }

    /// <summary>List of accounts to deploy stack set updates.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>S3 URL of the file containing the list of accounts.</summary>
    [JsonPropertyName("accountsUrl")]
    public string? AccountsUrl { get; set; }

    /// <summary>Organization root ID or organizational unit (OU) IDs to which StackSets deploys.</summary>
    [JsonPropertyName("organizationalUnitIds")]
    public IList<string>? OrganizationalUnitIds { get; set; }
}

/// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderOperationPreferences
{
    /// <summary>Specifies how the concurrency level behaves during the operation execution. Valid values are STRICT_FAILURE_TOLERANCE and SOFT_FAILURE_TOLERANCE.</summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>Number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>Percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>Maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>Maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>Concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time. Valid values are SEQUENTIAL and PARALLEL.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>Order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolutionEnum>))]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolveEnum>))]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolutionEnum>))]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolveEnum>))]
public enum V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProviderStackSetNameSelector
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
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecForProvider
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization&apos;s management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>AWS Organizations accounts to which StackSets deploys. StackSets doesn&apos;t deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
    [JsonPropertyName("deploymentTargets")]
    public V1beta1StackSetInstanceSpecForProviderDeploymentTargets? DeploymentTargets { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
    [JsonPropertyName("operationPreferences")]
    public V1beta1StackSetInstanceSpecForProviderOperationPreferences? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters to override from the StackSet for this Instance.</summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>
    /// Target AWS Region to create a Stack based on the StackSet. Defaults to current region. Use stack_set_instance_region instead.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>You cannot reassociate a retained Stack or add an existing, saved Stack to a new StackSet. Defaults to false.</summary>
    [JsonPropertyName("retainStack")]
    public bool? RetainStack { get; set; }

    /// <summary>Target AWS Region to create a Stack based on the StackSet. Defaults to current region.</summary>
    [JsonPropertyName("stackSetInstanceRegion")]
    public string? StackSetInstanceRegion { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("stackSetName")]
    public string? StackSetName { get; set; }

    /// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameRef")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameRef? StackSetNameRef { get; set; }

    /// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameSelector")]
    public V1beta1StackSetInstanceSpecForProviderStackSetNameSelector? StackSetNameSelector { get; set; }
}

/// <summary>AWS Organizations accounts to which StackSets deploys. StackSets doesn&apos;t deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderDeploymentTargets
{
    /// <summary>Limit deployment targets to individual accounts or include additional accounts with provided OUs. Valid values: INTERSECTION, DIFFERENCE, UNION, NONE.</summary>
    [JsonPropertyName("accountFilterType")]
    public string? AccountFilterType { get; set; }

    /// <summary>List of accounts to deploy stack set updates.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>S3 URL of the file containing the list of accounts.</summary>
    [JsonPropertyName("accountsUrl")]
    public string? AccountsUrl { get; set; }

    /// <summary>Organization root ID or organizational unit (OU) IDs to which StackSets deploys.</summary>
    [JsonPropertyName("organizationalUnitIds")]
    public IList<string>? OrganizationalUnitIds { get; set; }
}

/// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderOperationPreferences
{
    /// <summary>Specifies how the concurrency level behaves during the operation execution. Valid values are STRICT_FAILURE_TOLERANCE and SOFT_FAILURE_TOLERANCE.</summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>Number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>Percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>Maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>Maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>Concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time. Valid values are SEQUENTIAL and PARALLEL.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>Order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolutionEnum>))]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolveEnum>))]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolutionEnum>))]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolveEnum>))]
public enum V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpecInitProviderStackSetNameSelector
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
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1StackSetInstanceSpecInitProvider
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization&apos;s management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>AWS Organizations accounts to which StackSets deploys. StackSets doesn&apos;t deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
    [JsonPropertyName("deploymentTargets")]
    public V1beta1StackSetInstanceSpecInitProviderDeploymentTargets? DeploymentTargets { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
    [JsonPropertyName("operationPreferences")]
    public V1beta1StackSetInstanceSpecInitProviderOperationPreferences? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters to override from the StackSet for this Instance.</summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>You cannot reassociate a retained Stack or add an existing, saved Stack to a new StackSet. Defaults to false.</summary>
    [JsonPropertyName("retainStack")]
    public bool? RetainStack { get; set; }

    /// <summary>Target AWS Region to create a Stack based on the StackSet. Defaults to current region.</summary>
    [JsonPropertyName("stackSetInstanceRegion")]
    public string? StackSetInstanceRegion { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("stackSetName")]
    public string? StackSetName { get; set; }

    /// <summary>Reference to a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameRef")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameRef? StackSetNameRef { get; set; }

    /// <summary>Selector for a StackSet in cloudformation to populate stackSetName.</summary>
    [JsonPropertyName("stackSetNameSelector")]
    public V1beta1StackSetInstanceSpecInitProviderStackSetNameSelector? StackSetNameSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StackSetInstanceSpecManagementPoliciesEnum>))]
public enum V1beta1StackSetInstanceSpecManagementPoliciesEnum
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
public partial class V1beta1StackSetInstanceSpecProviderConfigRef
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
public partial class V1beta1StackSetInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>StackSetInstanceSpec defines the desired state of StackSetInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1StackSetInstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta1StackSetInstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1StackSetInstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StackSetInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StackSetInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>AWS Organizations accounts to which StackSets deploys. StackSets doesn&apos;t deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProviderDeploymentTargets
{
    /// <summary>Limit deployment targets to individual accounts or include additional accounts with provided OUs. Valid values: INTERSECTION, DIFFERENCE, UNION, NONE.</summary>
    [JsonPropertyName("accountFilterType")]
    public string? AccountFilterType { get; set; }

    /// <summary>List of accounts to deploy stack set updates.</summary>
    [JsonPropertyName("accounts")]
    public IList<string>? Accounts { get; set; }

    /// <summary>S3 URL of the file containing the list of accounts.</summary>
    [JsonPropertyName("accountsUrl")]
    public string? AccountsUrl { get; set; }

    /// <summary>Organization root ID or organizational unit (OU) IDs to which StackSets deploys.</summary>
    [JsonPropertyName("organizationalUnitIds")]
    public IList<string>? OrganizationalUnitIds { get; set; }
}

/// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProviderOperationPreferences
{
    /// <summary>Specifies how the concurrency level behaves during the operation execution. Valid values are STRICT_FAILURE_TOLERANCE and SOFT_FAILURE_TOLERANCE.</summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>Number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>Percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>Maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>Maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>Concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time. Valid values are SEQUENTIAL and PARALLEL.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>Order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProviderStackInstanceSummaries
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Organization root ID or organizational unit (OU) ID in which the stack is deployed.</summary>
    [JsonPropertyName("organizationalUnitId")]
    public string? OrganizationalUnitId { get; set; }

    /// <summary>Stack identifier.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusAtProvider
{
    /// <summary>Target AWS Account ID to create a Stack based on the StackSet. Defaults to current account.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization&apos;s management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>AWS Organizations accounts to which StackSets deploys. StackSets doesn&apos;t deploy stack instances to the organization management account, even if the organization management account is in your organization or in an OU in your organization. Drift detection is not possible for this argument. See deployment_targets below.</summary>
    [JsonPropertyName("deploymentTargets")]
    public V1beta1StackSetInstanceStatusAtProviderDeploymentTargets? DeploymentTargets { get; set; }

    /// <summary>Unique identifier for the resource. If deployment_targets is set, this is a comma-delimited string combining stack set name, organizational unit IDs (/-delimited), and region (ie. mystack,ou-123/ou-456,us-east-1). Otherwise, this is a comma-delimited string combining stack set name, AWS account ID, and region (ie. mystack,123456789012,us-east-1).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set operation.</summary>
    [JsonPropertyName("operationPreferences")]
    public V1beta1StackSetInstanceStatusAtProviderOperationPreferences? OperationPreferences { get; set; }

    /// <summary>Organization root ID or organizational unit (OU) ID in which the stack is deployed.</summary>
    [JsonPropertyName("organizationalUnitId")]
    public string? OrganizationalUnitId { get; set; }

    /// <summary>Key-value map of input parameters to override from the StackSet for this Instance.</summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>
    /// Target AWS Region to create a Stack based on the StackSet. Defaults to current region. Use stack_set_instance_region instead.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>You cannot reassociate a retained Stack or add an existing, saved Stack to a new StackSet. Defaults to false.</summary>
    [JsonPropertyName("retainStack")]
    public bool? RetainStack { get; set; }

    /// <summary>Stack identifier.</summary>
    [JsonPropertyName("stackId")]
    public string? StackId { get; set; }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when deployment_targets is set. See stack_instance_summaries.
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    [JsonPropertyName("stackInstanceSummaries")]
    public IList<V1beta1StackSetInstanceStatusAtProviderStackInstanceSummaries>? StackInstanceSummaries { get; set; }

    /// <summary>Target AWS Region to create a Stack based on the StackSet. Defaults to current region.</summary>
    [JsonPropertyName("stackSetInstanceRegion")]
    public string? StackSetInstanceRegion { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("stackSetName")]
    public string? StackSetName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatusConditions
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

/// <summary>StackSetInstanceStatus defines the observed state of StackSetInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StackSetInstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1StackSetInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StackSetInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StackSetInstance is the Schema for the StackSetInstances API. Manages a CloudFormation StackSet Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StackSetInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StackSetInstanceSpec>, IStatus<V1beta1StackSetInstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StackSetInstance";
    public const string KubeGroup = "cloudformation.aws.m.upbound.io";
    public const string KubePluralName = "stacksetinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudformation.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StackSetInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StackSetInstanceSpec defines the desired state of StackSetInstance</summary>
    [JsonPropertyName("spec")]
    public required V1beta1StackSetInstanceSpec Spec { get; set; }

    /// <summary>StackSetInstanceStatus defines the observed state of StackSetInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1StackSetInstanceStatus? Status { get; set; }
}