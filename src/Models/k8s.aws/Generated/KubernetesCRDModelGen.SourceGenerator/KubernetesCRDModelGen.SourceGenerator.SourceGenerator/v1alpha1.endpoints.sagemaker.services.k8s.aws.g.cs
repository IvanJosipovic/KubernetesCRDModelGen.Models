#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.services.k8s.aws;
/// <summary>Endpoint is the Schema for the Endpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Endpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Endpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Endpoint> Items { get; set; }
}

/// <summary>An Amazon CloudWatch alarm configured to monitor metrics on an endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigAutoRollbackConfigurationAlarms
{
    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }
}

/// <summary>
/// Automatic rollback configuration for handling endpoint deployment failures
/// and recovery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigAutoRollbackConfiguration
{
    [JsonPropertyName("alarms")]
    public IList<V1alpha1EndpointSpecDeploymentConfigAutoRollbackConfigurationAlarms>? Alarms { get; set; }
}

/// <summary>
/// Specifies the type and size of the endpoint capacity to activate for a blue/green
/// deployment, a rolling deployment, or a rollback strategy. You can specify
/// your batches as either instance count or the overall percentage or your fleet.
/// 
/// For a rollback strategy, if you don&apos;t specify the fields in this object,
/// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
/// strategy and rolls all traffic back to the blue fleet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// Specifies the type and size of the endpoint capacity to activate for a blue/green
/// deployment, a rolling deployment, or a rollback strategy. You can specify
/// your batches as either instance count or the overall percentage or your fleet.
/// 
/// For a rollback strategy, if you don&apos;t specify the fields in this object,
/// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
/// strategy and rolls all traffic back to the blue fleet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// Defines the traffic routing strategy during an endpoint deployment to shift
/// traffic from the old fleet to the new fleet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
{
    /// <summary>
    /// Specifies the type and size of the endpoint capacity to activate for a blue/green
    /// deployment, a rolling deployment, or a rollback strategy. You can specify
    /// your batches as either instance count or the overall percentage or your fleet.
    /// 
    /// For a rollback strategy, if you don&apos;t specify the fields in this object,
    /// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
    /// strategy and rolls all traffic back to the blue fleet.
    /// </summary>
    [JsonPropertyName("canarySize")]
    public V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize { get; set; }

    /// <summary>
    /// Specifies the type and size of the endpoint capacity to activate for a blue/green
    /// deployment, a rolling deployment, or a rollback strategy. You can specify
    /// your batches as either instance count or the overall percentage or your fleet.
    /// 
    /// For a rollback strategy, if you don&apos;t specify the fields in this object,
    /// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
    /// strategy and rolls all traffic back to the blue fleet.
    /// </summary>
    [JsonPropertyName("linearStepSize")]
    public V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("waitIntervalInSeconds")]
    public long? WaitIntervalInSeconds { get; set; }
}

/// <summary>
/// Update policy for a blue/green deployment. If this update policy is specified,
/// SageMaker creates a new fleet during the deployment while maintaining the
/// old fleet. SageMaker flips traffic to the new fleet according to the specified
/// traffic routing configuration. Only one update policy should be used in the
/// deployment configuration. If no update policy is specified, SageMaker uses
/// a blue/green deployment strategy with all at once traffic shifting by default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicy
{
    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public long? MaximumExecutionTimeoutInSeconds { get; set; }

    [JsonPropertyName("terminationWaitInSeconds")]
    public long? TerminationWaitInSeconds { get; set; }

    /// <summary>
    /// Defines the traffic routing strategy during an endpoint deployment to shift
    /// traffic from the old fleet to the new fleet.
    /// </summary>
    [JsonPropertyName("trafficRoutingConfiguration")]
    public V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration? TrafficRoutingConfiguration { get; set; }
}

