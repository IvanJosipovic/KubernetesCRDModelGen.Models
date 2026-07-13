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
/// <summary>Endpoint is the Schema for the Endpoints API. Provides a SageMaker AI Endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Endpoint>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Endpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Endpoint> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecDeletionPolicyEnum>))]
public enum V1beta2EndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigAutoRollbackConfigurationAlarms
{
    /// <summary>The name of a CloudWatch alarm in your account.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }
}

/// <summary>Automatic rollback configuration for handling endpoint deployment failures and recovery. See Auto Rollback Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigAutoRollbackConfiguration
{
    /// <summary>List of CloudWatch alarms in your account that are configured to monitor metrics on an endpoint. If any alarms are tripped during a deployment, SageMaker AI rolls back the deployment. See Alarms.</summary>
    [JsonPropertyName("alarms")]
    public IList<V1beta2EndpointSpecForProviderDeploymentConfigAutoRollbackConfigurationAlarms>? Alarms { get; set; }
}

/// <summary>Batch size for the first step to turn on traffic on the new endpoint fleet. Value must be less than or equal to 50% of the variant&apos;s total instance count. See Canary Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Batch size for each step to turn on traffic on the new endpoint fleet. Value must be 10-50% of the variant&apos;s total instance count. See Linear Step Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Defines the traffic routing strategy to shift traffic from the old fleet to the new fleet during an endpoint deployment. See Traffic Routing Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
{
    /// <summary>Batch size for the first step to turn on traffic on the new endpoint fleet. Value must be less than or equal to 50% of the variant&apos;s total instance count. See Canary Size.</summary>
    [JsonPropertyName("canarySize")]
    public V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize { get; set; }

    /// <summary>Batch size for each step to turn on traffic on the new endpoint fleet. Value must be 10-50% of the variant&apos;s total instance count. See Linear Step Size.</summary>
    [JsonPropertyName("linearStepSize")]
    public V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize { get; set; }

    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The length of the baking period, during which SageMaker AI monitors alarms for each batch on the new fleet. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("waitIntervalInSeconds")]
    public double? WaitIntervalInSeconds { get; set; }
}

/// <summary>Update policy for a blue/green deployment. If this update policy is specified, SageMaker AI creates a new fleet during the deployment while maintaining the old fleet. SageMaker AI flips traffic to the new fleet according to the specified traffic routing configuration. Only one update policy should be used in the deployment configuration. If no update policy is specified, SageMaker AI uses a blue/green deployment strategy with all at once traffic shifting by default. See Blue Green Update Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicy
{
    /// <summary>Maximum execution timeout for the deployment. Note that the timeout value should be larger than the total waiting time specified in termination_wait_in_seconds and wait_interval_in_seconds. Valid values are between 600 and 14400.</summary>
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public double? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>Additional waiting time in seconds after the completion of an endpoint deployment before terminating the old endpoint fleet. Default is 0. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("terminationWaitInSeconds")]
    public double? TerminationWaitInSeconds { get; set; }

    /// <summary>Defines the traffic routing strategy to shift traffic from the old fleet to the new fleet during an endpoint deployment. See Traffic Routing Configuration.</summary>
    [JsonPropertyName("trafficRoutingConfiguration")]
    public V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration? TrafficRoutingConfiguration { get; set; }
}

/// <summary>Batch size for each rolling step to provision capacity and turn on traffic on the new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be between 5% to 50% of the variant&apos;s total instance count. See Maximum Batch Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigRollingUpdatePolicyMaximumBatchSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Batch size for rollback to the old endpoint fleet. Each rolling step to provision capacity and turn on traffic on the old endpoint fleet, and terminate capacity on the new endpoint fleet. If this field is absent, the default value will be set to 100% of total capacity which means to bring up the whole capacity of the old fleet at once during rollback. See Rollback Maximum Batch Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Specifies a rolling deployment strategy for updating a SageMaker AI endpoint. See Rolling Update Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfigRollingUpdatePolicy
{
    /// <summary>Batch size for each rolling step to provision capacity and turn on traffic on the new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be between 5% to 50% of the variant&apos;s total instance count. See Maximum Batch Size.</summary>
    [JsonPropertyName("maximumBatchSize")]
    public V1beta2EndpointSpecForProviderDeploymentConfigRollingUpdatePolicyMaximumBatchSize? MaximumBatchSize { get; set; }

    /// <summary>Maximum execution timeout for the deployment. Note that the timeout value should be larger than the total waiting time specified in termination_wait_in_seconds and wait_interval_in_seconds. Valid values are between 600 and 14400.</summary>
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public double? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>Batch size for rollback to the old endpoint fleet. Each rolling step to provision capacity and turn on traffic on the old endpoint fleet, and terminate capacity on the new endpoint fleet. If this field is absent, the default value will be set to 100% of total capacity which means to bring up the whole capacity of the old fleet at once during rollback. See Rollback Maximum Batch Size.</summary>
    [JsonPropertyName("rollbackMaximumBatchSize")]
    public V1beta2EndpointSpecForProviderDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize { get; set; }

    /// <summary>The length of the baking period, during which SageMaker AI monitors alarms for each batch on the new fleet. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("waitIntervalInSeconds")]
    public double? WaitIntervalInSeconds { get; set; }
}

