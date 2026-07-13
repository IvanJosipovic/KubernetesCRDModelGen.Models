#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.fis.aws.upbound.io;
/// <summary>ExperimentTemplate is the Schema for the ExperimentTemplates API. Provides an FIS Experiment Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ExperimentTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ExperimentTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ExperimentTemplateList";
    public const string KubeGroup = "fis.aws.upbound.io";
    public const string KubePluralName = "experimenttemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "fis.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExperimentTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ExperimentTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ExperimentTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2ExperimentTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderActionParameter
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Action&apos;s target, if applicable. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderActionTarget
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Target name, referencing a corresponding target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderAction
{
    /// <summary>ID of the action. To find out what actions are supported see AWS FIS actions reference.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>Description of the action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameter(s) for the action, if applicable. See below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ExperimentTemplateSpecForProviderActionParameter>? Parameter { get; set; }

    /// <summary>Set of action names that must complete before this action can be executed.</summary>
    [JsonPropertyName("startAfter")]
    public IList<string>? StartAfter { get; set; }

    /// <summary>Action&apos;s target, if applicable. See below.</summary>
    [JsonPropertyName("target")]
    public V1beta2ExperimentTemplateSpecForProviderActionTarget? Target { get; set; }
}

/// <summary>The experiment options for the experiment template. See experiment_options below for more details!</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentOptions
{
    /// <summary>Specifies the account targeting setting for experiment options. Supports single-account and multi-account.</summary>
    [JsonPropertyName("accountTargeting")]
    public string? AccountTargeting { get; set; }

    /// <summary>Specifies the empty target resolution mode for experiment options. Supports fail and skip.</summary>
    [JsonPropertyName("emptyTargetResolutionMode")]
    public string? EmptyTargetResolutionMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dashboard in cloudwatch to populate dashboardArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dashboard in cloudwatch to populate dashboardArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelector
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
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboard
{
    /// <summary>The ARN of the CloudWatch dashboard.</summary>
    [JsonPropertyName("dashboardArn")]
    public string? DashboardArn { get; set; }

    /// <summary>Reference to a Dashboard in cloudwatch to populate dashboardArn.</summary>
    [JsonPropertyName("dashboardArnRef")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRef? DashboardArnRef { get; set; }

    /// <summary>Selector for a Dashboard in cloudwatch to populate dashboardArn.</summary>
    [JsonPropertyName("dashboardArnSelector")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelector? DashboardArnSelector { get; set; }
}

/// <summary>The data sources for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSources
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("cloudwatchDashboard")]
    public IList<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSourcesCloudwatchDashboard>? CloudwatchDashboard { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelector
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
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The data sources for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The outputs for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputs
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputsS3Configuration? S3Configuration { get; set; }
}

/// <summary>The configuration for experiment reporting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderExperimentReportConfiguration
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationDataSources? DataSources { get; set; }

    /// <summary>The outputs for the experiment report. See below.</summary>
    [JsonPropertyName("outputs")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfigurationOutputs? Outputs { get; set; }

    /// <summary>The duration of the post-experiment period. Defaults to PT20M.</summary>
    [JsonPropertyName("postExperimentDuration")]
    public string? PostExperimentDuration { get; set; }

    /// <summary>The duration of the pre-experiment period. Defaults to PT20M.</summary>
    [JsonPropertyName("preExperimentDuration")]
    public string? PreExperimentDuration { get; set; }
}

/// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderLogConfigurationCloudwatchLogsConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the destination Amazon CloudWatch Logs log group. The ARN must end with :*</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderLogConfigurationS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The configuration for experiment logging. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderLogConfiguration
{
    /// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogsConfiguration")]
    public V1beta2ExperimentTemplateSpecForProviderLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfiguration { get; set; }

    /// <summary>The schema version. See documentation for the list of schema versions.</summary>
    [JsonPropertyName("logSchemaVersion")]
    public double? LogSchemaVersion { get; set; }

    /// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2ExperimentTemplateSpecForProviderLogConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderRoleArnSelector
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
    public V1beta2ExperimentTemplateSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderStopCondition
{
    /// <summary>Source of the condition. One of none, aws:cloudwatch:alarm.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the CloudWatch alarm. Required if the source is a CloudWatch alarm.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderTargetFilter
{
    /// <summary>Attribute path for the filter.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Set of attribute values for the filter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderTargetResourceTag
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProviderTarget
{
    /// <summary>Filter(s) for the target. Filters can be used to select resources based on specific attributes returned by the respective describe action of the resource type. For more information, see Targets for AWS FIS. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta2ExperimentTemplateSpecForProviderTargetFilter>? Filter { get; set; }

    /// <summary>Friendly name given to the target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource type parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of the resources to target with an action. Conflicts with resource_tag.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>Tag(s) the resources need to have to be considered a valid target for an action. Conflicts with resource_arns. See below.</summary>
    [JsonPropertyName("resourceTag")]
    public IList<V1beta2ExperimentTemplateSpecForProviderTargetResourceTag>? ResourceTag { get; set; }

    /// <summary>AWS resource type. The resource type must be supported for the specified action. To find out what resource types are supported, see Targets for AWS FIS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scopes the identified resources. Valid values are ALL (all identified resources), COUNT(n) (randomly select n of the identified resources), PERCENT(n) (randomly select n percent of the identified resources).</summary>
    [JsonPropertyName("selectionMode")]
    public string? SelectionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecForProvider
{
    /// <summary>Action to be performed during an experiment. See below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2ExperimentTemplateSpecForProviderAction>? Action { get; set; }

    /// <summary>Description for the experiment template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The experiment options for the experiment template. See experiment_options below for more details!</summary>
    [JsonPropertyName("experimentOptions")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentOptions? ExperimentOptions { get; set; }

    /// <summary>The configuration for experiment reporting. See below.</summary>
    [JsonPropertyName("experimentReportConfiguration")]
    public V1beta2ExperimentTemplateSpecForProviderExperimentReportConfiguration? ExperimentReportConfiguration { get; set; }

    /// <summary>The configuration for experiment logging. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2ExperimentTemplateSpecForProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>ARN of an IAM role that grants the AWS FIS service permission to perform service actions on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ExperimentTemplateSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>When an ongoing experiment should be stopped. See below.</summary>
    [JsonPropertyName("stopCondition")]
    public IList<V1beta2ExperimentTemplateSpecForProviderStopCondition>? StopCondition { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target of an action. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta2ExperimentTemplateSpecForProviderTarget>? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderActionParameter
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Action&apos;s target, if applicable. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderActionTarget
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Target name, referencing a corresponding target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderAction
{
    /// <summary>ID of the action. To find out what actions are supported see AWS FIS actions reference.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>Description of the action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameter(s) for the action, if applicable. See below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderActionParameter>? Parameter { get; set; }

    /// <summary>Set of action names that must complete before this action can be executed.</summary>
    [JsonPropertyName("startAfter")]
    public IList<string>? StartAfter { get; set; }

    /// <summary>Action&apos;s target, if applicable. See below.</summary>
    [JsonPropertyName("target")]
    public V1beta2ExperimentTemplateSpecInitProviderActionTarget? Target { get; set; }
}

/// <summary>The experiment options for the experiment template. See experiment_options below for more details!</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentOptions
{
    /// <summary>Specifies the account targeting setting for experiment options. Supports single-account and multi-account.</summary>
    [JsonPropertyName("accountTargeting")]
    public string? AccountTargeting { get; set; }

    /// <summary>Specifies the empty target resolution mode for experiment options. Supports fail and skip.</summary>
    [JsonPropertyName("emptyTargetResolutionMode")]
    public string? EmptyTargetResolutionMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dashboard in cloudwatch to populate dashboardArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dashboard in cloudwatch to populate dashboardArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelector
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
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboard
{
    /// <summary>The ARN of the CloudWatch dashboard.</summary>
    [JsonPropertyName("dashboardArn")]
    public string? DashboardArn { get; set; }

    /// <summary>Reference to a Dashboard in cloudwatch to populate dashboardArn.</summary>
    [JsonPropertyName("dashboardArnRef")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnRef? DashboardArnRef { get; set; }

    /// <summary>Selector for a Dashboard in cloudwatch to populate dashboardArn.</summary>
    [JsonPropertyName("dashboardArnSelector")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboardDashboardArnSelector? DashboardArnSelector { get; set; }
}

/// <summary>The data sources for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSources
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("cloudwatchDashboard")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSourcesCloudwatchDashboard>? CloudwatchDashboard { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelector
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
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The data sources for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The outputs for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputs
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputsS3Configuration? S3Configuration { get; set; }
}

/// <summary>The configuration for experiment reporting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfiguration
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationDataSources? DataSources { get; set; }

    /// <summary>The outputs for the experiment report. See below.</summary>
    [JsonPropertyName("outputs")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfigurationOutputs? Outputs { get; set; }

    /// <summary>The duration of the post-experiment period. Defaults to PT20M.</summary>
    [JsonPropertyName("postExperimentDuration")]
    public string? PostExperimentDuration { get; set; }

    /// <summary>The duration of the pre-experiment period. Defaults to PT20M.</summary>
    [JsonPropertyName("preExperimentDuration")]
    public string? PreExperimentDuration { get; set; }
}

/// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderLogConfigurationCloudwatchLogsConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the destination Amazon CloudWatch Logs log group. The ARN must end with :*</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderLogConfigurationS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The configuration for experiment logging. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderLogConfiguration
{
    /// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogsConfiguration")]
    public V1beta2ExperimentTemplateSpecInitProviderLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfiguration { get; set; }

    /// <summary>The schema version. See documentation for the list of schema versions.</summary>
    [JsonPropertyName("logSchemaVersion")]
    public double? LogSchemaVersion { get; set; }

    /// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2ExperimentTemplateSpecInitProviderLogConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderRoleArnSelector
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
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderStopCondition
{
    /// <summary>Source of the condition. One of none, aws:cloudwatch:alarm.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the CloudWatch alarm. Required if the source is a CloudWatch alarm.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderTargetFilter
{
    /// <summary>Attribute path for the filter.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Set of attribute values for the filter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderTargetResourceTag
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecInitProviderTarget
{
    /// <summary>Filter(s) for the target. Filters can be used to select resources based on specific attributes returned by the respective describe action of the resource type. For more information, see Targets for AWS FIS. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderTargetFilter>? Filter { get; set; }

    /// <summary>Friendly name given to the target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource type parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of the resources to target with an action. Conflicts with resource_tag.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>Tag(s) the resources need to have to be considered a valid target for an action. Conflicts with resource_arns. See below.</summary>
    [JsonPropertyName("resourceTag")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderTargetResourceTag>? ResourceTag { get; set; }

    /// <summary>AWS resource type. The resource type must be supported for the specified action. To find out what resource types are supported, see Targets for AWS FIS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scopes the identified resources. Valid values are ALL (all identified resources), COUNT(n) (randomly select n of the identified resources), PERCENT(n) (randomly select n percent of the identified resources).</summary>
    [JsonPropertyName("selectionMode")]
    public string? SelectionMode { get; set; }
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
public partial class V1beta2ExperimentTemplateSpecInitProvider
{
    /// <summary>Action to be performed during an experiment. See below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderAction>? Action { get; set; }

    /// <summary>Description for the experiment template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The experiment options for the experiment template. See experiment_options below for more details!</summary>
    [JsonPropertyName("experimentOptions")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentOptions? ExperimentOptions { get; set; }

    /// <summary>The configuration for experiment reporting. See below.</summary>
    [JsonPropertyName("experimentReportConfiguration")]
    public V1beta2ExperimentTemplateSpecInitProviderExperimentReportConfiguration? ExperimentReportConfiguration { get; set; }

    /// <summary>The configuration for experiment logging. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2ExperimentTemplateSpecInitProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>ARN of an IAM role that grants the AWS FIS service permission to perform service actions on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ExperimentTemplateSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>When an ongoing experiment should be stopped. See below.</summary>
    [JsonPropertyName("stopCondition")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderStopCondition>? StopCondition { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Target of an action. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta2ExperimentTemplateSpecInitProviderTarget>? Target { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2ExperimentTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ExperimentTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExperimentTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ExperimentTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExperimentTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExperimentTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExperimentTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ExperimentTemplateSpec defines the desired state of ExperimentTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateSpec
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
    public V1beta2ExperimentTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ExperimentTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2ExperimentTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ExperimentTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ExperimentTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ExperimentTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderActionParameter
{
    /// <summary>Parameter name.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Action&apos;s target, if applicable. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderActionTarget
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Target name, referencing a corresponding target.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderAction
{
    /// <summary>ID of the action. To find out what actions are supported see AWS FIS actions reference.</summary>
    [JsonPropertyName("actionId")]
    public string? ActionId { get; set; }

    /// <summary>Description of the action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Friendly name of the action.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Parameter(s) for the action, if applicable. See below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderActionParameter>? Parameter { get; set; }

    /// <summary>Set of action names that must complete before this action can be executed.</summary>
    [JsonPropertyName("startAfter")]
    public IList<string>? StartAfter { get; set; }

    /// <summary>Action&apos;s target, if applicable. See below.</summary>
    [JsonPropertyName("target")]
    public V1beta2ExperimentTemplateStatusAtProviderActionTarget? Target { get; set; }
}

/// <summary>The experiment options for the experiment template. See experiment_options below for more details!</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderExperimentOptions
{
    /// <summary>Specifies the account targeting setting for experiment options. Supports single-account and multi-account.</summary>
    [JsonPropertyName("accountTargeting")]
    public string? AccountTargeting { get; set; }

    /// <summary>Specifies the empty target resolution mode for experiment options. Supports fail and skip.</summary>
    [JsonPropertyName("emptyTargetResolutionMode")]
    public string? EmptyTargetResolutionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationDataSourcesCloudwatchDashboard
{
    /// <summary>The ARN of the CloudWatch dashboard.</summary>
    [JsonPropertyName("dashboardArn")]
    public string? DashboardArn { get; set; }
}

/// <summary>The data sources for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationDataSources
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("cloudwatchDashboard")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationDataSourcesCloudwatchDashboard>? CloudwatchDashboard { get; set; }
}

/// <summary>The data sources for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationOutputsS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The outputs for the experiment report. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationOutputs
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationOutputsS3Configuration? S3Configuration { get; set; }
}

/// <summary>The configuration for experiment reporting. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfiguration
{
    /// <summary>The data sources for the experiment report. See below.</summary>
    [JsonPropertyName("dataSources")]
    public V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationDataSources? DataSources { get; set; }

    /// <summary>The outputs for the experiment report. See below.</summary>
    [JsonPropertyName("outputs")]
    public V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfigurationOutputs? Outputs { get; set; }

    /// <summary>The duration of the post-experiment period. Defaults to PT20M.</summary>
    [JsonPropertyName("postExperimentDuration")]
    public string? PostExperimentDuration { get; set; }

    /// <summary>The duration of the pre-experiment period. Defaults to PT20M.</summary>
    [JsonPropertyName("preExperimentDuration")]
    public string? PreExperimentDuration { get; set; }
}

/// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderLogConfigurationCloudwatchLogsConfiguration
{
    /// <summary>The Amazon Resource Name (ARN) of the destination Amazon CloudWatch Logs log group. The ARN must end with :*</summary>
    [JsonPropertyName("logGroupArn")]
    public string? LogGroupArn { get; set; }
}

/// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderLogConfigurationS3Configuration
{
    /// <summary>The name of the destination bucket.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The bucket prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The configuration for experiment logging. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderLogConfiguration
{
    /// <summary>The configuration for experiment logging to Amazon CloudWatch Logs. See below.</summary>
    [JsonPropertyName("cloudwatchLogsConfiguration")]
    public V1beta2ExperimentTemplateStatusAtProviderLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfiguration { get; set; }

    /// <summary>The schema version. See documentation for the list of schema versions.</summary>
    [JsonPropertyName("logSchemaVersion")]
    public double? LogSchemaVersion { get; set; }

    /// <summary>The configuration for experiment logging to Amazon S3. See below.</summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta2ExperimentTemplateStatusAtProviderLogConfigurationS3Configuration? S3Configuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderStopCondition
{
    /// <summary>Source of the condition. One of none, aws:cloudwatch:alarm.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the CloudWatch alarm. Required if the source is a CloudWatch alarm.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderTargetFilter
{
    /// <summary>Attribute path for the filter.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Set of attribute values for the filter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderTargetResourceTag
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProviderTarget
{
    /// <summary>Filter(s) for the target. Filters can be used to select resources based on specific attributes returned by the respective describe action of the resource type. For more information, see Targets for AWS FIS. See below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderTargetFilter>? Filter { get; set; }

    /// <summary>Friendly name given to the target.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource type parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Set of ARNs of the resources to target with an action. Conflicts with resource_tag.</summary>
    [JsonPropertyName("resourceArns")]
    public IList<string>? ResourceArns { get; set; }

    /// <summary>Tag(s) the resources need to have to be considered a valid target for an action. Conflicts with resource_arns. See below.</summary>
    [JsonPropertyName("resourceTag")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderTargetResourceTag>? ResourceTag { get; set; }

    /// <summary>AWS resource type. The resource type must be supported for the specified action. To find out what resource types are supported, see Targets for AWS FIS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Scopes the identified resources. Valid values are ALL (all identified resources), COUNT(n) (randomly select n of the identified resources), PERCENT(n) (randomly select n percent of the identified resources).</summary>
    [JsonPropertyName("selectionMode")]
    public string? SelectionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusAtProvider
{
    /// <summary>Action to be performed during an experiment. See below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderAction>? Action { get; set; }

    /// <summary>Description for the experiment template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The experiment options for the experiment template. See experiment_options below for more details!</summary>
    [JsonPropertyName("experimentOptions")]
    public V1beta2ExperimentTemplateStatusAtProviderExperimentOptions? ExperimentOptions { get; set; }

    /// <summary>The configuration for experiment reporting. See below.</summary>
    [JsonPropertyName("experimentReportConfiguration")]
    public V1beta2ExperimentTemplateStatusAtProviderExperimentReportConfiguration? ExperimentReportConfiguration { get; set; }

    /// <summary>Experiment Template ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The configuration for experiment logging. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2ExperimentTemplateStatusAtProviderLogConfiguration? LogConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of an IAM role that grants the AWS FIS service permission to perform service actions on your behalf.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>When an ongoing experiment should be stopped. See below.</summary>
    [JsonPropertyName("stopCondition")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderStopCondition>? StopCondition { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Target of an action. See below.</summary>
    [JsonPropertyName("target")]
    public IList<V1beta2ExperimentTemplateStatusAtProviderTarget>? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatusConditions
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

/// <summary>ExperimentTemplateStatus defines the observed state of ExperimentTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExperimentTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ExperimentTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ExperimentTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ExperimentTemplate is the Schema for the ExperimentTemplates API. Provides an FIS Experiment Template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ExperimentTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ExperimentTemplateSpec>, IStatus<V1beta2ExperimentTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ExperimentTemplate";
    public const string KubeGroup = "fis.aws.upbound.io";
    public const string KubePluralName = "experimenttemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "fis.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExperimentTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExperimentTemplateSpec defines the desired state of ExperimentTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ExperimentTemplateSpec Spec { get; set; }

    /// <summary>ExperimentTemplateStatus defines the observed state of ExperimentTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2ExperimentTemplateStatus? Status { get; set; }
}