/// <summary>
/// Specifies the type and size of the endpoint capacity to activate for a blue/green
/// deployment, a rolling deployment, or a rollback strategy. You can specify
/// your batches as either instance count or the overall percentage or your fleet.
/// 
/// For a rollback strategy, if you don&apos;t specify the fields in this object,
/// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
/// strategy and rolls all traffic back to the blue fleet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigRollingUpdatePolicyMaximumBatchSize
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// Specifies the type and size of the endpoint capacity to activate for a blue/green
/// deployment, a rolling deployment, or a rollback strategy. You can specify
/// your batches as either instance count or the overall percentage or your fleet.
/// 
/// For a rollback strategy, if you don&apos;t specify the fields in this object,
/// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
/// strategy and rolls all traffic back to the blue fleet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize
{
    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>Specifies a rolling deployment strategy for updating a SageMaker endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfigRollingUpdatePolicy
{
    /// <summary>
    /// Specifies the type and size of the endpoint capacity to activate for a blue/green
    /// deployment, a rolling deployment, or a rollback strategy. You can specify
    /// your batches as either instance count or the overall percentage or your fleet.
    /// 
    /// For a rollback strategy, if you don&apos;t specify the fields in this object,
    /// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
    /// strategy and rolls all traffic back to the blue fleet.
    /// </summary>
    [JsonPropertyName("maximumBatchSize")]
    public V1alpha1EndpointSpecDeploymentConfigRollingUpdatePolicyMaximumBatchSize? MaximumBatchSize { get; set; }

    [JsonPropertyName("maximumExecutionTimeoutInSeconds")]
    public long? MaximumExecutionTimeoutInSeconds { get; set; }

    /// <summary>
    /// Specifies the type and size of the endpoint capacity to activate for a blue/green
    /// deployment, a rolling deployment, or a rollback strategy. You can specify
    /// your batches as either instance count or the overall percentage or your fleet.
    /// 
    /// For a rollback strategy, if you don&apos;t specify the fields in this object,
    /// or if you set the Value to 100%, then SageMaker uses a blue/green rollback
    /// strategy and rolls all traffic back to the blue fleet.
    /// </summary>
    [JsonPropertyName("rollbackMaximumBatchSize")]
    public V1alpha1EndpointSpecDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize { get; set; }

    [JsonPropertyName("waitIntervalInSeconds")]
    public long? WaitIntervalInSeconds { get; set; }
}

/// <summary>
/// The deployment configuration for an endpoint, which contains the desired
/// deployment strategy and rollback configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecDeploymentConfig
{
    /// <summary>
    /// Automatic rollback configuration for handling endpoint deployment failures
    /// and recovery.
    /// </summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1alpha1EndpointSpecDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>
    /// Update policy for a blue/green deployment. If this update policy is specified,
    /// SageMaker creates a new fleet during the deployment while maintaining the
    /// old fleet. SageMaker flips traffic to the new fleet according to the specified
    /// traffic routing configuration. Only one update policy should be used in the
    /// deployment configuration. If no update policy is specified, SageMaker uses
    /// a blue/green deployment strategy with all at once traffic shifting by default.
    /// </summary>
    [JsonPropertyName("blueGreenUpdatePolicy")]
    public V1alpha1EndpointSpecDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy { get; set; }

    /// <summary>Specifies a rolling deployment strategy for updating a SageMaker endpoint.</summary>
    [JsonPropertyName("rollingUpdatePolicy")]
    public V1alpha1EndpointSpecDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy { get; set; }
}

/// <summary>
/// A tag object that consists of a key and an optional value, used to manage
/// metadata for SageMaker Amazon Web Services resources.
/// 
/// You can add tags to notebook instances, training jobs, hyperparameter tuning
/// jobs, batch transform jobs, models, labeling jobs, work teams, endpoint configurations,
/// and endpoints. For more information on adding tags to SageMaker resources,
/// see AddTags (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html).
/// 
/// For more information on adding metadata to your Amazon Web Services resources
/// with tagging, see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
/// For advice on best practices for managing Amazon Web Services resources with
/// tagging, see Tagging Best Practices: Implement an Effective Amazon Web Services
/// Resource Tagging Strategy (https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// EndpointSpec defines the desired state of Endpoint.
/// 
/// A hosted endpoint for real-time inference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointSpec
{
    /// <summary>
    /// The deployment configuration for an endpoint, which contains the desired
    /// deployment strategy and rollback configurations.
    /// </summary>
    [JsonPropertyName("deploymentConfig")]
    public V1alpha1EndpointSpecDeploymentConfig? DeploymentConfig { get; set; }

    /// <summary>
    /// The name of an endpoint configuration. For more information, see CreateEndpointConfig
    /// (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html).
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("endpointConfigName")]
    public required string EndpointConfigName { get; set; }

    /// <summary>
    /// The name of the endpoint.The name must be unique within an Amazon Web Services
    /// Region in your Amazon Web Services account. The name is case-insensitive
    /// in CreateEndpoint, but the case is preserved and must be matched in InvokeEndpoint
    /// (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpoint.html).
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("endpointName")]
    public required string EndpointName { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1EndpointSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsCurrentServerlessConfig
{
    [JsonPropertyName("maxConcurrency")]
    public long? MaxConcurrency { get; set; }

    [JsonPropertyName("memorySizeInMB")]
    public long? MemorySizeInMB { get; set; }

    [JsonPropertyName("provisionedConcurrency")]
    public long? ProvisionedConcurrency { get; set; }
}

/// <summary>
/// Gets the Amazon EC2 Container Registry path of the docker image of the model
/// that is hosted in this ProductionVariant (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ProductionVariant.html).
/// 
/// If you used the registry/repository[:tag] form to specify the image path
/// of the primary container when you created the model hosted in this ProductionVariant,
/// the path resolves to a path of the form registry/repository[@digest]. A digest
/// is a hash value that identifies a specific version of an image. For information
/// about Amazon ECR paths, see Pulling an Image (https://docs.aws.amazon.com/AmazonECR/latest/userguide/docker-pull-ecr-image.html)
/// in the Amazon ECR User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsDeployedImages
{
    [JsonPropertyName("resolutionTime")]
    public DateTime? ResolutionTime { get; set; }

    [JsonPropertyName("resolvedImage")]
    public string? ResolvedImage { get; set; }

    [JsonPropertyName("specifiedImage")]
    public string? SpecifiedImage { get; set; }
}

/// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsDesiredServerlessConfig
{
    [JsonPropertyName("maxConcurrency")]
    public long? MaxConcurrency { get; set; }

    [JsonPropertyName("memorySizeInMB")]
    public long? MemorySizeInMB { get; set; }

    [JsonPropertyName("provisionedConcurrency")]
    public long? ProvisionedConcurrency { get; set; }
}

/// <summary>
/// Settings that control the range in the number of instances that the endpoint
/// provisions as it scales up or down to accommodate traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsManagedInstanceScaling
{
    [JsonPropertyName("maxInstanceCount")]
    public long? MaxInstanceCount { get; set; }

    [JsonPropertyName("minInstanceCount")]
    public long? MinInstanceCount { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Settings that control how the endpoint routes incoming traffic to the instances
/// that the endpoint hosts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsRoutingConfig
{
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>Describes the status of the production variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsVariantStatus
{
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>
/// The production variant summary for a deployment when an endpoint is creating
/// or updating with the CreateEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html)
/// or UpdateEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpoint.html)
/// operations. Describes the VariantStatus , weight and capacity for a production
/// variant associated with an endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariants
{
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    [JsonPropertyName("currentInstanceCount")]
    public long? CurrentInstanceCount { get; set; }

    /// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
    [JsonPropertyName("currentServerlessConfig")]
    public V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsCurrentServerlessConfig? CurrentServerlessConfig { get; set; }

    [JsonPropertyName("currentWeight")]
    public double? CurrentWeight { get; set; }

    [JsonPropertyName("deployedImages")]
    public IList<V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsDeployedImages>? DeployedImages { get; set; }

    [JsonPropertyName("desiredInstanceCount")]
    public long? DesiredInstanceCount { get; set; }

    /// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
    [JsonPropertyName("desiredServerlessConfig")]
    public V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsDesiredServerlessConfig? DesiredServerlessConfig { get; set; }

    [JsonPropertyName("desiredWeight")]
    public double? DesiredWeight { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// Settings that control the range in the number of instances that the endpoint
    /// provisions as it scales up or down to accommodate traffic.
    /// </summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>
    /// Settings that control how the endpoint routes incoming traffic to the instances
    /// that the endpoint hosts.
    /// </summary>
    [JsonPropertyName("routingConfig")]
    public V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsRoutingConfig? RoutingConfig { get; set; }

    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    [JsonPropertyName("variantStatus")]
    public IList<V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariantsVariantStatus>? VariantStatus { get; set; }
}

/// <summary>
/// Returns the summary of an in-progress deployment. This field is only returned
/// when the endpoint is creating or updating with a new endpoint configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusPendingDeploymentSummary
{
    [JsonPropertyName("endpointConfigName")]
    public string? EndpointConfigName { get; set; }

    [JsonPropertyName("productionVariants")]
    public IList<V1alpha1EndpointStatusPendingDeploymentSummaryProductionVariants>? ProductionVariants { get; set; }

    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }
}

/// <summary>The EC2 capacity reservations that are shared to an ML capacity reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsCapacityReservationConfigEc2CapacityReservations
{
    [JsonPropertyName("availableInstanceCount")]
    public long? AvailableInstanceCount { get; set; }

    [JsonPropertyName("ec2CapacityReservationID")]
    public string? Ec2CapacityReservationID { get; set; }

    [JsonPropertyName("totalInstanceCount")]
    public long? TotalInstanceCount { get; set; }

    [JsonPropertyName("usedByCurrentEndpoint")]
    public long? UsedByCurrentEndpoint { get; set; }
}

/// <summary>Details about an ML capacity reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsCapacityReservationConfig
{
    [JsonPropertyName("availableInstanceCount")]
    public long? AvailableInstanceCount { get; set; }

    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("ec2CapacityReservations")]
    public IList<V1alpha1EndpointStatusProductionVariantsCapacityReservationConfigEc2CapacityReservations>? Ec2CapacityReservations { get; set; }

    [JsonPropertyName("mlReservationARN")]
    public string? MlReservationARN { get; set; }

    [JsonPropertyName("totalInstanceCount")]
    public long? TotalInstanceCount { get; set; }

    [JsonPropertyName("usedByCurrentEndpoint")]
    public long? UsedByCurrentEndpoint { get; set; }
}

/// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsCurrentServerlessConfig
{
    [JsonPropertyName("maxConcurrency")]
    public long? MaxConcurrency { get; set; }

    [JsonPropertyName("memorySizeInMB")]
    public long? MemorySizeInMB { get; set; }

    [JsonPropertyName("provisionedConcurrency")]
    public long? ProvisionedConcurrency { get; set; }
}

/// <summary>
/// Gets the Amazon EC2 Container Registry path of the docker image of the model
/// that is hosted in this ProductionVariant (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ProductionVariant.html).
/// 
/// If you used the registry/repository[:tag] form to specify the image path
/// of the primary container when you created the model hosted in this ProductionVariant,
/// the path resolves to a path of the form registry/repository[@digest]. A digest
/// is a hash value that identifies a specific version of an image. For information
/// about Amazon ECR paths, see Pulling an Image (https://docs.aws.amazon.com/AmazonECR/latest/userguide/docker-pull-ecr-image.html)
/// in the Amazon ECR User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsDeployedImages
{
    [JsonPropertyName("resolutionTime")]
    public DateTime? ResolutionTime { get; set; }

    [JsonPropertyName("resolvedImage")]
    public string? ResolvedImage { get; set; }

    [JsonPropertyName("specifiedImage")]
    public string? SpecifiedImage { get; set; }
}

/// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsDesiredServerlessConfig
{
    [JsonPropertyName("maxConcurrency")]
    public long? MaxConcurrency { get; set; }

    [JsonPropertyName("memorySizeInMB")]
    public long? MemorySizeInMB { get; set; }

    [JsonPropertyName("provisionedConcurrency")]
    public long? ProvisionedConcurrency { get; set; }
}

/// <summary>
/// Settings that control the range in the number of instances that the endpoint
/// provisions as it scales up or down to accommodate traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsManagedInstanceScaling
{
    [JsonPropertyName("maxInstanceCount")]
    public long? MaxInstanceCount { get; set; }

    [JsonPropertyName("minInstanceCount")]
    public long? MinInstanceCount { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Settings that control how the endpoint routes incoming traffic to the instances
/// that the endpoint hosts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsRoutingConfig
{
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>Describes the status of the production variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariantsVariantStatus
{
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>
/// Describes weight and capacities for a production variant associated with
/// an endpoint. If you sent a request to the UpdateEndpointWeightsAndCapacities
/// API and the endpoint status is Updating, you get different desired and current
/// values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatusProductionVariants
{
    /// <summary>Details about an ML capacity reservation.</summary>
    [JsonPropertyName("capacityReservationConfig")]
    public V1alpha1EndpointStatusProductionVariantsCapacityReservationConfig? CapacityReservationConfig { get; set; }

    [JsonPropertyName("currentInstanceCount")]
    public long? CurrentInstanceCount { get; set; }

    /// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
    [JsonPropertyName("currentServerlessConfig")]
    public V1alpha1EndpointStatusProductionVariantsCurrentServerlessConfig? CurrentServerlessConfig { get; set; }

    [JsonPropertyName("currentWeight")]
    public double? CurrentWeight { get; set; }

    [JsonPropertyName("deployedImages")]
    public IList<V1alpha1EndpointStatusProductionVariantsDeployedImages>? DeployedImages { get; set; }

    [JsonPropertyName("desiredInstanceCount")]
    public long? DesiredInstanceCount { get; set; }

    /// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
    [JsonPropertyName("desiredServerlessConfig")]
    public V1alpha1EndpointStatusProductionVariantsDesiredServerlessConfig? DesiredServerlessConfig { get; set; }

    [JsonPropertyName("desiredWeight")]
    public double? DesiredWeight { get; set; }

    /// <summary>
    /// Settings that control the range in the number of instances that the endpoint
    /// provisions as it scales up or down to accommodate traffic.
    /// </summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1alpha1EndpointStatusProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>
    /// Settings that control how the endpoint routes incoming traffic to the instances
    /// that the endpoint hosts.
    /// </summary>
    [JsonPropertyName("routingConfig")]
    public V1alpha1EndpointStatusProductionVariantsRoutingConfig? RoutingConfig { get; set; }

    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    [JsonPropertyName("variantStatus")]
    public IList<V1alpha1EndpointStatusProductionVariantsVariantStatus>? VariantStatus { get; set; }
}

/// <summary>EndpointStatus defines the observed state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1EndpointStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>A timestamp that shows when the endpoint was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// The status of the endpoint.
    /// 
    ///    * OutOfService: Endpoint is not available to take incoming requests.
    /// 
    ///    * Creating: CreateEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html)
    ///    is executing.
    /// 
    ///    * Updating: UpdateEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpoint.html)
    ///    or UpdateEndpointWeightsAndCapacities (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html)
    ///    is executing.
    /// 
    ///    * SystemUpdating: Endpoint is undergoing maintenance and cannot be updated
    ///    or deleted or re-scaled until it has completed. This maintenance operation
    ///    does not change any customer-specified values such as VPC config, KMS
    ///    encryption, model, instance type, or instance count.
    /// 
    ///    * RollingBack: Endpoint fails to scale up or down or change its variant
    ///    weight and is in the process of rolling back to its previous configuration.
    ///    Once the rollback completes, endpoint returns to an InService status.
    ///    This transitional status only applies to an endpoint that has autoscaling
    ///    enabled and is undergoing variant weight or capacity changes as part of
    ///    an UpdateEndpointWeightsAndCapacities (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html)
    ///    call or when the UpdateEndpointWeightsAndCapacities (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html)
    ///    operation is called explicitly.
    /// 
    ///    * InService: Endpoint is available to process incoming requests.
    /// 
    ///    * Deleting: DeleteEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteEndpoint.html)
    ///    is executing.
    /// 
    ///    * Failed: Endpoint could not be created, updated, or re-scaled. Use the
    ///    FailureReason value returned by DescribeEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html)
    ///    for information about the failure. DeleteEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteEndpoint.html)
    ///    is the only operation that can be performed on a failed endpoint.
    /// 
    ///    * UpdateRollbackFailed: Both the rolling deployment and auto-rollback
    ///    failed. Your endpoint is in service with a mix of the old and new endpoint
    ///    configurations. For information about how to remedy this issue and restore
    ///    the endpoint&apos;s status to InService, see Rolling Deployments (https://docs.aws.amazon.com/sagemaker/latest/dg/deployment-guardrails-rolling.html).
    /// </summary>
    [JsonPropertyName("endpointStatus")]
    public string? EndpointStatus { get; set; }

    /// <summary>If the status of the endpoint is Failed, the reason why it failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>A timestamp that shows when the endpoint was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// Returns the summary of an in-progress deployment. This field is only returned
    /// when the endpoint is creating or updating with a new endpoint configuration.
    /// </summary>
    [JsonPropertyName("pendingDeploymentSummary")]
    public V1alpha1EndpointStatusPendingDeploymentSummary? PendingDeploymentSummary { get; set; }

    /// <summary>
    /// An array of ProductionVariantSummary (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ProductionVariantSummary.html)
    /// objects, one for each model hosted behind this endpoint.
    /// </summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1alpha1EndpointStatusProductionVariants>? ProductionVariants { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EndpointSpec?>, IStatus<V1alpha1EndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Endpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// EndpointSpec defines the desired state of Endpoint.
    /// 
    /// A hosted endpoint for real-time inference.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1EndpointSpec? Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1EndpointStatus? Status { get; set; }
}