#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sfn.services.k8s.aws;
/// <summary>StateMachine is the Schema for the StateMachines API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StateMachineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1StateMachine>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StateMachineList";
    public const string KubeGroup = "sfn.services.k8s.aws";
    public const string KubePluralName = "statemachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sfn.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StateMachineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1StateMachine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1StateMachine> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpecLoggingConfigurationDestinationsCloudWatchLogsLogGroup
{
    [JsonPropertyName("logGroupARN")]
    public string? LogGroupARN { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpecLoggingConfigurationDestinations
{
    [JsonPropertyName("cloudWatchLogsLogGroup")]
    public V1alpha1StateMachineSpecLoggingConfigurationDestinationsCloudWatchLogsLogGroup? CloudWatchLogsLogGroup { get; set; }
}

/// <summary>
/// Defines what execution history events are logged and where they are logged.
/// 
/// By default, the level is set to OFF. For more information see Log Levels
/// (https://docs.aws.amazon.com/step-functions/latest/dg/cloudwatch-log-level.html)
/// in the Step Functions User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpecLoggingConfiguration
{
    [JsonPropertyName("destinations")]
    public IList<V1alpha1StateMachineSpecLoggingConfigurationDestinations>? Destinations { get; set; }

    [JsonPropertyName("includeExecutionData")]
    public bool? IncludeExecutionData { get; set; }

    [JsonPropertyName("level")]
    public string? Level { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpecRoleRefFrom
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
public partial class V1alpha1StateMachineSpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1StateMachineSpecRoleRefFrom? From { get; set; }
}

/// <summary>
/// Tags are key-value pairs that can be associated with Step Functions state
/// machines and activities.
/// 
/// An array of key-value pairs. For more information, see Using Cost Allocation
/// Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html)
/// in the Amazon Web Services Billing and Cost Management User Guide, and Controlling
/// Access Using IAM Tags (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html).
/// 
/// Tags may only contain Unicode letters, digits, white space, or these symbols:
/// _ . : / = + - @.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Selects whether X-Ray tracing is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpecTracingConfiguration
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StateMachineSpec defines the desired state of StateMachine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineSpec
{
    /// <summary>
    /// The Amazon States Language definition of the state machine. See Amazon States
    /// Language (https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html).
    /// </summary>
    [JsonPropertyName("definition")]
    public required string Definition { get; set; }

    /// <summary>
    /// Defines what execution history events are logged and where they are logged.
    /// 
    /// By default, the level is set to OFF. For more information see Log Levels
    /// (https://docs.aws.amazon.com/step-functions/latest/dg/cloudwatch-log-level.html)
    /// in the Step Functions User Guide.
    /// </summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1alpha1StateMachineSpecLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>
    /// The name of the state machine.
    /// 
    /// A name must not contain:
    /// 
    ///   - white space
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role to use for this state machine.</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

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
    public V1alpha1StateMachineSpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// Tags to be added when creating a state machine.
    /// 
    /// An array of key-value pairs. For more information, see Using Cost Allocation
    /// Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html)
    /// in the Amazon Web Services Billing and Cost Management User Guide, and Controlling
    /// Access Using IAM Tags (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html).
    /// 
    /// Tags may only contain Unicode letters, digits, white space, or these symbols:
    /// _ . : / = + - @.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1StateMachineSpecTags>? Tags { get; set; }

    /// <summary>Selects whether X-Ray tracing is enabled.</summary>
    [JsonPropertyName("tracingConfiguration")]
    public V1alpha1StateMachineSpecTracingConfiguration? TracingConfiguration { get; set; }

    /// <summary>
    /// Determines whether a Standard or Express state machine is created. The default
    /// is STANDARD. You cannot update the type of a state machine once it has been
    /// created.
    /// </summary>
    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineStatusAckResourceMetadata
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
public partial class V1alpha1StateMachineStatusConditions
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

/// <summary>StateMachineStatus defines the observed state of StateMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StateMachineStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1StateMachineStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1StateMachineStatusConditions>? Conditions { get; set; }

    /// <summary>The date the state machine is created.</summary>
    [JsonPropertyName("creationDate")]
    public DateTime? CreationDate { get; set; }
}

/// <summary>StateMachine is the Schema for the StateMachines API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StateMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StateMachineSpec?>, IStatus<V1alpha1StateMachineStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StateMachine";
    public const string KubeGroup = "sfn.services.k8s.aws";
    public const string KubePluralName = "statemachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sfn.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StateMachine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StateMachineSpec defines the desired state of StateMachine.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1StateMachineSpec? Spec { get; set; }

    /// <summary>StateMachineStatus defines the observed state of StateMachine</summary>
    [JsonPropertyName("status")]
    public V1alpha1StateMachineStatus? Status { get; set; }
}