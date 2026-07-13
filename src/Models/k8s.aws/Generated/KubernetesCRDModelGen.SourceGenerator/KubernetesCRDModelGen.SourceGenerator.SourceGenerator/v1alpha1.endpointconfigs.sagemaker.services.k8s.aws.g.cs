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
/// <summary>EndpointConfig is the Schema for the EndpointConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EndpointConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EndpointConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EndpointConfigList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "endpointconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1EndpointConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1EndpointConfig> Items { get; set; }
}

/// <summary>
/// Configures the behavior of the client used by SageMaker to interact with
/// the model container during asynchronous inference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecAsyncInferenceConfigClientConfig
{
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public long? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>
/// Specifies the configuration for notifications of inference results for asynchronous
/// inference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecAsyncInferenceConfigOutputConfigNotificationConfig
{
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary>Specifies the configuration for asynchronous inference invocation outputs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecAsyncInferenceConfigOutputConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// Specifies the configuration for notifications of inference results for asynchronous
    /// inference.
    /// </summary>
    [JsonPropertyName("notificationConfig")]
    public V1alpha1EndpointConfigSpecAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// Specifies configuration for how an endpoint performs asynchronous inference.
/// This is a required field in order for your Endpoint to be invoked using InvokeEndpointAsync
/// (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpointAsync.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecAsyncInferenceConfig
{
    /// <summary>
    /// Configures the behavior of the client used by SageMaker to interact with
    /// the model container during asynchronous inference.
    /// </summary>
    [JsonPropertyName("clientConfig")]
    public V1alpha1EndpointConfigSpecAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Specifies the configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1alpha1EndpointConfigSpecAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>
/// Configuration specifying how to treat different headers. If no headers are
/// specified Amazon SageMaker AI will by default base64 encode when capturing
/// the data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecDataCaptureConfigCaptureContentTypeHeader
{
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

/// <summary>Specifies data Model Monitor will capture.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecDataCaptureConfigCaptureOptions
{
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Configuration to control how SageMaker AI captures inference data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecDataCaptureConfig
{
    /// <summary>
    /// Configuration specifying how to treat different headers. If no headers are
    /// specified Amazon SageMaker AI will by default base64 encode when capturing
    /// the data.
    /// </summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1alpha1EndpointConfigSpecDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    [JsonPropertyName("captureOptions")]
    public IList<V1alpha1EndpointConfigSpecDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    [JsonPropertyName("destinationS3URI")]
    public string? DestinationS3URI { get; set; }

    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    [JsonPropertyName("initialSamplingPercentage")]
    public long? InitialSamplingPercentage { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }
}

/// <summary>
/// Settings for the capacity reservation for the compute instances that SageMaker
/// AI reserves for an endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecProductionVariantsCapacityReservationConfig
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("mlReservationARN")]
    public string? MlReservationARN { get; set; }
}

/// <summary>
/// Specifies configuration for a core dump from the model container when the
/// process crashes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecProductionVariantsCoreDumpConfig
{
    [JsonPropertyName("destinationS3URI")]
    public string? DestinationS3URI { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }
}

/// <summary>
/// Settings that control the range in the number of instances that the endpoint
/// provisions as it scales up or down to accommodate traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecProductionVariantsManagedInstanceScaling
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
public partial class V1alpha1EndpointConfigSpecProductionVariantsRoutingConfig
{
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecProductionVariantsServerlessConfig
{
    [JsonPropertyName("maxConcurrency")]
    public long? MaxConcurrency { get; set; }

    [JsonPropertyName("memorySizeInMB")]
    public long? MemorySizeInMB { get; set; }

    [JsonPropertyName("provisionedConcurrency")]
    public long? ProvisionedConcurrency { get; set; }
}

/// <summary>
/// Identifies a model that you want to host and the resources chosen to deploy
/// for hosting it. If you are deploying multiple models, tell SageMaker how
/// to distribute traffic among the models by specifying variant weights. For
/// more information on production variants, check Production variants (https://docs.aws.amazon.com/sagemaker/latest/dg/model-ab-testing.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecProductionVariants
{
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>
    /// Settings for the capacity reservation for the compute instances that SageMaker
    /// AI reserves for an endpoint.
    /// </summary>
    [JsonPropertyName("capacityReservationConfig")]
    public V1alpha1EndpointConfigSpecProductionVariantsCapacityReservationConfig? CapacityReservationConfig { get; set; }

    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public long? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// Specifies configuration for a core dump from the model container when the
    /// process crashes.
    /// </summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1alpha1EndpointConfigSpecProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    [JsonPropertyName("enableSSMAccess")]
    public bool? EnableSSMAccess { get; set; }

    [JsonPropertyName("initialInstanceCount")]
    public long? InitialInstanceCount { get; set; }

    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// Settings that control the range in the number of instances that the endpoint
    /// provisions as it scales up or down to accommodate traffic.
    /// </summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1alpha1EndpointConfigSpecProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public long? ModelDataDownloadTimeoutInSeconds { get; set; }

    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>
    /// Settings that control how the endpoint routes incoming traffic to the instances
    /// that the endpoint hosts.
    /// </summary>
    [JsonPropertyName("routingConfig")]
    public V1alpha1EndpointConfigSpecProductionVariantsRoutingConfig? RoutingConfig { get; set; }

    /// <summary>Specifies the serverless configuration for an endpoint variant.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1alpha1EndpointConfigSpecProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    [JsonPropertyName("volumeSizeInGB")]
    public long? VolumeSizeInGB { get; set; }
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
public partial class V1alpha1EndpointConfigSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpecVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>EndpointConfigSpec defines the desired state of EndpointConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigSpec
{
    /// <summary>
    /// Specifies configuration for how an endpoint performs asynchronous inference.
    /// This is a required field in order for your Endpoint to be invoked using InvokeEndpointAsync
    /// (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpointAsync.html).
    /// </summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1alpha1EndpointConfigSpecAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Configuration to control how SageMaker AI captures inference data.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1alpha1EndpointConfigSpecDataCaptureConfig? DataCaptureConfig { get; set; }

    /// <summary>
    /// Sets whether all model containers deployed to the endpoint are isolated.
    /// If they are, no inbound or outbound network calls can be made to or from
    /// the model containers.
    /// </summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// The name of the endpoint configuration. You specify this name in a CreateEndpoint
    /// (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html)
    /// request.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("endpointConfigName")]
    public required string EndpointConfigName { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI can
    /// assume to perform actions on your behalf. For more information, see SageMaker
    /// AI Roles (https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html).
    /// 
    /// To be able to pass this role to Amazon SageMaker AI, the caller of this action
    /// must have the iam:PassRole permission.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("executionRoleARN")]
    public string? ExecutionRoleARN { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service
    /// key that SageMaker uses to encrypt data on the storage volume attached to
    /// the ML compute instance that hosts the endpoint.
    /// 
    /// The KmsKeyId can be any of the following formats:
    /// 
    ///   - Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab
    /// 
    ///   - Key ARN: arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
    /// 
    ///   - Alias name: alias/ExampleAlias
    /// 
    ///   - Alias name ARN: arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias
    /// 
    /// The KMS key policy must grant permission to the IAM role that you specify
    /// in your CreateEndpoint, UpdateEndpoint requests. For more information, refer
    /// to the Amazon Web Services Key Management Service section Using Key Policies
    /// in Amazon Web Services KMS (https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html)
    /// 
    /// Certain Nitro-based instances include local storage, dependent on the instance
    /// type. Local storage volumes are encrypted using a hardware module on the
    /// instance. You can&apos;t request a KmsKeyId when using an instance type with local
    /// storage. If any of the models that you specify in the ProductionVariants
    /// parameter use nitro-based instances with local storage, do not specify a
    /// value for the KmsKeyId parameter. If you specify a value for KmsKeyId when
    /// using any nitro-based instances with local storage, the call to CreateEndpointConfig
    /// fails.
    /// 
    /// For a list of instance types that support local instance storage, see Instance
    /// Store Volumes (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#instance-store-volumes).
    /// 
    /// For more information about local instance storage encryption, see SSD Instance
    /// Store Volumes (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssd-instance-store.html).
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9:/_-]*$`
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// An array of ProductionVariant objects, one for each model that you want to
    /// host at this endpoint.
    /// </summary>
    [JsonPropertyName("productionVariants")]
    public required IList<V1alpha1EndpointConfigSpecProductionVariants> ProductionVariants { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1EndpointConfigSpecTags>? Tags { get; set; }

    /// <summary>
    /// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
    /// hosted models, and compute resources have access to. You can control access
    /// to and from your resources by configuring a VPC. For more information, see
    /// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1EndpointConfigSpecVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigStatusAckResourceMetadata
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
public partial class V1alpha1EndpointConfigStatusConditions
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

/// <summary>EndpointConfigStatus defines the observed state of EndpointConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EndpointConfigStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1EndpointConfigStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EndpointConfigStatusConditions>? Conditions { get; set; }
}

/// <summary>EndpointConfig is the Schema for the EndpointConfigs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EndpointConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EndpointConfigSpec?>, IStatus<V1alpha1EndpointConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EndpointConfig";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "endpointconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointConfigSpec defines the desired state of EndpointConfig.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1EndpointConfigSpec? Spec { get; set; }

    /// <summary>EndpointConfigStatus defines the observed state of EndpointConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1EndpointConfigStatus? Status { get; set; }
}