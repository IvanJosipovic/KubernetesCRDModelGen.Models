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
/// <summary>Stage is the Schema for the Stages API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1StageList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Stage>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "StageList";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "stages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

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

/// <summary>The canary deployment settings of this stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecCanarySettings
{
    [JsonPropertyName("deploymentID")]
    public string? DeploymentID { get; set; }

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

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpecRestAPIRefFrom
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
public partial class V1alpha1StageSpecRestAPIRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1StageSpecRestAPIRefFrom? From { get; set; }
}

/// <summary>
/// StageSpec defines the desired state of Stage.
/// 
/// Represents a unique identifier for a version of a deployed RestApi that is
/// callable by users.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageSpec
{
    /// <summary>Whether cache clustering is enabled for the stage.</summary>
    [JsonPropertyName("cacheClusterEnabled")]
    public bool? CacheClusterEnabled { get; set; }

    /// <summary>
    /// The stage&apos;s cache capacity in GB. For more information about choosing a cache
    /// size, see Enabling API caching to enhance responsiveness (https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-caching.html).
    /// </summary>
    [JsonPropertyName("cacheClusterSize")]
    public string? CacheClusterSize { get; set; }

    /// <summary>The canary deployment settings of this stage.</summary>
    [JsonPropertyName("canarySettings")]
    public V1alpha1StageSpecCanarySettings? CanarySettings { get; set; }

    /// <summary>The identifier of the Deployment resource for the Stage resource.</summary>
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

    /// <summary>The description of the Stage resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The version of the associated API documentation.</summary>
    [JsonPropertyName("documentationVersion")]
    public string? DocumentationVersion { get; set; }

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
    public V1alpha1StageSpecRestAPIRef? RestAPIRef { get; set; }

    /// <summary>
    /// The name for the Stage resource. Stage names can only contain alphanumeric
    /// characters, hyphens, and underscores. Maximum length is 128 characters.
    /// </summary>
    [JsonPropertyName("stageName")]
    public required string StageName { get; set; }

    /// <summary>
    /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/].
    /// The tag key can be up to 128 characters and must not start with aws:. The
    /// tag value can be up to 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies whether active tracing with X-ray is enabled for the Stage.</summary>
    [JsonPropertyName("tracingEnabled")]
    public bool? TracingEnabled { get; set; }

    /// <summary>
    /// A map that defines the stage variables for the new Stage resource. Variable
    /// names can have alphanumeric and underscore characters, and the values must
    /// match [A-Za-z0-9-._~:/?#&amp;=,]+.
    /// </summary>
    [JsonPropertyName("variables")]
    public IDictionary<string, string>? Variables { get; set; }
}

/// <summary>Settings for logging access in this stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusAccessLogSettings
{
    [JsonPropertyName("destinationARN")]
    public string? DestinationARN { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }
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

/// <summary>Specifies the method setting properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatusMethodSettings
{
    [JsonPropertyName("cacheDataEncrypted")]
    public bool? CacheDataEncrypted { get; set; }

    [JsonPropertyName("cacheTTLInSeconds")]
    public long? CacheTTLInSeconds { get; set; }

    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    [JsonPropertyName("dataTraceEnabled")]
    public bool? DataTraceEnabled { get; set; }

    [JsonPropertyName("loggingLevel")]
    public string? LoggingLevel { get; set; }

    [JsonPropertyName("metricsEnabled")]
    public bool? MetricsEnabled { get; set; }

    [JsonPropertyName("requireAuthorizationForCacheControl")]
    public bool? RequireAuthorizationForCacheControl { get; set; }

    [JsonPropertyName("throttlingBurstLimit")]
    public long? ThrottlingBurstLimit { get; set; }

    [JsonPropertyName("throttlingRateLimit")]
    public double? ThrottlingRateLimit { get; set; }

    [JsonPropertyName("unauthorizedCacheControlHeaderStrategy")]
    public string? UnauthorizedCacheControlHeaderStrategy { get; set; }
}

/// <summary>StageStatus defines the observed state of Stage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1StageStatus
{
    /// <summary>Settings for logging access in this stage.</summary>
    [JsonPropertyName("accessLogSettings")]
    public V1alpha1StageStatusAccessLogSettings? AccessLogSettings { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1StageStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The status of the cache cluster for the stage, if enabled.</summary>
    [JsonPropertyName("cacheClusterStatus")]
    public string? CacheClusterStatus { get; set; }

    /// <summary>The identifier of a client certificate for an API stage.</summary>
    [JsonPropertyName("clientCertificateID")]
    public string? ClientCertificateID { get; set; }

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

    /// <summary>The timestamp when the stage last updated.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public DateTime? LastUpdatedDate { get; set; }

    /// <summary>
    /// A map that defines the method settings for a Stage resource. Keys (designated
    /// as /{method_setting_key below) are method paths defined as {resource_path}/{http_method}
    /// for an individual method override, or /\*/\* for overriding all methods in
    /// the stage.
    /// </summary>
    [JsonPropertyName("methodSettings")]
    public IDictionary<string, V1alpha1StageStatusMethodSettings>? MethodSettings { get; set; }

    /// <summary>The ARN of the WebAcl associated with the Stage.</summary>
    [JsonPropertyName("webACLARN")]
    public string? WebACLARN { get; set; }
}

/// <summary>Stage is the Schema for the Stages API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Stage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1StageSpec?>, IStatus<V1alpha1StageStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Stage";
    public const string KubeGroup = "apigateway.services.k8s.aws";
    public const string KubePluralName = "stages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigateway.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Stage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// StageSpec defines the desired state of Stage.
    /// 
    /// Represents a unique identifier for a version of a deployed RestApi that is
    /// callable by users.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1StageSpec? Spec { get; set; }

    /// <summary>StageStatus defines the observed state of Stage</summary>
    [JsonPropertyName("status")]
    public V1alpha1StageStatus? Status { get; set; }
}