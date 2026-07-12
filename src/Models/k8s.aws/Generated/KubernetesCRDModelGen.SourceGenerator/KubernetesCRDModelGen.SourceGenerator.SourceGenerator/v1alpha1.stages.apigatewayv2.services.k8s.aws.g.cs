#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.services.k8s.aws;
/// <summary>Stage is the Schema for the Stages API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StageList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Stage>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StageList";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "stages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Stage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Stage> Items { get; set; }
}

/// <summary>Settings for logging access in this stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecAccessLogSettings
{
    /// <summary>Represents an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("destinationARN")]
    public string? DestinationARN { get; set; }

    /// <summary>A string with a length between [1-1024].</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecApiRefFrom
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
public partial class V1alpha1StageSpecApiRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1StageSpecApiRefFrom? From { get; set; }
}

/// <summary>The default route settings for the stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecDefaultRouteSettings
{
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>The logging level.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    [JsonPropertyName("throttlingBurstLimit")]
    public long? ThrottlingBurstLimit { get; set; }

    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecDeploymentRefFrom
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
public partial class V1alpha1StageSpecDeploymentRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1StageSpecDeploymentRefFrom? From { get; set; }
}

/// <summary>Represents a collection of route settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecRouteSettings
{
    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    [JsonPropertyName("detailedMetricsEnabled")]
    public bool? DetailedMetricsEnabled { get; set; }

    /// <summary>The logging level.</summary>
    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    [JsonPropertyName("throttlingBurstLimit")]
    public long? ThrottlingBurstLimit { get; set; }

    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }
}

/// <summary>
/// StageSpec defines the desired state of Stage.
/// 
/// Represents an API stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpec
{
    /// <summary>Settings for logging access in this stage.</summary>
    [JsonPropertyName("accessLogSettings")]
    public V1alpha1StageSpecAccessLogSettings? AccessLogSettings { get; set; }

    /// <summary>The API identifier.</summary>
    [JsonPropertyName("apiID")]
    public string? ApiID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("apiRef")]
    public V1alpha1StageSpecApiRef? ApiRef { get; set; }

    /// <summary>
    /// Specifies whether updates to an API automatically trigger a new deployment.
    /// The default value is false.
    /// </summary>
    [JsonPropertyName("autoDeploy")]
    public bool? AutoDeploy { get; set; }

    /// <summary>
    /// The identifier of a client certificate for a Stage. Supported only for WebSocket
    /// APIs.
    /// </summary>
    [JsonPropertyName("clientCertificateID")]
    public string? ClientCertificateID { get; set; }

    /// <summary>The default route settings for the stage.</summary>
    [JsonPropertyName("defaultRouteSettings")]
    public V1alpha1StageSpecDefaultRouteSettings? DefaultRouteSettings { get; set; }

    /// <summary>The deployment identifier of the API stage.</summary>
    [JsonPropertyName("deploymentID")]
    public string? DeploymentID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("deploymentRef")]
    public V1alpha1StageSpecDeploymentRef? DeploymentRef { get; set; }

    /// <summary>The description for the API stage.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Route settings for the stage, by routeKey.</summary>
    [JsonPropertyName("routeSettings")]
    public IDictionary<string, V1alpha1StageSpecRouteSettings>? RouteSettings { get; set; }

    /// <summary>The name of the stage.</summary>
    [JsonPropertyName("stageName")]
    public required string StageName { get; set; }

    /// <summary>
    /// A map that defines the stage variables for a Stage. Variable names can have
    /// alphanumeric and underscore characters, and the values must match [A-Za-z0-9-._~:/?#&amp;=,]+.
    /// </summary>
    [JsonPropertyName("stageVariables")]
    public IDictionary<string, string>? StageVariables { get; set; }

    /// <summary>The collection of tags. Each tag element is associated with a given resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusAckResourceMetadata
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
public partial class V1alpha1StageStatusConditions
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

/// <summary>StageStatus defines the observed state of Stage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1StageStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// Specifies whether a stage is managed by API Gateway. If you created an API
    /// using quick create, the $default stage is managed by API Gateway. You can&apos;t
    /// modify the $default stage.
    /// </summary>
    [JsonPropertyName("apiGatewayManaged")]
    public bool? ApiGatewayManaged { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1StageStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp when the stage was created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Describes the status of the last deployment of a stage. Supported only for
    /// stages with autoDeploy enabled.
    /// </summary>
    [JsonPropertyName("lastDeploymentStatusMessage")]
    public string? LastDeploymentStatusMessage { get; set; }

    /// <summary>The timestamp when the stage was last updated.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public DateTime? LastUpdatedDate { get; set; }
}

/// <summary>Stage is the Schema for the Stages API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Stage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StageSpec?>, IStatus<V1alpha1StageStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Stage";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "stages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Stage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// StageSpec defines the desired state of Stage.
    /// 
    /// Represents an API stage.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1StageSpec? Spec { get; set; }

    /// <summary>StageStatus defines the observed state of Stage</summary>
    [JsonPropertyName("status")]
    public V1alpha1StageStatus? Status { get; set; }
}