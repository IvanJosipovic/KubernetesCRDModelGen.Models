#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudformation.aws.upbound.io;
/// <summary>StackSet is the Schema for the StackSets API. Manages a CloudFormation StackSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2StackSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2StackSet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "StackSetList";
    public const string KubeGroup = "cloudformation.aws.upbound.io";
    public const string KubePluralName = "stacksets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudformation.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StackSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2StackSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2StackSet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecDeletionPolicyEnum>))]
public enum V1beta2StackSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicyResolveEnum>))]
public enum V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderAdministrationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderAdministrationRoleArnSelector
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
    public V1beta2StackSetSpecForProviderAdministrationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderAutoDeployment
{
    /// <summary>Whether or not auto-deployment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether or not to retain stacks when the account is removed.</summary>
    [JsonPropertyName("retainStacksOnAccountRemoval")]
    public bool? RetainStacksOnAccountRemoval { get; set; }
}

/// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderManagedExecution
{
    /// <summary>When set to true, StackSets performs non-conflicting operations concurrently and queues conflicting operations. After conflicting operations finish, StackSets starts queued operations in request order. Default is false.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProviderOperationPreferences
{
    /// <summary>The number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>The percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>The maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>The maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecForProvider
{
    /// <summary>Amazon Resource Number (ARN) of the IAM Role in the administrator account. This must be defined when using the SELF_MANAGED permission model.</summary>
    [JsonPropertyName("administrationRoleArn")]
    public string? AdministrationRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnRef")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnRef? AdministrationRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnSelector")]
    public V1beta2StackSetSpecForProviderAdministrationRoleArnSelector? AdministrationRoleArnSelector { get; set; }

    /// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("autoDeployment")]
    public V1beta2StackSetSpecForProviderAutoDeployment? AutoDeployment { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization&apos;s management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>A list of capabilities. Valid values: CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_AUTO_EXPAND.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Description of the StackSet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the IAM Role in all target accounts for StackSet operations. Defaults to AWSCloudFormationStackSetExecutionRole when using the SELF_MANAGED permission model. This should not be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("executionRoleName")]
    public string? ExecutionRoleName { get; set; }

    /// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
    [JsonPropertyName("managedExecution")]
    public V1beta2StackSetSpecForProviderManagedExecution? ManagedExecution { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
    [JsonPropertyName("operationPreferences")]
    public V1beta2StackSetSpecForProviderOperationPreferences? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters for the StackSet template. All template parameters, including those with a Default, must be configured or ignored with lifecycle configuration block ignore_changes argument. All NoEcho template parameters must be ignored with the lifecycle configuration block ignore_changes argument.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Describes how the IAM roles required for your StackSet are created. Valid values: SELF_MANAGED (default), SERVICE_MANAGED.</summary>
    [JsonPropertyName("permissionModel")]
    public string? PermissionModel { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>String containing the CloudFormation template body. Maximum size: 51,200 bytes. Conflicts with template_url.</summary>
    [JsonPropertyName("templateBody")]
    public string? TemplateBody { get; set; }

    /// <summary>String containing the location of a file containing the CloudFormation template body. The URL must point to a template that is located in an Amazon S3 bucket. Maximum location file size: 460,800 bytes. Conflicts with template_body.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolveEnum>))]
public enum V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderAdministrationRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderAdministrationRoleArnSelector
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
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderAutoDeployment
{
    /// <summary>Whether or not auto-deployment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether or not to retain stacks when the account is removed.</summary>
    [JsonPropertyName("retainStacksOnAccountRemoval")]
    public bool? RetainStacksOnAccountRemoval { get; set; }
}

/// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderManagedExecution
{
    /// <summary>When set to true, StackSets performs non-conflicting operations concurrently and queues conflicting operations. After conflicting operations finish, StackSets starts queued operations in request order. Default is false.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecInitProviderOperationPreferences
{
    /// <summary>The number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>The percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>The maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>The maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
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
public partial class V1beta2StackSetSpecInitProvider
{
    /// <summary>Amazon Resource Number (ARN) of the IAM Role in the administrator account. This must be defined when using the SELF_MANAGED permission model.</summary>
    [JsonPropertyName("administrationRoleArn")]
    public string? AdministrationRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnRef")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnRef? AdministrationRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate administrationRoleArn.</summary>
    [JsonPropertyName("administrationRoleArnSelector")]
    public V1beta2StackSetSpecInitProviderAdministrationRoleArnSelector? AdministrationRoleArnSelector { get; set; }

    /// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("autoDeployment")]
    public V1beta2StackSetSpecInitProviderAutoDeployment? AutoDeployment { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization&apos;s management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>A list of capabilities. Valid values: CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_AUTO_EXPAND.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Description of the StackSet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the IAM Role in all target accounts for StackSet operations. Defaults to AWSCloudFormationStackSetExecutionRole when using the SELF_MANAGED permission model. This should not be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("executionRoleName")]
    public string? ExecutionRoleName { get; set; }

    /// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
    [JsonPropertyName("managedExecution")]
    public V1beta2StackSetSpecInitProviderManagedExecution? ManagedExecution { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
    [JsonPropertyName("operationPreferences")]
    public V1beta2StackSetSpecInitProviderOperationPreferences? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters for the StackSet template. All template parameters, including those with a Default, must be configured or ignored with lifecycle configuration block ignore_changes argument. All NoEcho template parameters must be ignored with the lifecycle configuration block ignore_changes argument.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Describes how the IAM roles required for your StackSet are created. Valid values: SELF_MANAGED (default), SERVICE_MANAGED.</summary>
    [JsonPropertyName("permissionModel")]
    public string? PermissionModel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>String containing the CloudFormation template body. Maximum size: 51,200 bytes. Conflicts with template_url.</summary>
    [JsonPropertyName("templateBody")]
    public string? TemplateBody { get; set; }

    /// <summary>String containing the location of a file containing the CloudFormation template body. The URL must point to a template that is located in an Amazon S3 bucket. Maximum location file size: 460,800 bytes. Conflicts with template_body.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecManagementPoliciesEnum>))]
public enum V1beta2StackSetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2StackSetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StackSetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2StackSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StackSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StackSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StackSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>StackSetSpec defines the desired state of StackSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetSpec
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
    public V1beta2StackSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2StackSetSpecForProvider ForProvider { get; set; }

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
    public V1beta2StackSetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2StackSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2StackSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2StackSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetStatusAtProviderAutoDeployment
{
    /// <summary>Whether or not auto-deployment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether or not to retain stacks when the account is removed.</summary>
    [JsonPropertyName("retainStacksOnAccountRemoval")]
    public bool? RetainStacksOnAccountRemoval { get; set; }
}

/// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetStatusAtProviderManagedExecution
{
    /// <summary>When set to true, StackSets performs non-conflicting operations concurrently and queues conflicting operations. After conflicting operations finish, StackSets starts queued operations in request order. Default is false.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetStatusAtProviderOperationPreferences
{
    /// <summary>The number of accounts, per Region, for which this operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureToleranceCount")]
    public double? FailureToleranceCount { get; set; }

    /// <summary>The percentage of accounts, per Region, for which this stack operation can fail before AWS CloudFormation stops the operation in that Region.</summary>
    [JsonPropertyName("failureTolerancePercentage")]
    public double? FailureTolerancePercentage { get; set; }

    /// <summary>The maximum number of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentCount")]
    public double? MaxConcurrentCount { get; set; }

    /// <summary>The maximum percentage of accounts in which to perform this operation at one time.</summary>
    [JsonPropertyName("maxConcurrentPercentage")]
    public double? MaxConcurrentPercentage { get; set; }

    /// <summary>The concurrency type of deploying StackSets operations in Regions, could be in parallel or one Region at a time.</summary>
    [JsonPropertyName("regionConcurrencyType")]
    public string? RegionConcurrencyType { get; set; }

    /// <summary>The order of the Regions in where you want to perform the stack operation.</summary>
    [JsonPropertyName("regionOrder")]
    public IList<string>? RegionOrder { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetStatusAtProvider
{
    /// <summary>Amazon Resource Number (ARN) of the IAM Role in the administrator account. This must be defined when using the SELF_MANAGED permission model.</summary>
    [JsonPropertyName("administrationRoleArn")]
    public string? AdministrationRoleArn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the StackSet.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block containing the auto-deployment model for your StackSet. This can only be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("autoDeployment")]
    public V1beta2StackSetStatusAtProviderAutoDeployment? AutoDeployment { get; set; }

    /// <summary>Specifies whether you are acting as an account administrator in the organization&apos;s management account or as a delegated administrator in a member account. Valid values: SELF (default), DELEGATED_ADMIN.</summary>
    [JsonPropertyName("callAs")]
    public string? CallAs { get; set; }

    /// <summary>A list of capabilities. Valid values: CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_AUTO_EXPAND.</summary>
    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    /// <summary>Description of the StackSet.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name of the IAM Role in all target accounts for StackSet operations. Defaults to AWSCloudFormationStackSetExecutionRole when using the SELF_MANAGED permission model. This should not be defined when using the SERVICE_MANAGED permission model.</summary>
    [JsonPropertyName("executionRoleName")]
    public string? ExecutionRoleName { get; set; }

    /// <summary>Name of the StackSet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block to allow StackSets to perform non-conflicting operations concurrently and queues conflicting operations.</summary>
    [JsonPropertyName("managedExecution")]
    public V1beta2StackSetStatusAtProviderManagedExecution? ManagedExecution { get; set; }

    /// <summary>Preferences for how AWS CloudFormation performs a stack set update.</summary>
    [JsonPropertyName("operationPreferences")]
    public V1beta2StackSetStatusAtProviderOperationPreferences? OperationPreferences { get; set; }

    /// <summary>Key-value map of input parameters for the StackSet template. All template parameters, including those with a Default, must be configured or ignored with lifecycle configuration block ignore_changes argument. All NoEcho template parameters must be ignored with the lifecycle configuration block ignore_changes argument.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Describes how the IAM roles required for your StackSet are created. Valid values: SELF_MANAGED (default), SERVICE_MANAGED.</summary>
    [JsonPropertyName("permissionModel")]
    public string? PermissionModel { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Unique identifier of the StackSet.</summary>
    [JsonPropertyName("stackSetId")]
    public string? StackSetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>String containing the CloudFormation template body. Maximum size: 51,200 bytes. Conflicts with template_url.</summary>
    [JsonPropertyName("templateBody")]
    public string? TemplateBody { get; set; }

    /// <summary>String containing the location of a file containing the CloudFormation template body. The URL must point to a template that is located in an Amazon S3 bucket. Maximum location file size: 460,800 bytes. Conflicts with template_body.</summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetStatusConditions
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

/// <summary>StackSetStatus defines the observed state of StackSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StackSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2StackSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2StackSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StackSet is the Schema for the StackSets API. Manages a CloudFormation StackSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2StackSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2StackSetSpec>, IStatus<V1beta2StackSetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "StackSet";
    public const string KubeGroup = "cloudformation.aws.upbound.io";
    public const string KubePluralName = "stacksets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudformation.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StackSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StackSetSpec defines the desired state of StackSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2StackSetSpec Spec { get; set; }

    /// <summary>StackSetStatus defines the observed state of StackSet.</summary>
    [JsonPropertyName("status")]
    public V1beta2StackSetStatus? Status { get; set; }
}