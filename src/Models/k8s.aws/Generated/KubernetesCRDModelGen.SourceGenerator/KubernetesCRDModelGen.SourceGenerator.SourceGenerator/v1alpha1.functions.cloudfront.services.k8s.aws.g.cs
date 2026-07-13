#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.services.k8s.aws;
/// <summary>Function is the Schema for the Functions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Function>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

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
/// Configuration information about the function, including an optional comment
/// and the function&apos;s runtime.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpecFunctionConfig
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}

/// <summary>FunctionSpec defines the desired state of Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionSpec
{
    /// <summary>
    /// The function code. For more information about writing a CloudFront function,
    /// see Writing function code for CloudFront Functions (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/writing-function-code.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("functionCode")]
    public required byte[] FunctionCode { get; set; }

    /// <summary>
    /// Configuration information about the function, including an optional comment
    /// and the function&apos;s runtime.
    /// </summary>
    [JsonPropertyName("functionConfig")]
    public required V1alpha1FunctionSpecFunctionConfig FunctionConfig { get; set; }

    /// <summary>
    /// A name to identify the function.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9-_]{1,64}$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
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

/// <summary>Contains configuration information about a CloudFront function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusFunctionSummaryFunctionConfig
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}

/// <summary>Contains metadata about a CloudFront function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusFunctionSummaryFunctionMetadata
{
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    [JsonPropertyName("functionARN")]
    public string? FunctionARN { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>Contains configuration information and metadata about a CloudFront function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FunctionStatusFunctionSummary
{
    /// <summary>Contains configuration information about a CloudFront function.</summary>
    [JsonPropertyName("functionConfig")]
    public V1alpha1FunctionStatusFunctionSummaryFunctionConfig? FunctionConfig { get; set; }

    /// <summary>Contains metadata about a CloudFront function.</summary>
    [JsonPropertyName("functionMetadata")]
    public V1alpha1FunctionStatusFunctionSummaryFunctionMetadata? FunctionMetadata { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
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

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>The version identifier for the current version of the CloudFront function.</summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>Contains configuration information and metadata about a CloudFront function.</summary>
    [JsonPropertyName("functionSummary")]
    public V1alpha1FunctionStatusFunctionSummary? FunctionSummary { get; set; }

    /// <summary>The version identifier for the LIVE stage of the CloudFront function.</summary>
    [JsonPropertyName("liveETag")]
    public string? LiveETag { get; set; }

    /// <summary>
    /// The URL of the CloudFront function. Use the URL to manage the function with
    /// the CloudFront API.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>Function is the Schema for the Functions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FunctionSpec?>, IStatus<V1alpha1FunctionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Function";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

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