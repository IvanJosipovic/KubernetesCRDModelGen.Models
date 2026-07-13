#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigateway.services.k8s.aws;
/// <summary>Deployment is the Schema for the Deployments API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Deployment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeploymentList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "deployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Deployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Deployment> Items { get; set; }
}

/// <summary>
/// The input configuration for the canary deployment when the deployment is
/// a canary release deployment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentSpecCanarySettings
{
    [JsonPropertyName("percentTraffic")]
    public double? PercentTraffic { get; set; }

    [JsonPropertyName("stageVariableOverrides")]
    public IDictionary<string, string>? StageVariableOverrides { get; set; }

    [JsonPropertyName("useStageCache")]
    public bool? UseStageCache { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentSpecRestAPIRefFrom
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
public partial class V1alpha1DeploymentSpecRestAPIRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DeploymentSpecRestAPIRefFrom? From { get; set; }
}

/// <summary>
/// DeploymentSpec defines the desired state of Deployment.
/// 
/// An immutable representation of a RestApi resource that can be called by users
/// using Stages. A deployment must be associated with a Stage for it to be callable
/// over the Internet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentSpec
{
    /// <summary>Enables a cache cluster for the Stage resource specified in the input.</summary>
    [JsonPropertyName("cacheClusterEnabled")]
    public bool? CacheClusterEnabled { get; set; }

    /// <summary>
    /// The stage&apos;s cache capacity in GB. For more information about choosing a cache
    /// size, see Enabling API caching to enhance responsiveness (https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-caching.html).
    /// </summary>
    [JsonPropertyName("cacheClusterSize")]
    public string? CacheClusterSize { get; set; }

    /// <summary>
    /// The input configuration for the canary deployment when the deployment is
    /// a canary release deployment.
    /// </summary>
    [JsonPropertyName("canarySettings")]
    public V1alpha1DeploymentSpecCanarySettings? CanarySettings { get; set; }

    /// <summary>The description for the Deployment resource to create.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The string identifier of the associated RestApi.</summary>
    [JsonPropertyName("restAPIID")]
    public string? RestAPIID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("restAPIRef")]
    public V1alpha1DeploymentSpecRestAPIRef? RestAPIRef { get; set; }

    /// <summary>The description of the Stage resource for the Deployment resource to create.</summary>
    [JsonPropertyName("stageDescription")]
    public string? StageDescription { get; set; }

    /// <summary>The name of the Stage resource for the Deployment resource to create.</summary>
    [JsonPropertyName("stageName")]
    public string? StageName { get; set; }

    /// <summary>Specifies whether active tracing with X-ray is enabled for the Stage.</summary>
    [JsonPropertyName("tracingEnabled")]
    public bool? TracingEnabled { get; set; }

    /// <summary>
    /// A map that defines the stage variables for the Stage resource that is associated
    /// with the new deployment. Variable names can have alphanumeric and underscore
    /// characters, and the values must match [A-Za-z0-9-._~:/?#&amp;=,]+.
    /// </summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentStatusAckResourceMetadata
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

/// <summary>Represents a summary of a Method resource, given a particular date and time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentStatusApiSummary
{
    [JsonPropertyName("apiKeyRequired")]
    public bool? ApiKeyRequired { get; set; }

    [JsonPropertyName("authorizationType")]
    public string? AuthorizationType { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentStatusConditions
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

/// <summary>DeploymentStatus defines the observed state of Deployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeploymentStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DeploymentStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// A summary of the RestApi at the date and time that the deployment resource
    /// was created.
    /// </summary>
    [JsonPropertyName("apiSummary")]
    public IDictionary<string, IDictionary<string, V1alpha1DeploymentStatusApiSummary>>? ApiSummary { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time that the deployment resource was created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>The identifier for the deployment resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Deployment is the Schema for the Deployments API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Deployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DeploymentSpec?>, IStatus<V1alpha1DeploymentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Deployment";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "deployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Deployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DeploymentSpec defines the desired state of Deployment.
    /// 
    /// An immutable representation of a RestApi resource that can be called by users
    /// using Stages. A deployment must be associated with a Stage for it to be callable
    /// over the Internet.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DeploymentSpec? Spec { get; set; }

    /// <summary>DeploymentStatus defines the observed state of Deployment</summary>
    [JsonPropertyName("status")]
    public V1alpha1DeploymentStatus? Status { get; set; }
}