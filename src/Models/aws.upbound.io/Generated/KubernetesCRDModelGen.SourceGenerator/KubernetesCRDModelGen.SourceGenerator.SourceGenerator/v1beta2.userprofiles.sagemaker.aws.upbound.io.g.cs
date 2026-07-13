#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>UserProfile is the Schema for the UserProfiles API. Provides a SageMaker AI User Profile resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2UserProfileList : IKubernetesObject<V1ListMeta>, IItems<V1beta2UserProfile>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "UserProfileList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "userprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserProfileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2UserProfile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2UserProfile> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecDeletionPolicyEnum>))]
public enum V1beta2UserProfileSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecForProviderDomainIdRefPolicyResolutionEnum>))]
public enum V1beta2UserProfileSpecForProviderDomainIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecForProviderDomainIdRefPolicyResolveEnum>))]
public enum V1beta2UserProfileSpecForProviderDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderDomainIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserProfileSpecForProviderDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserProfileSpecForProviderDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserProfileSpecForProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecForProviderDomainIdSelectorPolicyResolutionEnum>))]
public enum V1beta2UserProfileSpecForProviderDomainIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecForProviderDomainIdSelectorPolicyResolveEnum>))]
public enum V1beta2UserProfileSpecForProviderDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderDomainIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserProfileSpecForProviderDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserProfileSpecForProviderDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderDomainIdSelector
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
    public V1beta2UserProfileSpecForProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The model deployment settings for the SageMaker AI Canvas application. See Direct Deploy Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether model deployment permissions are enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsEmrServerlessSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role that is assumed for running Amazon EMR Serverless jobs in SageMaker AI Canvas. This role should have the necessary permissions to read and write data attached and a trust relationship with EMR Serverless.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you&apos;re connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether OAuth for a data source is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for document querying. See Kendra Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether the document querying feature is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The model registry settings for the SageMaker AI Canvas application. See Model Register Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI model registry account. Required only to register model versions created by a different SageMaker AI Canvas AWS account than the AWS account in which SageMaker AI model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether the integration to the model registry is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The workspace settings for the SageMaker AI Canvas application. See Workspace Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker AI Canvas application. See Direct Deploy Settings below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings { get; set; }

    /// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
    [JsonPropertyName("emrServerlessSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings { get; set; }

    [JsonPropertyName("generativeAiSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See Identity Provider OAuth Settings below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See Kendra Settings below.</summary>
    [JsonPropertyName("kendraSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsKendraSettings? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker AI Canvas application. See Model Register Settings below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker AI Canvas application. See Workspace Settings below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a CodeEditor app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See EFS File System Config below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See Jupyter Server App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecForProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The RSession app settings. See RSession App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecForProviderUserSettingsRSessionAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>The sharing settings. See Sharing Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>When notebook_output_option is Allowed, the AWS Key Management Service (KMS) encryption key ID used to encrypt the notebook cell output in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The instance types you are hiding from the Studio user interface.</summary>
    [JsonPropertyName("hiddenInstanceTypes")]
    public IList<string>? HiddenInstanceTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecForProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>The user settings. See User Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProviderUserSettings
{
    /// <summary>Indicates whether auto-mounting of an EFS volume is supported for the user profile. The DefaultAsDomain value is only supported for user profiles. Do not use the DefaultAsDomain value when setting this parameter for a domain. Valid values are: Enabled, Disabled, and DefaultAsDomain.</summary>
    [JsonPropertyName("autoMountHomeEfs")]
    public string? AutoMountHomeEfs { get; set; }

    /// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCanvasAppSettings? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See Custom File System Config below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2UserProfileSpecForProviderUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2UserProfileSpecForProviderUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See RSession App Settings below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsRSessionAppSettings? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See Sharing Settings below.</summary>
    [JsonPropertyName("sharingSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsStudioWebPortalSettings? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1beta2UserProfileSpecForProviderUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecForProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta2UserProfileSpecForProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta2UserProfileSpecForProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A specifier for the type of value specified in single_sign_on_user_value. Currently, the only supported value is UserName. If the Domain&apos;s AuthMode is SSO, this field is required. If the Domain&apos;s AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>The username of the associated AWS Single Sign-On User for this User Profile. If the Domain&apos;s AuthMode is SSO, this field is required, and must match a valid username of a user in your directory. If the Domain&apos;s AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name for the User Profile.</summary>
    [JsonPropertyName("userProfileName")]
    public string? UserProfileName { get; set; }

    /// <summary>The user settings. See User Settings below.</summary>
    [JsonPropertyName("userSettings")]
    public V1beta2UserProfileSpecForProviderUserSettings? UserSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecInitProviderDomainIdRefPolicyResolutionEnum>))]
public enum V1beta2UserProfileSpecInitProviderDomainIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecInitProviderDomainIdRefPolicyResolveEnum>))]
public enum V1beta2UserProfileSpecInitProviderDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderDomainIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserProfileSpecInitProviderDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserProfileSpecInitProviderDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserProfileSpecInitProviderDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicyResolutionEnum>))]
public enum V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicyResolveEnum>))]
public enum V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderDomainIdSelector
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
    public V1beta2UserProfileSpecInitProviderDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The model deployment settings for the SageMaker AI Canvas application. See Direct Deploy Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether model deployment permissions are enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsEmrServerlessSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role that is assumed for running Amazon EMR Serverless jobs in SageMaker AI Canvas. This role should have the necessary permissions to read and write data attached and a trust relationship with EMR Serverless.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you&apos;re connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether OAuth for a data source is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for document querying. See Kendra Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether the document querying feature is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The model registry settings for the SageMaker AI Canvas application. See Model Register Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI model registry account. Required only to register model versions created by a different SageMaker AI Canvas AWS account than the AWS account in which SageMaker AI model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether the integration to the model registry is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The workspace settings for the SageMaker AI Canvas application. See Workspace Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker AI Canvas application. See Direct Deploy Settings below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings { get; set; }

    /// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
    [JsonPropertyName("emrServerlessSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings { get; set; }

    [JsonPropertyName("generativeAiSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See Identity Provider OAuth Settings below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See Kendra Settings below.</summary>
    [JsonPropertyName("kendraSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsKendraSettings? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker AI Canvas application. See Model Register Settings below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker AI Canvas application. See Workspace Settings below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a CodeEditor app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See EFS File System Config below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See Jupyter Server App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The RSession app settings. See RSession App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecInitProviderUserSettingsRSessionAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>The sharing settings. See Sharing Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>When notebook_output_option is Allowed, the AWS Key Management Service (KMS) encryption key ID used to encrypt the notebook cell output in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The instance types you are hiding from the Studio user interface.</summary>
    [JsonPropertyName("hiddenInstanceTypes")]
    public IList<string>? HiddenInstanceTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileSpecInitProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>The user settings. See User Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecInitProviderUserSettings
{
    /// <summary>Indicates whether auto-mounting of an EFS volume is supported for the user profile. The DefaultAsDomain value is only supported for user profiles. Do not use the DefaultAsDomain value when setting this parameter for a domain. Valid values are: Enabled, Disabled, and DefaultAsDomain.</summary>
    [JsonPropertyName("autoMountHomeEfs")]
    public string? AutoMountHomeEfs { get; set; }

    /// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCanvasAppSettings? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See Custom File System Config below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2UserProfileSpecInitProviderUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2UserProfileSpecInitProviderUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See RSession App Settings below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsRSessionAppSettings? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See Sharing Settings below.</summary>
    [JsonPropertyName("sharingSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsStudioWebPortalSettings? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
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
public partial class V1beta2UserProfileSpecInitProvider
{
    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Reference to a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdRef")]
    public V1beta2UserProfileSpecInitProviderDomainIdRef? DomainIdRef { get; set; }

    /// <summary>Selector for a Domain in sagemaker to populate domainId.</summary>
    [JsonPropertyName("domainIdSelector")]
    public V1beta2UserProfileSpecInitProviderDomainIdSelector? DomainIdSelector { get; set; }

    /// <summary>A specifier for the type of value specified in single_sign_on_user_value. Currently, the only supported value is UserName. If the Domain&apos;s AuthMode is SSO, this field is required. If the Domain&apos;s AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>The username of the associated AWS Single Sign-On User for this User Profile. If the Domain&apos;s AuthMode is SSO, this field is required, and must match a valid username of a user in your directory. If the Domain&apos;s AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The name for the User Profile.</summary>
    [JsonPropertyName("userProfileName")]
    public string? UserProfileName { get; set; }

    /// <summary>The user settings. See User Settings below.</summary>
    [JsonPropertyName("userSettings")]
    public V1beta2UserProfileSpecInitProviderUserSettings? UserSettings { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecManagementPoliciesEnum>))]
public enum V1beta2UserProfileSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2UserProfileSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserProfileSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2UserProfileSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserProfileSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserProfileSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserProfileSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>UserProfileSpec defines the desired state of UserProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileSpec
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
    public V1beta2UserProfileSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2UserProfileSpecForProvider ForProvider { get; set; }

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
    public V1beta2UserProfileSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2UserProfileSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2UserProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2UserProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The model deployment settings for the SageMaker AI Canvas application. See Direct Deploy Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsDirectDeploySettings
{
    /// <summary>Describes whether model deployment permissions are enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsEmrServerlessSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role that is assumed for running Amazon EMR Serverless jobs in SageMaker AI Canvas. This role should have the necessary permissions to read and write data attached and a trust relationship with EMR Serverless.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsGenerativeAiSettings
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("amazonBedrockRoleArn")]
    public string? AmazonBedrockRoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings
{
    /// <summary>The name of the data source that you&apos;re connecting to. Canvas currently supports OAuth for Snowflake and Salesforce Data Cloud. Valid values are SalesforceGenie and Snowflake.</summary>
    [JsonPropertyName("dataSourceName")]
    public string? DataSourceName { get; set; }

    /// <summary>The ARN of an Amazon Web Services Secrets Manager secret that stores the credentials from your identity provider, such as the client ID and secret, authorization URL, and token URL.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>Describes whether OAuth for a data source is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The settings for document querying. See Kendra Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsKendraSettings
{
    /// <summary>Describes whether the document querying feature is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The model registry settings for the SageMaker AI Canvas application. See Model Register Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsModelRegisterSettings
{
    /// <summary>The Amazon Resource Name (ARN) of the SageMaker AI model registry account. Required only to register model versions created by a different SageMaker AI Canvas AWS account than the AWS account in which SageMaker AI model registry is set up.</summary>
    [JsonPropertyName("crossAccountModelRegisterRoleArn")]
    public string? CrossAccountModelRegisterRoleArn { get; set; }

    /// <summary>Describes whether the integration to the model registry is enabled or disabled in the Canvas application. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings
{
    /// <summary>The IAM role that Canvas passes to Amazon Forecast for time series forecasting. By default, Canvas uses the execution role specified in the UserProfile that launches the Canvas app. If an execution role is not specified in the UserProfile, Canvas uses the execution role specified in the Domain that owns the UserProfile. To allow time series forecasting, this IAM role should have the AmazonSageMakerCanvasForecastAccess policy attached and forecast.amazonaws.com added in the trust relationship as a service principal.</summary>
    [JsonPropertyName("amazonForecastRoleArn")]
    public string? AmazonForecastRoleArn { get; set; }

    /// <summary>Describes whether time series forecasting is enabled or disabled in the Canvas app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The workspace settings for the SageMaker AI Canvas application. See Workspace Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsWorkspaceSettings
{
    /// <summary>The Amazon S3 bucket used to store artifacts generated by Canvas. Updating the Amazon S3 location impacts existing configuration settings, and Canvas users no longer have access to their artifacts. Canvas users must log out and log back in to apply the new location.</summary>
    [JsonPropertyName("s3ArtifactPath")]
    public string? S3ArtifactPath { get; set; }

    /// <summary>The Amazon Web Services Key Management Service (KMS) encryption key ID that is used to encrypt artifacts generated by Canvas in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }
}

/// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettings
{
    /// <summary>The model deployment settings for the SageMaker AI Canvas application. See Direct Deploy Settings below.</summary>
    [JsonPropertyName("directDeploySettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings { get; set; }

    /// <summary>The settings for running Amazon EMR Serverless jobs in SageMaker AI Canvas. See emr_serverless_settings Block below.</summary>
    [JsonPropertyName("emrServerlessSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings { get; set; }

    [JsonPropertyName("generativeAiSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings { get; set; }

    /// <summary>The settings for connecting to an external data source with OAuth. See Identity Provider OAuth Settings below.</summary>
    [JsonPropertyName("identityProviderOauthSettings")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsIdentityProviderOauthSettings>? IdentityProviderOauthSettings { get; set; }

    /// <summary>The settings for document querying. See Kendra Settings below.</summary>
    [JsonPropertyName("kendraSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsKendraSettings? KendraSettings { get; set; }

    /// <summary>The model registry settings for the SageMaker AI Canvas application. See Model Register Settings below.</summary>
    [JsonPropertyName("modelRegisterSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings { get; set; }

    /// <summary>Time series forecast settings for the Canvas app. See Time Series Forecasting Settings below.</summary>
    [JsonPropertyName("timeSeriesForecastingSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings { get; set; }

    /// <summary>The workspace settings for the SageMaker AI Canvas application. See Workspace Settings below.</summary>
    [JsonPropertyName("workspaceSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a CodeEditor app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig
{
    /// <summary>The ID of your Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The path to the file system directory that is accessible in Amazon SageMaker AI Studio. Permitted users can access only this directory and below.</summary>
    [JsonPropertyName("fileSystemPath")]
    public string? FileSystemPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCustomFileSystemConfig
{
    /// <summary>The default EBS storage settings for a private space. See EFS File System Config below.</summary>
    [JsonPropertyName("efsFileSystemConfig")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsCustomFileSystemConfigEfsFileSystemConfig>? EfsFileSystemConfig { get; set; }
}

/// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsCustomPosixUserConfig
{
    /// <summary>The POSIX group ID.</summary>
    [JsonPropertyName("gid")]
    public double? Gid { get; set; }

    /// <summary>The POSIX user ID.</summary>
    [JsonPropertyName("uid")]
    public double? Uid { get; set; }
}

/// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
{
    /// <summary>The time that SageMaker AI waits after the application becomes idle before shutting it down. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Indicates whether idle shutdown is activated for the application type. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("lifecycleManagement")]
    public string? LifecycleManagement { get; set; }

    /// <summary>The maximum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("maxIdleTimeoutInMinutes")]
    public double? MaxIdleTimeoutInMinutes { get; set; }

    /// <summary>The minimum value in minutes that custom idle shutdown can be set to by the user. Valid values are between 60 and 525600.</summary>
    [JsonPropertyName("minIdleTimeoutInMinutes")]
    public double? MinIdleTimeoutInMinutes { get; set; }
}

/// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagement
{
    /// <summary>Settings related to idle shutdown of Studio applications. see idle_settings Block below.</summary>
    [JsonPropertyName("idleSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsEmrSettings
{
    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role of SageMaker AI can assume for performing operations or tasks related to Amazon EMR clusters or Amazon EMR Serverless applications. These roles define the permissions and access policies required when performing Amazon EMR-related operations, such as listing, connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications. They are typically used in cross-account access scenarios, where the Amazon EMR resources (clusters or serverless applications) are located in a different AWS account than the SageMaker AI domain.</summary>
    [JsonPropertyName("assumableRoleArns")]
    public IList<string>? AssumableRoleArns { get; set; }

    /// <summary>An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster instances or job execution environments to access other AWS services and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other AWS services based on the particular workload requirements.</summary>
    [JsonPropertyName("executionRoleArns")]
    public IList<string>? ExecutionRoleArns { get; set; }
}

/// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettings
{
    /// <summary>Indicates whether idle shutdown is activated for JupyterLab applications. see app_lifecycle_management Block below.</summary>
    [JsonPropertyName("appLifecycleManagement")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement { get; set; }

    /// <summary>The lifecycle configuration that runs before the default lifecycle configuration. It can override changes made in the default lifecycle configuration.</summary>
    [JsonPropertyName("builtInLifecycleConfigArn")]
    public string? BuiltInLifecycleConfigArn { get; set; }

    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The configuration parameters that specify the IAM roles assumed by the execution role of SageMaker AI (assumable roles) and the cluster instances or job execution environments (execution roles or runtime roles) to manage and access resources required for running Amazon EMR clusters or Amazon EMR Serverless applications. see emr_settings Block below.</summary>
    [JsonPropertyName("emrSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsCodeRepository
{
    /// <summary>The URL of the Git repository.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The Jupyter server&apos;s app settings. See Jupyter Server App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsJupyterServerAppSettings
{
    /// <summary>A list of Git repositories that SageMaker AI automatically displays to users for cloning in the JupyterServer application. see Code Repository below.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsCodeRepository>? CodeRepository { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configurations.</summary>
    [JsonPropertyName("lifecycleConfigArns")]
    public IList<string>? LifecycleConfigArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsRSessionAppSettingsCustomImage
{
    /// <summary>The name of the App Image Config.</summary>
    [JsonPropertyName("appImageConfigName")]
    public string? AppImageConfigName { get; set; }

    /// <summary>The name of the Custom Image.</summary>
    [JsonPropertyName("imageName")]
    public string? ImageName { get; set; }

    /// <summary>The version number of the Custom Image.</summary>
    [JsonPropertyName("imageVersionNumber")]
    public double? ImageVersionNumber { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsRSessionAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The RSession app settings. See RSession App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsRSessionAppSettings
{
    /// <summary>A list of custom SageMaker AI images that are configured to run as a KernelGateway app. see Custom Image below.</summary>
    [JsonPropertyName("customImage")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsRSessionAppSettingsCustomImage>? CustomImage { get; set; }

    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileStatusAtProviderUserSettingsRSessionAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsRStudioServerProAppSettings
{
    /// <summary>Indicates whether the current user has access to the RStudioServerPro app. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("accessStatus")]
    public string? AccessStatus { get; set; }

    /// <summary>The level of permissions that the user has within the RStudioServerPro app. This value defaults to R_STUDIO_USER. The R_STUDIO_ADMIN value allows the user access to the RStudio Administrative Dashboard. Valid values are R_STUDIO_USER and R_STUDIO_ADMIN.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }
}

/// <summary>The sharing settings. See Sharing Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsSharingSettings
{
    /// <summary>Whether to include the notebook cell output when sharing the notebook. The default is Disabled. Valid values are Allowed and Disabled.</summary>
    [JsonPropertyName("notebookOutputOption")]
    public string? NotebookOutputOption { get; set; }

    /// <summary>When notebook_output_option is Allowed, the AWS Key Management Service (KMS) encryption key ID used to encrypt the notebook cell output in the Amazon S3 bucket.</summary>
    [JsonPropertyName("s3KmsKeyId")]
    public string? S3KmsKeyId { get; set; }

    /// <summary>When notebook_output_option is Allowed, the Amazon S3 bucket used to save the notebook cell output.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
{
    /// <summary>The default size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("defaultEbsVolumeSizeInGb")]
    public double? DefaultEbsVolumeSizeInGb { get; set; }

    /// <summary>The maximum size of the EBS storage volume for a private space.</summary>
    [JsonPropertyName("maximumEbsVolumeSizeInGb")]
    public double? MaximumEbsVolumeSizeInGb { get; set; }
}

/// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsSpaceStorageSettings
{
    /// <summary>The default EBS storage settings for a private space. See Default EBS Storage Settings below.</summary>
    [JsonPropertyName("defaultEbsStorageSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings { get; set; }
}

/// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsStudioWebPortalSettings
{
    /// <summary>The Applications supported in Studio that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenAppTypes")]
    public IList<string>? HiddenAppTypes { get; set; }

    /// <summary>The instance types you are hiding from the Studio user interface.</summary>
    [JsonPropertyName("hiddenInstanceTypes")]
    public IList<string>? HiddenInstanceTypes { get; set; }

    /// <summary>The machine learning tools that are hidden from the Studio left navigation pane.</summary>
    [JsonPropertyName("hiddenMlTools")]
    public IList<string>? HiddenMlTools { get; set; }
}

/// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec
{
    /// <summary>The instance type that the image version runs on.. For valid values see SageMaker AI Instance Types.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.</summary>
    [JsonPropertyName("lifecycleConfigArn")]
    public string? LifecycleConfigArn { get; set; }

    /// <summary>The ARN of the SageMaker AI image that the image version belongs to.</summary>
    [JsonPropertyName("sagemakerImageArn")]
    public string? SagemakerImageArn { get; set; }

    /// <summary>The SageMaker AI Image Version Alias.</summary>
    [JsonPropertyName("sagemakerImageVersionAlias")]
    public string? SagemakerImageVersionAlias { get; set; }

    /// <summary>The ARN of the image version created on the instance.</summary>
    [JsonPropertyName("sagemakerImageVersionArn")]
    public string? SagemakerImageVersionArn { get; set; }
}

/// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettingsTensorBoardAppSettings
{
    /// <summary>The default instance type and the Amazon Resource Name (ARN) of the SageMaker AI image created on the instance. see Default Resource Spec below.</summary>
    [JsonPropertyName("defaultResourceSpec")]
    public V1beta2UserProfileStatusAtProviderUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpec { get; set; }
}

/// <summary>The user settings. See User Settings below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProviderUserSettings
{
    /// <summary>Indicates whether auto-mounting of an EFS volume is supported for the user profile. The DefaultAsDomain value is only supported for user profiles. Do not use the DefaultAsDomain value when setting this parameter for a domain. Valid values are: Enabled, Disabled, and DefaultAsDomain.</summary>
    [JsonPropertyName("autoMountHomeEfs")]
    public string? AutoMountHomeEfs { get; set; }

    /// <summary>The Canvas app settings. See Canvas App Settings below.</summary>
    [JsonPropertyName("canvasAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCanvasAppSettings? CanvasAppSettings { get; set; }

    /// <summary>The Code Editor application settings. See Code Editor App Settings below.</summary>
    [JsonPropertyName("codeEditorAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCodeEditorAppSettings? CodeEditorAppSettings { get; set; }

    /// <summary>The settings for assigning a custom file system to a user profile. Permitted users can access this file system in Amazon SageMaker AI Studio. See Custom File System Config below.</summary>
    [JsonPropertyName("customFileSystemConfig")]
    public IList<V1beta2UserProfileStatusAtProviderUserSettingsCustomFileSystemConfig>? CustomFileSystemConfig { get; set; }

    /// <summary>Details about the POSIX identity that is used for file system operations. See Custom Posix User Config below.</summary>
    [JsonPropertyName("customPosixUserConfig")]
    public V1beta2UserProfileStatusAtProviderUserSettingsCustomPosixUserConfig? CustomPosixUserConfig { get; set; }

    /// <summary>The default experience that the user is directed to when accessing the domain. The supported values are: studio::: Indicates that Studio is the default experience. This value can only be passed if StudioWebPortal is set to ENABLED. app:JupyterServer:: Indicates that Studio Classic is the default experience.</summary>
    [JsonPropertyName("defaultLandingUri")]
    public string? DefaultLandingUri { get; set; }

    /// <summary>The execution role ARN for the user.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>The settings for the JupyterLab application. See Jupyter Lab App Settings below.</summary>
    [JsonPropertyName("jupyterLabAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterLabAppSettings? JupyterLabAppSettings { get; set; }

    /// <summary>The Jupyter server&apos;s app settings. See Jupyter Server App Settings below.</summary>
    [JsonPropertyName("jupyterServerAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsJupyterServerAppSettings? JupyterServerAppSettings { get; set; }

    /// <summary>The kernel gateway app settings. See Kernel Gateway App Settings below.</summary>
    [JsonPropertyName("kernelGatewayAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings { get; set; }

    /// <summary>The RSession app settings. See RSession App Settings below.</summary>
    [JsonPropertyName("rSessionAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsRSessionAppSettings? RSessionAppSettings { get; set; }

    /// <summary>A collection of settings that configure user interaction with the RStudioServerPro app. See RStudioServerProAppSettings below.</summary>
    [JsonPropertyName("rStudioServerProAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings { get; set; }

    /// <summary>A list of security group IDs that will be attached to the user.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The sharing settings. See Sharing Settings below.</summary>
    [JsonPropertyName("sharingSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsSharingSettings? SharingSettings { get; set; }

    /// <summary>The storage settings for a private space. See Space Storage Settings below.</summary>
    [JsonPropertyName("spaceStorageSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsSpaceStorageSettings? SpaceStorageSettings { get; set; }

    /// <summary>Whether the user can access Studio. If this value is set to DISABLED, the user cannot access Studio, even if that is the default experience for the domain. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("studioWebPortal")]
    public string? StudioWebPortal { get; set; }

    /// <summary>The Studio Web Portal settings. See studio_web_portal_settings Block below.</summary>
    [JsonPropertyName("studioWebPortalSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsStudioWebPortalSettings? StudioWebPortalSettings { get; set; }

    /// <summary>The TensorBoard app settings. See TensorBoard App Settings below.</summary>
    [JsonPropertyName("tensorBoardAppSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettingsTensorBoardAppSettings? TensorBoardAppSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusAtProvider
{
    /// <summary>The user profile Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the associated Domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>The ID of the user&apos;s profile in the Amazon Elastic File System (EFS) volume.</summary>
    [JsonPropertyName("homeEfsFileSystemUid")]
    public string? HomeEfsFileSystemUid { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A specifier for the type of value specified in single_sign_on_user_value. Currently, the only supported value is UserName. If the Domain&apos;s AuthMode is SSO, this field is required. If the Domain&apos;s AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserIdentifier")]
    public string? SingleSignOnUserIdentifier { get; set; }

    /// <summary>The username of the associated AWS Single Sign-On User for this User Profile. If the Domain&apos;s AuthMode is SSO, this field is required, and must match a valid username of a user in your directory. If the Domain&apos;s AuthMode is not SSO, this field cannot be specified.</summary>
    [JsonPropertyName("singleSignOnUserValue")]
    public string? SingleSignOnUserValue { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The name for the User Profile.</summary>
    [JsonPropertyName("userProfileName")]
    public string? UserProfileName { get; set; }

    /// <summary>The user settings. See User Settings below.</summary>
    [JsonPropertyName("userSettings")]
    public V1beta2UserProfileStatusAtProviderUserSettings? UserSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatusConditions
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

/// <summary>UserProfileStatus defines the observed state of UserProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserProfileStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2UserProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2UserProfileStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>UserProfile is the Schema for the UserProfiles API. Provides a SageMaker AI User Profile resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2UserProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2UserProfileSpec>, IStatus<V1beta2UserProfileStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "UserProfile";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "userprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserProfile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserProfileSpec defines the desired state of UserProfile</summary>
    [JsonPropertyName("spec")]
    public required V1beta2UserProfileSpec Spec { get; set; }

    /// <summary>UserProfileStatus defines the observed state of UserProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta2UserProfileStatus? Status { get; set; }
}