/// <summary>The deployment configuration for an endpoint, which contains the desired deployment strategy and rollback configurations. See Deployment Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeploymentConfig
{
    /// <summary>Automatic rollback configuration for handling endpoint deployment failures and recovery. See Auto Rollback Configuration.</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta2EndpointSpecForProviderDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Update policy for a blue/green deployment. If this update policy is specified, SageMaker AI creates a new fleet during the deployment while maintaining the old fleet. SageMaker AI flips traffic to the new fleet according to the specified traffic routing configuration. Only one update policy should be used in the deployment configuration. If no update policy is specified, SageMaker AI uses a blue/green deployment strategy with all at once traffic shifting by default. See Blue Green Update Config.</summary>
    [JsonPropertyName("blueGreenUpdatePolicy")]
    public V1beta2EndpointSpecForProviderDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy { get; set; }

    /// <summary>Specifies a rolling deployment strategy for updating a SageMaker AI endpoint. See Rolling Update Policy.</summary>
    [JsonPropertyName("rollingUpdatePolicy")]
    public V1beta2EndpointSpecForProviderDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicyResolveEnum>))]
public enum V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderEndpointConfigNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderEndpointConfigNameSelector
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
    public V1beta2EndpointSpecForProviderEndpointConfigNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProvider
{
    /// <summary>The deployment configuration for an endpoint, which contains the desired deployment strategy and rollback configurations. See Deployment Config.</summary>
    [JsonPropertyName("deploymentConfig")]
    public V1beta2EndpointSpecForProviderDeploymentConfig? DeploymentConfig { get; set; }

    /// <summary>The name of the endpoint configuration to use.</summary>
    [JsonPropertyName("endpointConfigName")]
    public string? EndpointConfigName { get; set; }

    /// <summary>Reference to a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
    [JsonPropertyName("endpointConfigNameRef")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameRef? EndpointConfigNameRef { get; set; }

    /// <summary>Selector for a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
    [JsonPropertyName("endpointConfigNameSelector")]
    public V1beta2EndpointSpecForProviderEndpointConfigNameSelector? EndpointConfigNameSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigAutoRollbackConfigurationAlarms
{
    /// <summary>The name of a CloudWatch alarm in your account.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }
}

/// <summary>Automatic rollback configuration for handling endpoint deployment failures and recovery. See Auto Rollback Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigAutoRollbackConfiguration
{
    /// <summary>List of CloudWatch alarms in your account that are configured to monitor metrics on an endpoint. If any alarms are tripped during a deployment, SageMaker AI rolls back the deployment. See Alarms.</summary>
    [JsonPropertyName("alarms")]
    public IList<V1beta2EndpointSpecInitProviderDeploymentConfigAutoRollbackConfigurationAlarms>? Alarms { get; set; }
}

/// <summary>Batch size for the first step to turn on traffic on the new endpoint fleet. Value must be less than or equal to 50% of the variant&apos;s total instance count. See Canary Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Batch size for each step to turn on traffic on the new endpoint fleet. Value must be 10-50% of the variant&apos;s total instance count. See Linear Step Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Defines the traffic routing strategy to shift traffic from the old fleet to the new fleet during an endpoint deployment. See Traffic Routing Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
{
    /// <summary>Batch size for the first step to turn on traffic on the new endpoint fleet. Value must be less than or equal to 50% of the variant&apos;s total instance count. See Canary Size.</summary>
    [JsonPropertyName("canarySize")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize { get; set; }

    /// <summary>Batch size for each step to turn on traffic on the new endpoint fleet. Value must be 10-50% of the variant&apos;s total instance count. See Linear Step Size.</summary>
    [JsonPropertyName("linearStepSize")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize { get; set; }

    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The length of the baking period, during which SageMaker AI monitors alarms for each batch on the new fleet. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("waitIntervalInSeconds")]
    public double? WaitIntervalInSeconds { get; set; }
}

/// <summary>Update policy for a blue/green deployment. If this update policy is specified, SageMaker AI creates a new fleet during the deployment while maintaining the old fleet. SageMaker AI flips traffic to the new fleet according to the specified traffic routing configuration. Only one update policy should be used in the deployment configuration. If no update policy is specified, SageMaker AI uses a blue/green deployment strategy with all at once traffic shifting by default. See Blue Green Update Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicy
{
    /// <summary>Maximum execution timeout for the deployment. Note that the timeout value should be larger than the total waiting time specified in termination_wait_in_seconds and wait_interval_in_seconds. Valid values are between 600 and 14400.</summary>
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public double? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>Additional waiting time in seconds after the completion of an endpoint deployment before terminating the old endpoint fleet. Default is 0. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("terminationWaitInSeconds")]
    public double? TerminationWaitInSeconds { get; set; }

    /// <summary>Defines the traffic routing strategy to shift traffic from the old fleet to the new fleet during an endpoint deployment. See Traffic Routing Configuration.</summary>
    [JsonPropertyName("trafficRoutingConfiguration")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration? TrafficRoutingConfiguration { get; set; }
}

/// <summary>Batch size for each rolling step to provision capacity and turn on traffic on the new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be between 5% to 50% of the variant&apos;s total instance count. See Maximum Batch Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigRollingUpdatePolicyMaximumBatchSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Batch size for rollback to the old endpoint fleet. Each rolling step to provision capacity and turn on traffic on the old endpoint fleet, and terminate capacity on the new endpoint fleet. If this field is absent, the default value will be set to 100% of total capacity which means to bring up the whole capacity of the old fleet at once during rollback. See Rollback Maximum Batch Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Specifies a rolling deployment strategy for updating a SageMaker AI endpoint. See Rolling Update Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfigRollingUpdatePolicy
{
    /// <summary>Batch size for each rolling step to provision capacity and turn on traffic on the new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be between 5% to 50% of the variant&apos;s total instance count. See Maximum Batch Size.</summary>
    [JsonPropertyName("maximumBatchSize")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigRollingUpdatePolicyMaximumBatchSize? MaximumBatchSize { get; set; }

    /// <summary>Maximum execution timeout for the deployment. Note that the timeout value should be larger than the total waiting time specified in termination_wait_in_seconds and wait_interval_in_seconds. Valid values are between 600 and 14400.</summary>
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public double? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>Batch size for rollback to the old endpoint fleet. Each rolling step to provision capacity and turn on traffic on the old endpoint fleet, and terminate capacity on the new endpoint fleet. If this field is absent, the default value will be set to 100% of total capacity which means to bring up the whole capacity of the old fleet at once during rollback. See Rollback Maximum Batch Size.</summary>
    [JsonPropertyName("rollbackMaximumBatchSize")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize { get; set; }

    /// <summary>The length of the baking period, during which SageMaker AI monitors alarms for each batch on the new fleet. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("waitIntervalInSeconds")]
    public double? WaitIntervalInSeconds { get; set; }
}

/// <summary>The deployment configuration for an endpoint, which contains the desired deployment strategy and rollback configurations. See Deployment Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeploymentConfig
{
    /// <summary>Automatic rollback configuration for handling endpoint deployment failures and recovery. See Auto Rollback Configuration.</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Update policy for a blue/green deployment. If this update policy is specified, SageMaker AI creates a new fleet during the deployment while maintaining the old fleet. SageMaker AI flips traffic to the new fleet according to the specified traffic routing configuration. Only one update policy should be used in the deployment configuration. If no update policy is specified, SageMaker AI uses a blue/green deployment strategy with all at once traffic shifting by default. See Blue Green Update Config.</summary>
    [JsonPropertyName("blueGreenUpdatePolicy")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy { get; set; }

    /// <summary>Specifies a rolling deployment strategy for updating a SageMaker AI endpoint. See Rolling Update Policy.</summary>
    [JsonPropertyName("rollingUpdatePolicy")]
    public V1beta2EndpointSpecInitProviderDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicyResolveEnum>))]
public enum V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderEndpointConfigNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderEndpointConfigNameSelector
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
    public V1beta2EndpointSpecInitProviderEndpointConfigNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2EndpointSpecInitProvider
{
    /// <summary>The deployment configuration for an endpoint, which contains the desired deployment strategy and rollback configurations. See Deployment Config.</summary>
    [JsonPropertyName("deploymentConfig")]
    public V1beta2EndpointSpecInitProviderDeploymentConfig? DeploymentConfig { get; set; }

    /// <summary>The name of the endpoint configuration to use.</summary>
    [JsonPropertyName("endpointConfigName")]
    public string? EndpointConfigName { get; set; }

    /// <summary>Reference to a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
    [JsonPropertyName("endpointConfigNameRef")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameRef? EndpointConfigNameRef { get; set; }

    /// <summary>Selector for a EndpointConfiguration in sagemaker to populate endpointConfigName.</summary>
    [JsonPropertyName("endpointConfigNameSelector")]
    public V1beta2EndpointSpecInitProviderEndpointConfigNameSelector? EndpointConfigNameSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecManagementPoliciesEnum>))]
public enum V1beta2EndpointSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2EndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EndpointSpec defines the desired state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpec
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
    public V1beta2EndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2EndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta2EndpointSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2EndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigAutoRollbackConfigurationAlarms
{
    /// <summary>The name of a CloudWatch alarm in your account.</summary>
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }
}

/// <summary>Automatic rollback configuration for handling endpoint deployment failures and recovery. See Auto Rollback Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigAutoRollbackConfiguration
{
    /// <summary>List of CloudWatch alarms in your account that are configured to monitor metrics on an endpoint. If any alarms are tripped during a deployment, SageMaker AI rolls back the deployment. See Alarms.</summary>
    [JsonPropertyName("alarms")]
    public IList<V1beta2EndpointStatusAtProviderDeploymentConfigAutoRollbackConfigurationAlarms>? Alarms { get; set; }
}

/// <summary>Batch size for the first step to turn on traffic on the new endpoint fleet. Value must be less than or equal to 50% of the variant&apos;s total instance count. See Canary Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Batch size for each step to turn on traffic on the new endpoint fleet. Value must be 10-50% of the variant&apos;s total instance count. See Linear Step Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Defines the traffic routing strategy to shift traffic from the old fleet to the new fleet during an endpoint deployment. See Traffic Routing Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
{
    /// <summary>Batch size for the first step to turn on traffic on the new endpoint fleet. Value must be less than or equal to 50% of the variant&apos;s total instance count. See Canary Size.</summary>
    [JsonPropertyName("canarySize")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize { get; set; }

    /// <summary>Batch size for each step to turn on traffic on the new endpoint fleet. Value must be 10-50% of the variant&apos;s total instance count. See Linear Step Size.</summary>
    [JsonPropertyName("linearStepSize")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize { get; set; }

    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The length of the baking period, during which SageMaker AI monitors alarms for each batch on the new fleet. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("waitIntervalInSeconds")]
    public double? WaitIntervalInSeconds { get; set; }
}

/// <summary>Update policy for a blue/green deployment. If this update policy is specified, SageMaker AI creates a new fleet during the deployment while maintaining the old fleet. SageMaker AI flips traffic to the new fleet according to the specified traffic routing configuration. Only one update policy should be used in the deployment configuration. If no update policy is specified, SageMaker AI uses a blue/green deployment strategy with all at once traffic shifting by default. See Blue Green Update Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicy
{
    /// <summary>Maximum execution timeout for the deployment. Note that the timeout value should be larger than the total waiting time specified in termination_wait_in_seconds and wait_interval_in_seconds. Valid values are between 600 and 14400.</summary>
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public double? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>Additional waiting time in seconds after the completion of an endpoint deployment before terminating the old endpoint fleet. Default is 0. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("terminationWaitInSeconds")]
    public double? TerminationWaitInSeconds { get; set; }

    /// <summary>Defines the traffic routing strategy to shift traffic from the old fleet to the new fleet during an endpoint deployment. See Traffic Routing Configuration.</summary>
    [JsonPropertyName("trafficRoutingConfiguration")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration? TrafficRoutingConfiguration { get; set; }
}

/// <summary>Batch size for each rolling step to provision capacity and turn on traffic on the new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be between 5% to 50% of the variant&apos;s total instance count. See Maximum Batch Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigRollingUpdatePolicyMaximumBatchSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Batch size for rollback to the old endpoint fleet. Each rolling step to provision capacity and turn on traffic on the old endpoint fleet, and terminate capacity on the new endpoint fleet. If this field is absent, the default value will be set to 100% of total capacity which means to bring up the whole capacity of the old fleet at once during rollback. See Rollback Maximum Batch Size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize
{
    /// <summary>Traffic routing strategy type. Valid values are: ALL_AT_ONCE, CANARY, and LINEAR.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Defines the capacity size, either as a number of instances or a capacity percentage.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Specifies a rolling deployment strategy for updating a SageMaker AI endpoint. See Rolling Update Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfigRollingUpdatePolicy
{
    /// <summary>Batch size for each rolling step to provision capacity and turn on traffic on the new endpoint fleet, and terminate capacity on the old endpoint fleet. Value must be between 5% to 50% of the variant&apos;s total instance count. See Maximum Batch Size.</summary>
    [JsonPropertyName("maximumBatchSize")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigRollingUpdatePolicyMaximumBatchSize? MaximumBatchSize { get; set; }

    /// <summary>Maximum execution timeout for the deployment. Note that the timeout value should be larger than the total waiting time specified in termination_wait_in_seconds and wait_interval_in_seconds. Valid values are between 600 and 14400.</summary>
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public double? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>Batch size for rollback to the old endpoint fleet. Each rolling step to provision capacity and turn on traffic on the old endpoint fleet, and terminate capacity on the new endpoint fleet. If this field is absent, the default value will be set to 100% of total capacity which means to bring up the whole capacity of the old fleet at once during rollback. See Rollback Maximum Batch Size.</summary>
    [JsonPropertyName("rollbackMaximumBatchSize")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize { get; set; }

    /// <summary>The length of the baking period, during which SageMaker AI monitors alarms for each batch on the new fleet. Valid values are between 0 and 3600.</summary>
    [JsonPropertyName("waitIntervalInSeconds")]
    public double? WaitIntervalInSeconds { get; set; }
}

/// <summary>The deployment configuration for an endpoint, which contains the desired deployment strategy and rollback configurations. See Deployment Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeploymentConfig
{
    /// <summary>Automatic rollback configuration for handling endpoint deployment failures and recovery. See Auto Rollback Configuration.</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Update policy for a blue/green deployment. If this update policy is specified, SageMaker AI creates a new fleet during the deployment while maintaining the old fleet. SageMaker AI flips traffic to the new fleet according to the specified traffic routing configuration. Only one update policy should be used in the deployment configuration. If no update policy is specified, SageMaker AI uses a blue/green deployment strategy with all at once traffic shifting by default. See Blue Green Update Config.</summary>
    [JsonPropertyName("blueGreenUpdatePolicy")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy { get; set; }

    /// <summary>Specifies a rolling deployment strategy for updating a SageMaker AI endpoint. See Rolling Update Policy.</summary>
    [JsonPropertyName("rollingUpdatePolicy")]
    public V1beta2EndpointStatusAtProviderDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this endpoint.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The deployment configuration for an endpoint, which contains the desired deployment strategy and rollback configurations. See Deployment Config.</summary>
    [JsonPropertyName("deploymentConfig")]
    public V1beta2EndpointStatusAtProviderDeploymentConfig? DeploymentConfig { get; set; }

    /// <summary>The name of the endpoint configuration to use.</summary>
    [JsonPropertyName("endpointConfigName")]
    public string? EndpointConfigName { get; set; }

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

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API. Provides a SageMaker AI Endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EndpointSpec>, IStatus<V1beta2EndpointStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Endpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointSpec defines the desired state of Endpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta2EndpointSpec Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta2EndpointStatus? Status { get; set; }
}