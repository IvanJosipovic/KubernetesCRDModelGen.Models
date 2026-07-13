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
/// <summary>Function is the Schema for the Functions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Function>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Function objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Function> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecCodeS3BucketRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for S3Bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecCodeS3BucketRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionSpecCodeS3BucketRefFrom? From { get; set; }
}

/// <summary>The code for the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecCode
{
    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }

    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference field for S3Bucket</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1alpha1FunctionSpecCodeS3BucketRef? S3BucketRef { get; set; }

    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }

    [JsonPropertyName("zipFile")]
    public byte[]? ZipFile { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecCodeSigningConfigRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecCodeSigningConfigRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionSpecCodeSigningConfigRefFrom? From { get; set; }
}

/// <summary>
/// A dead-letter queue configuration that specifies the queue or topic where
/// Lambda sends asynchronous events when they fail processing. For more information,
/// see Dead-letter queues (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecDeadLetterConfig
{
    [JsonPropertyName("targetARN")]
    public string? TargetARN { get; set; }
}

/// <summary>
/// Configuration settings for durable functions. Enables creating functions
/// with durability that can remember their state and continue execution even
/// after interruptions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecDurableConfig
{
    [JsonPropertyName("executionTimeout")]
    public long? ExecutionTimeout { get; set; }

    [JsonPropertyName("retentionPeriodInDays")]
    public long? RetentionPeriodInDays { get; set; }
}

/// <summary>Environment variables that are accessible from function code during execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecEnvironment
{
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary>
/// The size of the function&apos;s /tmp directory in MB. The default value is 512,
/// but can be any whole number between 512 and 10,240 MB. For more information,
/// see Configuring ephemeral storage (console) (https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-ephemeral-storage).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecEphemeralStorage
{
    [JsonPropertyName("size")]
    public long? Size { get; set; }
}

/// <summary>
/// Details about the connection between a Lambda function and an Amazon EFS
/// file system (https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecFileSystemConfigs
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("localMountPath")]
    public string? LocalMountPath { get; set; }
}

/// <summary>
/// A destination for events that failed processing. For more information, see
/// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecFunctionEventInvokeConfigDestinationConfigOnFailure
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecFunctionEventInvokeConfigDestinationConfigOnSuccess
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>
/// A configuration object that specifies the destination of an event after Lambda
/// processes it. For more information, see Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecFunctionEventInvokeConfigDestinationConfig
{
    /// <summary>
    /// A destination for events that failed processing. For more information, see
    /// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("onFailure")]
    public V1alpha1FunctionSpecFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure { get; set; }

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
    public V1alpha1FunctionSpecFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess { get; set; }
}

