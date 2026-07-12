#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.services.k8s.aws;
/// <summary>Version is the Schema for the Versions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VersionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Version>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VersionList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "versions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VersionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Version objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Version> Items { get; set; }
}

/// <summary>
/// A destination for events that failed processing. For more information, see
/// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecFunctionEventInvokeConfigDestinationConfigOnFailure
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>
/// A destination for events that were processed successfully.
/// 
/// To retain records of successful asynchronous invocations (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations),
/// you can configure an Amazon SNS topic, Amazon SQS queue, Lambda function,
/// or Amazon EventBridge event bus as the destination.
/// 
/// OnSuccess is not supported in CreateEventSourceMapping or UpdateEventSourceMapping
/// requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecFunctionEventInvokeConfigDestinationConfigOnSuccess
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>
/// A configuration object that specifies the destination of an event after Lambda
/// processes it. For more information, see Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecFunctionEventInvokeConfigDestinationConfig
{
    /// <summary>
    /// A destination for events that failed processing. For more information, see
    /// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("onFailure")]
    public V1alpha1VersionSpecFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure { get; set; }

    /// <summary>
    /// A destination for events that were processed successfully.
    /// 
    /// To retain records of successful asynchronous invocations (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations),
    /// you can configure an Amazon SNS topic, Amazon SQS queue, Lambda function,
    /// or Amazon EventBridge event bus as the destination.
    /// 
    /// OnSuccess is not supported in CreateEventSourceMapping or UpdateEventSourceMapping
    /// requests.
    /// </summary>
    [JsonPropertyName("onSuccess")]
    public V1alpha1VersionSpecFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecFunctionEventInvokeConfig
{
    /// <summary>
    /// A configuration object that specifies the destination of an event after Lambda
    /// processes it. For more information, see Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1alpha1VersionSpecFunctionEventInvokeConfigDestinationConfig? DestinationConfig { get; set; }

    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    [JsonPropertyName("maximumEventAgeInSeconds")]
    public long? MaximumEventAgeInSeconds { get; set; }

    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }

    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecFunctionRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecFunctionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VersionSpecFunctionRefFrom? From { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpecProvisionedConcurrencyConfig
{
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    [JsonPropertyName("provisionedConcurrentExecutions")]
    public long? ProvisionedConcurrentExecutions { get; set; }

    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionSpec
{
    /// <summary>
    /// Only publish a version if the hash value matches the value that&apos;s specified.
    /// Use this option to avoid publishing a version if the function code has changed
    /// since you last updated it. You can get the hash for the version that you
    /// uploaded from the output of UpdateFunctionCode.
    /// </summary>
    [JsonPropertyName("codeSHA256")]
    public string? CodeSHA256 { get; set; }

    /// <summary>
    /// A description for the version to override the description in the function
    /// configuration.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("functionEventInvokeConfig")]
    public V1alpha1VersionSpecFunctionEventInvokeConfig? FunctionEventInvokeConfig { get; set; }

    /// <summary>
    /// The name or ARN of the Lambda function.
    /// 
    /// Name formats
    /// 
    ///   - Function name - MyFunction.
    /// 
    ///   - Function ARN - arn:aws:lambda:us-west-2:123456789012:function:MyFunction.
    /// 
    ///   - Partial ARN - 123456789012:function:MyFunction.
    /// 
    /// The length constraint applies only to the full ARN. If you specify only the
    /// function name, it is limited to 64 characters in length.
    /// 
    /// Regex Pattern: `^(arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("functionRef")]
    public V1alpha1VersionSpecFunctionRef? FunctionRef { get; set; }

    [JsonPropertyName("provisionedConcurrencyConfig")]
    public V1alpha1VersionSpecProvisionedConcurrencyConfig? ProvisionedConcurrencyConfig { get; set; }

    /// <summary>
    /// Only update the function if the revision ID matches the ID that&apos;s specified.
    /// Use this option to avoid publishing a version if the function configuration
    /// has changed since you last updated it.
    /// </summary>
    [JsonPropertyName("revisionID")]
    public string? RevisionID { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusConditions
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

/// <summary>The function&apos;s dead letter queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusDeadLetterConfig
{
    [JsonPropertyName("targetARN")]
    public string? TargetARN { get; set; }
}

/// <summary>
/// The function&apos;s durable execution configuration settings, if the function
/// is configured for durability.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusDurableConfig
{
    [JsonPropertyName("executionTimeout")]
    public long? ExecutionTimeout { get; set; }

    [JsonPropertyName("retentionPeriodInDays")]
    public long? RetentionPeriodInDays { get; set; }
}

/// <summary>Error messages for environment variables that couldn&apos;t be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusEnvironmentError
{
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// The function&apos;s environment variables (https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html).
/// Omitted from CloudTrail logs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusEnvironment
{
    /// <summary>Error messages for environment variables that couldn&apos;t be applied.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VersionStatusEnvironmentError? Error { get; set; }

    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary>
/// The size of the function&apos;s /tmp directory in MB. The default value is 512,
/// but can be any whole number between 512 and 10,240 MB. For more information,
/// see Configuring ephemeral storage (console) (https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-ephemeral-storage).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusEphemeralStorage
{
    [JsonPropertyName("size")]
    public long? Size { get; set; }
}

/// <summary>
/// Details about the connection between a Lambda function and an Amazon EFS
/// file system (https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusFileSystemConfigs
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("localMountPath")]
    public string? LocalMountPath { get; set; }
}

/// <summary>Error response to GetFunctionConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusImageConfigResponseError
{
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// Configuration values that override the container image Dockerfile settings.
/// For more information, see Container image settings (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusImageConfigResponseImageConfig
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>The function&apos;s image configuration values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusImageConfigResponse
{
    /// <summary>Error response to GetFunctionConfiguration.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VersionStatusImageConfigResponseError? Error { get; set; }

    /// <summary>
    /// Configuration values that override the container image Dockerfile settings.
    /// For more information, see Container image settings (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms).
    /// </summary>
    [JsonPropertyName("imageConfig")]
    public V1alpha1VersionStatusImageConfigResponseImageConfig? ImageConfig { get; set; }
}

/// <summary>An Lambda layer (https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusLayers
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("codeSize")]
    public long? CodeSize { get; set; }

    [JsonPropertyName("signingJobARN")]
    public string? SigningJobARN { get; set; }

    [JsonPropertyName("signingProfileVersionARN")]
    public string? SigningProfileVersionARN { get; set; }
}

/// <summary>
/// Set ApplyOn to PublishedVersions to create a snapshot of the initialized
/// execution environment when you publish a function version. For more information,
/// see Improving startup performance with Lambda SnapStart (https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusSnapStart
{
    [JsonPropertyName("applyOn")]
    public string? ApplyOn { get; set; }

    [JsonPropertyName("optimizationStatus")]
    public string? OptimizationStatus { get; set; }
}

/// <summary>
/// The function&apos;s tenant isolation configuration settings. Determines whether
/// the Lambda function runs on a shared or dedicated infrastructure per unique
/// tenant.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusTenancyConfig
{
    [JsonPropertyName("tenantIsolationMode")]
    public string? TenantIsolationMode { get; set; }
}

/// <summary>The function&apos;s X-Ray tracing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusTracingConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>The function&apos;s networking configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatusVpcConfig
{
    [JsonPropertyName("ipv6AllowedForDualStack")]
    public bool? Ipv6AllowedForDualStack { get; set; }

    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>VersionStatus defines the observed state of Version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VersionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VersionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The instruction set architecture that the function supports. Architecture
    /// is a string array with one of the valid values. The default architecture
    /// value is x86_64.
    /// </summary>
    [JsonPropertyName("architectures")]
    public IList<string>? Architectures { get; set; }

    /// <summary>The size of the function&apos;s deployment package, in bytes.</summary>
    [JsonPropertyName("codeSize")]
    public long? CodeSize { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VersionStatusConditions>? Conditions { get; set; }

    /// <summary>The function&apos;s dead letter queue.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1alpha1VersionStatusDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>
    /// The function&apos;s durable execution configuration settings, if the function
    /// is configured for durability.
    /// </summary>
    [JsonPropertyName("durableConfig")]
    public V1alpha1VersionStatusDurableConfig? DurableConfig { get; set; }

    /// <summary>
    /// The function&apos;s environment variables (https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html).
    /// Omitted from CloudTrail logs.
    /// </summary>
    [JsonPropertyName("environment")]
    public V1alpha1VersionStatusEnvironment? Environment { get; set; }

    /// <summary>
    /// The size of the function&apos;s /tmp directory in MB. The default value is 512,
    /// but can be any whole number between 512 and 10,240 MB. For more information,
    /// see Configuring ephemeral storage (console) (https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-ephemeral-storage).
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1alpha1VersionStatusEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>Connection settings for an Amazon EFS file system (https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html).</summary>
    [JsonPropertyName("fileSystemConfigs")]
    public IList<V1alpha1VersionStatusFileSystemConfigs>? FileSystemConfigs { get; set; }

    /// <summary>
    /// The function&apos;s Amazon Resource Name (ARN).
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:\d{12}:function:[a-zA-Z0-9-_\.]+(:(\$LATEST(\.PUBLISHED)?|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("functionARN")]
    public string? FunctionARN { get; set; }

    /// <summary>
    /// The function that Lambda calls to begin running your function.
    /// 
    /// Regex Pattern: `^[^\s]+$`
    /// </summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary>The function&apos;s image configuration values.</summary>
    [JsonPropertyName("imageConfigResponse")]
    public V1alpha1VersionStatusImageConfigResponse? ImageConfigResponse { get; set; }

    /// <summary>
    /// The ARN of the Key Management Service (KMS) customer managed key that&apos;s used
    /// to encrypt the following resources:
    /// 
    ///    * The function&apos;s environment variables (https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html#configuration-envvars-encryption).
    /// 
    ///    * The function&apos;s Lambda SnapStart (https://docs.aws.amazon.com/lambda/latest/dg/snapstart-security.html)
    ///    snapshots.
    /// 
    ///    * When used with SourceKMSKeyArn, the unzipped version of the .zip deployment
    ///    package that&apos;s used for function invocations. For more information, see
    ///    Specifying a customer managed key for Lambda (https://docs.aws.amazon.com/lambda/latest/dg/encrypt-zip-package.html#enable-zip-custom-encryption).
    /// 
    ///    * The optimized version of the container image that&apos;s used for function
    ///    invocations. Note that this is not the same key that&apos;s used to protect
    ///    your container image in the Amazon Elastic Container Registry (Amazon
    ///    ECR). For more information, see Function lifecycle (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-lifecycle).
    /// 
    /// If you don&apos;t provide a customer managed key, Lambda uses an Amazon Web Services
    /// owned key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk)
    /// or an Amazon Web Services managed key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk).
    /// 
    /// Regex Pattern: `^(arn:(aws[a-zA-Z-]*)?:[a-z0-9-.]+:.*)|()$`
    /// </summary>
    [JsonPropertyName("kmsKeyARN")]
    public string? KmsKeyARN { get; set; }

    /// <summary>
    /// The date and time that the function was last updated, in ISO-8601 format
    /// (https://www.w3.org/TR/NOTE-datetime) (YYYY-MM-DDThh:mm:ss.sTZD).
    /// </summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>
    /// The status of the last update that was performed on the function. This is
    /// first set to Successful after function creation completes.
    /// </summary>
    [JsonPropertyName("lastUpdateStatus")]
    public string? LastUpdateStatus { get; set; }

    /// <summary>The reason for the last update that was performed on the function.</summary>
    [JsonPropertyName("lastUpdateStatusReason")]
    public string? LastUpdateStatusReason { get; set; }

    /// <summary>The reason code for the last update that was performed on the function.</summary>
    [JsonPropertyName("lastUpdateStatusReasonCode")]
    public string? LastUpdateStatusReasonCode { get; set; }

    /// <summary>The function&apos;s layers (https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html).</summary>
    [JsonPropertyName("layers")]
    public IList<V1alpha1VersionStatusLayers>? Layers { get; set; }

    /// <summary>
    /// For Lambda@Edge functions, the ARN of the main function.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:\d{12}:function:[a-zA-Z0-9-_]+(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("masterARN")]
    public string? MasterARN { get; set; }

    /// <summary>The amount of memory available to the function at runtime.</summary>
    [JsonPropertyName("memorySize")]
    public long? MemorySize { get; set; }

    /// <summary>
    /// The type of deployment package. Set to Image for container image and set
    /// Zip for .zip file archive.
    /// </summary>
    [JsonPropertyName("packageType")]
    public string? PackageType { get; set; }

    /// <summary>
    /// The version of the Lambda function.
    /// 
    /// Regex Pattern: `^(\$LATEST|[0-9]+)$`
    /// </summary>
    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }

    /// <summary>
    /// The function&apos;s execution role.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// The identifier of the function&apos;s runtime (https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html).
    /// Runtime is required if the deployment package is a .zip file archive. Specifying
    /// a runtime results in an error if you&apos;re deploying a function using a container
    /// image.
    /// 
    /// The following list includes deprecated runtimes. Lambda blocks creating new
    /// functions and updating existing functions shortly after each runtime is deprecated.
    /// For more information, see Runtime use after deprecation (https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-deprecation-levels).
    /// 
    /// For a list of all currently supported runtimes, see Supported runtimes (https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtimes-supported).
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>
    /// The ARN of the signing job.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-])+:([a-z]{2}(-gov)?-[a-z]+-\d{1})?:(\d{12})?:(.*)$`
    /// </summary>
    [JsonPropertyName("signingJobARN")]
    public string? SigningJobARN { get; set; }

    /// <summary>
    /// The ARN of the signing profile version.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-])+:([a-z]{2}(-gov)?-[a-z]+-\d{1})?:(\d{12})?:(.*)$`
    /// </summary>
    [JsonPropertyName("signingProfileVersionARN")]
    public string? SigningProfileVersionARN { get; set; }

    /// <summary>
    /// Set ApplyOn to PublishedVersions to create a snapshot of the initialized
    /// execution environment when you publish a function version. For more information,
    /// see Improving startup performance with Lambda SnapStart (https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html).
    /// </summary>
    [JsonPropertyName("snapStart")]
    public V1alpha1VersionStatusSnapStart? SnapStart { get; set; }

    /// <summary>
    /// The current state of the function. When the state is Inactive, you can reactivate
    /// the function by invoking it.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The reason for the function&apos;s current state.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>
    /// The reason code for the function&apos;s current state. When the code is Creating,
    /// you can&apos;t invoke or modify the function.
    /// </summary>
    [JsonPropertyName("stateReasonCode")]
    public string? StateReasonCode { get; set; }

    /// <summary>
    /// The function&apos;s tenant isolation configuration settings. Determines whether
    /// the Lambda function runs on a shared or dedicated infrastructure per unique
    /// tenant.
    /// </summary>
    [JsonPropertyName("tenancyConfig")]
    public V1alpha1VersionStatusTenancyConfig? TenancyConfig { get; set; }

    /// <summary>
    /// The amount of time in seconds that Lambda allows a function to run before
    /// stopping it.
    /// </summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }

    /// <summary>The function&apos;s X-Ray tracing configuration.</summary>
    [JsonPropertyName("tracingConfig")]
    public V1alpha1VersionStatusTracingConfig? TracingConfig { get; set; }

    /// <summary>
    /// The version of the Lambda function.
    /// 
    /// Regex Pattern: `^(\$LATEST|[0-9]+)$`
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The function&apos;s networking configuration.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1VersionStatusVpcConfig? VpcConfig { get; set; }
}

/// <summary>Version is the Schema for the Versions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Version : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VersionSpec?>, IStatus<V1alpha1VersionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Version";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "versions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Version";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1VersionSpec? Spec { get; set; }

    /// <summary>VersionStatus defines the observed state of Version</summary>
    [JsonPropertyName("status")]
    public V1alpha1VersionStatus? Status { get; set; }
}