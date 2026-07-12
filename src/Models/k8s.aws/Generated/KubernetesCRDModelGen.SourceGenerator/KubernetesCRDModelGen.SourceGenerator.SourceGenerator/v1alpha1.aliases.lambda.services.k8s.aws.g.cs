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
/// <summary>Alias is the Schema for the Aliases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AliasList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Alias>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AliasList";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "aliases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AliasList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Alias objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Alias> Items { get; set; }
}

/// <summary>
/// A destination for events that failed processing. For more information, see
/// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasSpecFunctionEventInvokeConfigDestinationConfigOnFailure
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
public partial class V1alpha1AliasSpecFunctionEventInvokeConfigDestinationConfigOnSuccess
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
public partial class V1alpha1AliasSpecFunctionEventInvokeConfigDestinationConfig
{
    /// <summary>
    /// A destination for events that failed processing. For more information, see
    /// Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("onFailure")]
    public V1alpha1AliasSpecFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure { get; set; }

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
    public V1alpha1AliasSpecFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess { get; set; }
}

/// <summary>
/// Configures options for asynchronous invocation on an alias.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasSpecFunctionEventInvokeConfig
{
    /// <summary>
    /// A configuration object that specifies the destination of an event after Lambda
    /// processes it. For more information, see Adding a destination (https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations).
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1alpha1AliasSpecFunctionEventInvokeConfigDestinationConfig? DestinationConfig { get; set; }

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
public partial class V1alpha1AliasSpecFunctionRefFrom
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
public partial class V1alpha1AliasSpecFunctionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AliasSpecFunctionRefFrom? From { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasSpecPermissions
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("eventSourceToken")]
    public string? EventSourceToken { get; set; }

    [JsonPropertyName("functionURLAuthType")]
    public string? FunctionURLAuthType { get; set; }

    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    [JsonPropertyName("principalOrgID")]
    public string? PrincipalOrgID { get; set; }

    [JsonPropertyName("revisionID")]
    public string? RevisionID { get; set; }

    [JsonPropertyName("sourceARN")]
    public string? SourceARN { get; set; }

    [JsonPropertyName("sourceAccount")]
    public string? SourceAccount { get; set; }

    [JsonPropertyName("statementID")]
    public string? StatementID { get; set; }
}

/// <summary>
/// Configures provisioned concurrency to a function&apos;s alias
/// 
/// - ProvisionedConcurrentExecutions
/// The amount of provisioned concurrency to allocate for the version or alias.
/// Minimum value of 1 is required
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasSpecProvisionedConcurrencyConfig
{
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    [JsonPropertyName("provisionedConcurrentExecutions")]
    public long? ProvisionedConcurrentExecutions { get; set; }

    [JsonPropertyName("qualifier")]
    public string? Qualifier { get; set; }
}

/// <summary>
/// The routing configuration (https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html#configuring-alias-routing)
/// of the alias.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasSpecRoutingConfig
{
    [JsonPropertyName("additionalVersionWeights")]
    public IDictionary<string, double>? AdditionalVersionWeights { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasSpec
{
    /// <summary>A description of the alias.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Configures options for asynchronous invocation on an alias.
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
    public V1alpha1AliasSpecFunctionEventInvokeConfig? FunctionEventInvokeConfig { get; set; }

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
    public V1alpha1AliasSpecFunctionRef? FunctionRef { get; set; }

    /// <summary>
    /// The function version that the alias invokes.
    /// 
    /// Regex Pattern: `^(\$LATEST(\.PUBLISHED)?|[0-9]+)$`
    /// </summary>
    [JsonPropertyName("functionVersion")]
    public required string FunctionVersion { get; set; }

    /// <summary>
    /// The name of the alias.
    /// 
    /// Regex Pattern: `^(?!^[0-9]+$)([a-zA-Z0-9-_]+)$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Permissions configures a set of Lambda permissions to grant to an alias.</summary>
    [JsonPropertyName("permissions")]
    public IList<V1alpha1AliasSpecPermissions>? Permissions { get; set; }

    /// <summary>
    /// Configures provisioned concurrency to a function&apos;s alias
    /// 
    /// - ProvisionedConcurrentExecutions
    /// The amount of provisioned concurrency to allocate for the version or alias.
    /// Minimum value of 1 is required
    /// </summary>
    [JsonPropertyName("provisionedConcurrencyConfig")]
    public V1alpha1AliasSpecProvisionedConcurrencyConfig? ProvisionedConcurrencyConfig { get; set; }

    /// <summary>
    /// The routing configuration (https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html#configuring-alias-routing)
    /// of the alias.
    /// </summary>
    [JsonPropertyName("routingConfig")]
    public V1alpha1AliasSpecRoutingConfig? RoutingConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasStatusAckResourceMetadata
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
public partial class V1alpha1AliasStatusConditions
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

/// <summary>AliasStatus defines the observed state of Alias</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AliasStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AliasStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AliasStatusConditions>? Conditions { get; set; }

    /// <summary>A unique identifier that changes when you update the alias.</summary>
    [JsonPropertyName("revisionID")]
    public string? RevisionID { get; set; }
}

/// <summary>Alias is the Schema for the Aliases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Alias : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AliasSpec?>, IStatus<V1alpha1AliasStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Alias";
    public const string KubeGroup = "lambda.services.k8s.aws";
    public const string KubePluralName = "aliases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lambda.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Alias";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1AliasSpec? Spec { get; set; }

    /// <summary>AliasStatus defines the observed state of Alias</summary>
    [JsonPropertyName("status")]
    public V1alpha1AliasStatus? Status { get; set; }
}