/// <summary>
/// Configures options for asynchronous invocation on a function.
/// 
/// - DestinationConfig
/// A destination for events after they have been sent to a function for processing.
/// 
/// Types of Destinations:
/// Function - The Amazon Resource Name (ARN) of a Lambda function.
/// Queue - The ARN of a standard SQS queue.
/// Topic - The ARN of a standard SNS topic.
/// Event Bus - The ARN of an Amazon EventBridge event bus.
/// 
/// - MaximumEventAgeInSeconds
/// The maximum age of a request that Lambda sends to a function for processing.
/// 
/// - MaximumRetryAttempts
/// The maximum number of times to retry when the function returns an error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecFunctionEventInvokeConfig
{
    /// <summary>
    /// A configuration object that specifies the destination of an event after Lambda
    /// processes it. For more information, see Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1alpha1FunctionSpecFunctionEventInvokeConfigDestinationConfig? DestinationConfig { get; set; }

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
/// Container image configuration values (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms)
/// that override the values in the container image Dockerfile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecImageConfig
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecKmsKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>The function&apos;s Amazon CloudWatch Logs configuration settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecLoggingConfig
{
    [JsonPropertyName("applicationLogLevel")]
    public string? ApplicationLogLevel { get; set; }

    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    [JsonPropertyName("systemLogLevel")]
    public string? SystemLogLevel { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecRoleRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// The function&apos;s SnapStart (https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html)
/// setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecSnapStart
{
    [JsonPropertyName("applyOn")]
    public string? ApplyOn { get; set; }
}

/// <summary>
/// Configuration for multi-tenant applications that use Lambda functions. Defines
/// tenant isolation settings and resource allocations. Required for functions
/// supporting multiple tenants.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecTenancyConfig
{
    [JsonPropertyName("tenantIsolationMode")]
    public string? TenantIsolationMode { get; set; }
}

/// <summary>
/// Set Mode to Active to sample and trace a subset of incoming requests with
/// X-Ray (https://docs.aws.amazon.com/lambda/latest/dg/services-xray.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecTracingConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecVpcConfigSecurityGroupRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecVpcConfigSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionSpecVpcConfigSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecVpcConfigSubnetRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecVpcConfigSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FunctionSpecVpcConfigSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// For network connectivity to Amazon Web Services resources in a VPC, specify
/// a list of security groups and subnets in the VPC. When you connect a function
/// to a VPC, it can access resources and the internet only through that VPC.
/// For more information, see Configuring a Lambda function to access resources
/// in a VPC (https://docs.aws.amazon.com/lambda/latest/dg/configuration-vpc.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    /// <summary>Reference field for SecurityGroupIDs</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1FunctionSpecVpcConfigSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    /// <summary>Reference field for SubnetIDs</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1FunctionSpecVpcConfigSubnetRefs>? SubnetRefs { get; set; }
}

/// <summary>FunctionSpec defines the desired state of Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpec
{
    /// <summary>
    /// The instruction set architecture that the function supports. Enter a string
    /// array with one of the valid values (arm64 or x86_64). The default value is
    /// x86_64.
    /// </summary>
    [JsonPropertyName("architectures")]
    public IList<string>? Architectures { get; set; }

    /// <summary>The code for the function.</summary>
    [JsonPropertyName("code")]
    public required V1alpha1FunctionSpecCode Code { get; set; }

    /// <summary>
    /// To enable code signing for this function, specify the ARN of a code-signing
    /// configuration. A code-signing configuration includes a set of signing profiles,
    /// which define the trusted publishers for this function.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso(b?)))?-[a-z]+-\d{1}:\d{12}:code-signing-config:csc-[a-z0-9]{17}$`
    /// </summary>
    [JsonPropertyName("codeSigningConfigARN")]
    public string? CodeSigningConfigARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("codeSigningConfigRef")]
    public V1alpha1FunctionSpecCodeSigningConfigRef? CodeSigningConfigRef { get; set; }

    /// <summary>
    /// A dead-letter queue configuration that specifies the queue or topic where
    /// Lambda sends asynchronous events when they fail processing. For more information,
    /// see Dead-letter queues (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq).
    /// </summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1alpha1FunctionSpecDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>A description of the function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Configuration settings for durable functions. Enables creating functions
    /// with durability that can remember their state and continue execution even
    /// after interruptions.
    /// </summary>
    [JsonPropertyName("durableConfig")]
    public V1alpha1FunctionSpecDurableConfig? DurableConfig { get; set; }

    /// <summary>Environment variables that are accessible from function code during execution.</summary>
    [JsonPropertyName("environment")]
    public V1alpha1FunctionSpecEnvironment? Environment { get; set; }

    /// <summary>
    /// The size of the function&apos;s /tmp directory in MB. The default value is 512,
    /// but can be any whole number between 512 and 10,240 MB. For more information,
    /// see Configuring ephemeral storage (console) (https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-ephemeral-storage).
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public V1alpha1FunctionSpecEphemeralStorage? EphemeralStorage { get; set; }

    /// <summary>Connection settings for an Amazon EFS file system.</summary>
    [JsonPropertyName("fileSystemConfigs")]
    public IList<V1alpha1FunctionSpecFileSystemConfigs>? FileSystemConfigs { get; set; }

    /// <summary>
    /// Configures options for asynchronous invocation on a function.
    /// 
    /// - DestinationConfig
    /// A destination for events after they have been sent to a function for processing.
    /// 
    /// Types of Destinations:
    /// Function - The Amazon Resource Name (ARN) of a Lambda function.
    /// Queue - The ARN of a standard SQS queue.
    /// Topic - The ARN of a standard SNS topic.
    /// Event Bus - The ARN of an Amazon EventBridge event bus.
    /// 
    /// - MaximumEventAgeInSeconds
    /// The maximum age of a request that Lambda sends to a function for processing.
    /// 
    /// - MaximumRetryAttempts
    /// The maximum number of times to retry when the function returns an error.
    /// </summary>
    [JsonPropertyName("functionEventInvokeConfig")]
    public V1alpha1FunctionSpecFunctionEventInvokeConfig? FunctionEventInvokeConfig { get; set; }

    /// <summary>
    /// The name of the method within your code that Lambda calls to run your function.
    /// Handler is required if the deployment package is a .zip file archive. The
    /// format includes the file name. It can also include namespaces and other qualifiers,
    /// depending on the runtime. For more information, see Lambda programming model
    /// (https://docs.aws.amazon.com/lambda/latest/dg/foundation-progmodel.html).
    /// 
    /// Regex Pattern: `^[^\s]+$`
    /// </summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary>
    /// Container image configuration values (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms)
    /// that override the values in the container image Dockerfile.
    /// </summary>
    [JsonPropertyName("imageConfig")]
    public V1alpha1FunctionSpecImageConfig? ImageConfig { get; set; }

    /// <summary>
    /// The ARN of the Key Management Service (KMS) customer managed key that&apos;s used
    /// to encrypt the following resources:
    /// 
    ///   - The function&apos;s environment variables (https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html#configuration-envvars-encryption).
    /// 
    ///   - The function&apos;s Lambda SnapStart (https://docs.aws.amazon.com/lambda/latest/dg/snapstart-security.html)
    ///     snapshots.
    /// 
    ///   - When used with SourceKMSKeyArn, the unzipped version of the .zip deployment
    ///     package that&apos;s used for function invocations. For more information, see
    ///     Specifying a customer managed key for Lambda (https://docs.aws.amazon.com/lambda/latest/dg/encrypt-zip-package.html#enable-zip-custom-encryption).
    /// 
    ///   - The optimized version of the container image that&apos;s used for function
    ///     invocations. Note that this is not the same key that&apos;s used to protect
    ///     your container image in the Amazon Elastic Container Registry (Amazon
    ///     ECR). For more information, see Function lifecycle (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-lifecycle).
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
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1FunctionSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// A list of function layers (https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html)
    /// to add to the function&apos;s execution environment. Specify each layer by its
    /// ARN, including the version.
    /// </summary>
    [JsonPropertyName("layers")]
    public IList<string>? Layers { get; set; }

    /// <summary>The function&apos;s Amazon CloudWatch Logs configuration settings.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1alpha1FunctionSpecLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// The amount of memory available to the function (https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console)
    /// at runtime. Increasing the function memory also increases its CPU allocation.
    /// The default value is 128 MB. The value can be any multiple of 1 MB.
    /// </summary>
    [JsonPropertyName("memorySize")]
    public long? MemorySize { get; set; }

    /// <summary>
    /// The name or ARN of the Lambda function.
    /// 
    /// Name formats
    /// 
    ///   - Function name – my-function.
    /// 
    ///   - Function ARN – arn:aws:lambda:us-west-2:123456789012:function:my-function.
    /// 
    ///   - Partial ARN – 123456789012:function:my-function.
    /// 
    /// The length constraint applies only to the full ARN. If you specify only the
    /// function name, it is limited to 64 characters in length.
    /// 
    /// Regex Pattern: `^(arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The type of deployment package. Set to Image for container image and set
    /// to Zip for .zip file archive.
    /// </summary>
    [JsonPropertyName("packageType")]
    public string? PackageType { get; set; }

    /// <summary>Set to true to publish the first version of the function during creation.</summary>
    [JsonPropertyName("publish")]
    public bool? Publish { get; set; }

    /// <summary>The number of simultaneous executions to reserve for the function.</summary>
    [JsonPropertyName("reservedConcurrentExecutions")]
    public long? ReservedConcurrentExecutions { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the function&apos;s execution role.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1FunctionSpecRoleRef? RoleRef { get; set; }

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
    /// The function&apos;s SnapStart (https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html)
    /// setting.
    /// </summary>
    [JsonPropertyName("snapStart")]
    public V1alpha1FunctionSpecSnapStart? SnapStart { get; set; }

    /// <summary>
    /// A list of tags (https://docs.aws.amazon.com/lambda/latest/dg/tagging.html)
    /// to apply to the function.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Configuration for multi-tenant applications that use Lambda functions. Defines
    /// tenant isolation settings and resource allocations. Required for functions
    /// supporting multiple tenants.
    /// </summary>
    [JsonPropertyName("tenancyConfig")]
    public V1alpha1FunctionSpecTenancyConfig? TenancyConfig { get; set; }

    /// <summary>
    /// The amount of time (in seconds) that Lambda allows a function to run before
    /// stopping it. The default is 3 seconds. The maximum allowed value is 900 seconds.
    /// For more information, see Lambda execution environment (https://docs.aws.amazon.com/lambda/latest/dg/runtimes-context.html).
    /// </summary>
    [JsonPropertyName("timeout")]
    public long? Timeout { get; set; }

    /// <summary>
    /// Set Mode to Active to sample and trace a subset of incoming requests with
    /// X-Ray (https://docs.aws.amazon.com/lambda/latest/dg/services-xray.html).
    /// </summary>
    [JsonPropertyName("tracingConfig")]
    public V1alpha1FunctionSpecTracingConfig? TracingConfig { get; set; }

    /// <summary>
    /// For network connectivity to Amazon Web Services resources in a VPC, specify
    /// a list of security groups and subnets in the VPC. When you connect a function
    /// to a VPC, it can access resources and the internet only through that VPC.
    /// For more information, see Configuring a Lambda function to access resources
    /// in a VPC (https://docs.aws.amazon.com/lambda/latest/dg/configuration-vpc.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1FunctionSpecVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusAckResourceMetadata
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
public partial class V1alpha1FunctionStatusConditions
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

/// <summary>Error response to GetFunctionConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusImageConfigResponseError
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusImageConfigResponseImageConfig
{
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("entryPoint")]
    public IList<string>? EntryPoint { get; set; }

    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }
}

/// <summary>The function&apos;s image configuration values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusImageConfigResponse
{
    /// <summary>Error response to GetFunctionConfiguration.</summary>
    [JsonPropertyName("error")]
    public V1alpha1FunctionStatusImageConfigResponseError? Error { get; set; }

    /// <summary>
    /// Configuration values that override the container image Dockerfile settings.
    /// For more information, see Container image settings (https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms).
    /// </summary>
    [JsonPropertyName("imageConfig")]
    public V1alpha1FunctionStatusImageConfigResponseImageConfig? ImageConfig { get; set; }
}

/// <summary>An Lambda layer (https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusLayerStatuses
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

/// <summary>FunctionStatus defines the observed state of Function</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FunctionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The SHA256 hash of the function&apos;s deployment package.</summary>
    [JsonPropertyName("codeSHA256")]
    public string? CodeSHA256 { get; set; }

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
    public IList<V1alpha1FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>The function&apos;s image configuration values.</summary>
    [JsonPropertyName("imageConfigResponse")]
    public V1alpha1FunctionStatusImageConfigResponse? ImageConfigResponse { get; set; }

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
    [JsonPropertyName("layerStatuses")]
    public IList<V1alpha1FunctionStatusLayerStatuses>? LayerStatuses { get; set; }

    /// <summary>
    /// For Lambda@Edge functions, the ARN of the main function.
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z-]*)?:lambda:[a-z]{2}((-gov)|(-iso([a-z]?)))?-[a-z]+-\d{1}:\d{12}:function:[a-zA-Z0-9-_]+(:(\$LATEST|[a-zA-Z0-9-_]+))?$`
    /// </summary>
    [JsonPropertyName("masterARN")]
    public string? MasterARN { get; set; }

    /// <summary>The latest updated revision of the function or alias.</summary>
    [JsonPropertyName("revisionID")]
    public string? RevisionID { get; set; }

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
    /// The version of the Lambda function.
    /// 
    /// Regex Pattern: `^(\$LATEST|[0-9]+)$`
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Function is the Schema for the Functions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FunctionSpec?>, IStatus<V1alpha1FunctionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Function";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Function";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec defines the desired state of Function.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1FunctionSpec? Spec { get; set; }

    /// <summary>FunctionStatus defines the observed state of Function</summary>
    [JsonPropertyName("status")]
    public V1alpha1FunctionStatus? Status { get; set; }
}