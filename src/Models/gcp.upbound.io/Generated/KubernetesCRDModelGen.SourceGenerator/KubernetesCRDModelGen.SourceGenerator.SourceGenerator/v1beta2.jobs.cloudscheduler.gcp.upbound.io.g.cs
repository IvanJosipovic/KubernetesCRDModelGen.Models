#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudscheduler.gcp.upbound.io;
/// <summary>Job is the Schema for the Jobs API. A scheduled job that can publish a PubSub message or an HTTP request every X interval of time, using a crontab format string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Job>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "cloudscheduler.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudscheduler.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Job> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecDeletionPolicyEnum>))]
public enum V1beta2JobSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// App Engine Routing setting for the job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderAppEngineHttpTargetAppEngineRouting
{
    /// <summary>
    /// App instance.
    /// By default, the job is sent to an instance which is available when the job is attempted.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// App service.
    /// By default, the job is sent to the service which is the default service when the job is attempted.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// App version.
    /// By default, the job is sent to the version which is the default version when the job is attempted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// App Engine HTTP target.
/// If the job providers a App Engine HTTP target the cron will
/// send a request to the service instance
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderAppEngineHttpTarget
{
    /// <summary>
    /// App Engine Routing setting for the job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineRouting")]
    public V1beta2JobSpecForProviderAppEngineHttpTargetAppEngineRouting? AppEngineRouting { get; set; }

    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Which HTTP method to use for the request.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &quot;/&quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and # fragments.
    /// If the relative URL is empty, then the root path &quot;/&quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [JsonPropertyName("relativeUri")]
    public string? RelativeUri { get; set; }
}

/// <summary>
/// Contains information needed for generating an OAuth token.
/// This type of authorization should be used when sending requests to a GCP endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderHttpTargetOauthToken
{
    /// <summary>
    /// OAuth scope to be used for generating OAuth access token. If not specified,
    /// &quot;https://www.googleapis.com/auth/cloud-platform&quot; will be used.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// Contains information needed for generating an OpenID Connect token.
/// This type of authorization should be used when sending requests to third party endpoints or Cloud Run.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderHttpTargetOidcToken
{
    /// <summary>
    /// Audience to be used when generating OIDC token. If not specified,
    /// the URI specified in target will be used.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// HTTP target.
/// If the job providers a http_target the cron will
/// send a request to the targeted url
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderHttpTarget
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Which HTTP method to use for the request.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Contains information needed for generating an OAuth token.
    /// This type of authorization should be used when sending requests to a GCP endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthToken")]
    public V1beta2JobSpecForProviderHttpTargetOauthToken? OauthToken { get; set; }

    /// <summary>
    /// Contains information needed for generating an OpenID Connect token.
    /// This type of authorization should be used when sending requests to third party endpoints or Cloud Run.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2JobSpecForProviderHttpTargetOidcToken? OidcToken { get; set; }

    /// <summary>The full URI path that the request will be sent to.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topicName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPubsubTargetTopicNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topicName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPubsubTargetTopicNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Pub/Sub target
/// If the job providers a Pub/Sub target the cron will publish
/// a message to the provided topic
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPubsubTarget
{
    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&gt;NOTE:
    /// The topic name must be in the same format as required by PubSub&apos;s
    /// PublishRequest.name, e.g. projects/my-project/topics/my-topic.
    /// </summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topicName.</summary>
    [JsonPropertyName("topicNameRef")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameRef? TopicNameRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topicName.</summary>
    [JsonPropertyName("topicNameSelector")]
    public V1beta2JobSpecForProviderPubsubTargetTopicNameSelector? TopicNameSelector { get; set; }
}

/// <summary>
/// By default, if a job does not complete successfully,
/// meaning that an acknowledgement is not received from the handler,
/// then it will be retried with exponential backoff according to the settings
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderRetryConfig
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("maxBackoffDuration")]
    public string? MaxBackoffDuration { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&apos;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("minBackoffDuration")]
    public string? MinBackoffDuration { get; set; }

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    [JsonPropertyName("retryCount")]
    public double? RetryCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProvider
{
    /// <summary>
    /// App Engine HTTP target.
    /// If the job providers a App Engine HTTP target the cron will
    /// send a request to the service instance
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineHttpTarget")]
    public V1beta2JobSpecForProviderAppEngineHttpTarget? AppEngineHttpTarget { get; set; }

    /// <summary>
    /// The deadline for job attempts. If the request handler does not respond by this deadline then the request is
    /// cancelled and the attempt is marked as a DEADLINE_EXCEEDED failure. The failed attempt can be viewed in
    /// execution logs. Cloud Scheduler will retry the job according to the RetryConfig.
    /// The allowed duration for this deadline is:
    /// </summary>
    [JsonPropertyName("attemptDeadline")]
    public string? AttemptDeadline { get; set; }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// HTTP target.
    /// If the job providers a http_target the cron will
    /// send a request to the targeted url
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpTarget")]
    public V1beta2JobSpecForProviderHttpTarget? HttpTarget { get; set; }

    /// <summary>Sets the job to a paused state. Jobs default to being enabled when this property is not set.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Pub/Sub target
    /// If the job providers a Pub/Sub target the cron will publish
    /// a message to the provided topic
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubTarget")]
    public V1beta2JobSpecForProviderPubsubTarget? PubsubTarget { get; set; }

    /// <summary>Region where the scheduler job resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// By default, if a job does not complete successfully,
    /// meaning that an acknowledgement is not received from the handler,
    /// then it will be retried with exponential backoff according to the settings
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryConfig")]
    public V1beta2JobSpecForProviderRetryConfig? RetryConfig { get; set; }

    /// <summary>Describes the schedule on which the job will be executed.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// App Engine Routing setting for the job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderAppEngineHttpTargetAppEngineRouting
{
    /// <summary>
    /// App instance.
    /// By default, the job is sent to an instance which is available when the job is attempted.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// App service.
    /// By default, the job is sent to the service which is the default service when the job is attempted.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// App version.
    /// By default, the job is sent to the version which is the default version when the job is attempted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// App Engine HTTP target.
/// If the job providers a App Engine HTTP target the cron will
/// send a request to the service instance
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderAppEngineHttpTarget
{
    /// <summary>
    /// App Engine Routing setting for the job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineRouting")]
    public V1beta2JobSpecInitProviderAppEngineHttpTargetAppEngineRouting? AppEngineRouting { get; set; }

    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Which HTTP method to use for the request.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &quot;/&quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and # fragments.
    /// If the relative URL is empty, then the root path &quot;/&quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [JsonPropertyName("relativeUri")]
    public string? RelativeUri { get; set; }
}

/// <summary>
/// Contains information needed for generating an OAuth token.
/// This type of authorization should be used when sending requests to a GCP endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderHttpTargetOauthToken
{
    /// <summary>
    /// OAuth scope to be used for generating OAuth access token. If not specified,
    /// &quot;https://www.googleapis.com/auth/cloud-platform&quot; will be used.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// Contains information needed for generating an OpenID Connect token.
/// This type of authorization should be used when sending requests to third party endpoints or Cloud Run.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderHttpTargetOidcToken
{
    /// <summary>
    /// Audience to be used when generating OIDC token. If not specified,
    /// the URI specified in target will be used.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// HTTP target.
/// If the job providers a http_target the cron will
/// send a request to the targeted url
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderHttpTarget
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Which HTTP method to use for the request.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Contains information needed for generating an OAuth token.
    /// This type of authorization should be used when sending requests to a GCP endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthToken")]
    public V1beta2JobSpecInitProviderHttpTargetOauthToken? OauthToken { get; set; }

    /// <summary>
    /// Contains information needed for generating an OpenID Connect token.
    /// This type of authorization should be used when sending requests to third party endpoints or Cloud Run.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2JobSpecInitProviderHttpTargetOidcToken? OidcToken { get; set; }

    /// <summary>The full URI path that the request will be sent to.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topicName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPubsubTargetTopicNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topicName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPubsubTargetTopicNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Pub/Sub target
/// If the job providers a Pub/Sub target the cron will publish
/// a message to the provided topic
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPubsubTarget
{
    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&gt;NOTE:
    /// The topic name must be in the same format as required by PubSub&apos;s
    /// PublishRequest.name, e.g. projects/my-project/topics/my-topic.
    /// </summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topicName.</summary>
    [JsonPropertyName("topicNameRef")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameRef? TopicNameRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topicName.</summary>
    [JsonPropertyName("topicNameSelector")]
    public V1beta2JobSpecInitProviderPubsubTargetTopicNameSelector? TopicNameSelector { get; set; }
}

/// <summary>
/// By default, if a job does not complete successfully,
/// meaning that an acknowledgement is not received from the handler,
/// then it will be retried with exponential backoff according to the settings
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderRetryConfig
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("maxBackoffDuration")]
    public string? MaxBackoffDuration { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&apos;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("minBackoffDuration")]
    public string? MinBackoffDuration { get; set; }

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    [JsonPropertyName("retryCount")]
    public double? RetryCount { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProvider
{
    /// <summary>
    /// App Engine HTTP target.
    /// If the job providers a App Engine HTTP target the cron will
    /// send a request to the service instance
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineHttpTarget")]
    public V1beta2JobSpecInitProviderAppEngineHttpTarget? AppEngineHttpTarget { get; set; }

    /// <summary>
    /// The deadline for job attempts. If the request handler does not respond by this deadline then the request is
    /// cancelled and the attempt is marked as a DEADLINE_EXCEEDED failure. The failed attempt can be viewed in
    /// execution logs. Cloud Scheduler will retry the job according to the RetryConfig.
    /// The allowed duration for this deadline is:
    /// </summary>
    [JsonPropertyName("attemptDeadline")]
    public string? AttemptDeadline { get; set; }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// HTTP target.
    /// If the job providers a http_target the cron will
    /// send a request to the targeted url
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpTarget")]
    public V1beta2JobSpecInitProviderHttpTarget? HttpTarget { get; set; }

    /// <summary>Sets the job to a paused state. Jobs default to being enabled when this property is not set.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Pub/Sub target
    /// If the job providers a Pub/Sub target the cron will publish
    /// a message to the provided topic
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubTarget")]
    public V1beta2JobSpecInitProviderPubsubTarget? PubsubTarget { get; set; }

    /// <summary>
    /// By default, if a job does not complete successfully,
    /// meaning that an acknowledgement is not received from the handler,
    /// then it will be retried with exponential backoff according to the settings
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryConfig")]
    public V1beta2JobSpecInitProviderRetryConfig? RetryConfig { get; set; }

    /// <summary>Describes the schedule on which the job will be executed.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecManagementPoliciesEnum>))]
public enum V1beta2JobSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2JobSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2JobSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2JobSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// App Engine Routing setting for the job.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderAppEngineHttpTargetAppEngineRouting
{
    /// <summary>
    /// App instance.
    /// By default, the job is sent to an instance which is available when the job is attempted.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// App service.
    /// By default, the job is sent to the service which is the default service when the job is attempted.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// App version.
    /// By default, the job is sent to the version which is the default version when the job is attempted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// App Engine HTTP target.
/// If the job providers a App Engine HTTP target the cron will
/// send a request to the service instance
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderAppEngineHttpTarget
{
    /// <summary>
    /// App Engine Routing setting for the job.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineRouting")]
    public V1beta2JobStatusAtProviderAppEngineHttpTargetAppEngineRouting? AppEngineRouting { get; set; }

    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Which HTTP method to use for the request.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &quot;/&quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and # fragments.
    /// If the relative URL is empty, then the root path &quot;/&quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [JsonPropertyName("relativeUri")]
    public string? RelativeUri { get; set; }
}

/// <summary>
/// Contains information needed for generating an OAuth token.
/// This type of authorization should be used when sending requests to a GCP endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderHttpTargetOauthToken
{
    /// <summary>
    /// OAuth scope to be used for generating OAuth access token. If not specified,
    /// &quot;https://www.googleapis.com/auth/cloud-platform&quot; will be used.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// Contains information needed for generating an OpenID Connect token.
/// This type of authorization should be used when sending requests to third party endpoints or Cloud Run.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderHttpTargetOidcToken
{
    /// <summary>
    /// Audience to be used when generating OIDC token. If not specified,
    /// the URI specified in target will be used.
    /// </summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// HTTP target.
/// If the job providers a http_target the cron will
/// send a request to the targeted url
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderHttpTarget
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Which HTTP method to use for the request.</summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// Contains information needed for generating an OAuth token.
    /// This type of authorization should be used when sending requests to a GCP endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthToken")]
    public V1beta2JobStatusAtProviderHttpTargetOauthToken? OauthToken { get; set; }

    /// <summary>
    /// Contains information needed for generating an OpenID Connect token.
    /// This type of authorization should be used when sending requests to third party endpoints or Cloud Run.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2JobStatusAtProviderHttpTargetOidcToken? OidcToken { get; set; }

    /// <summary>The full URI path that the request will be sent to.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Pub/Sub target
/// If the job providers a Pub/Sub target the cron will publish
/// a message to the provided topic
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPubsubTarget
{
    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&gt;NOTE:
    /// The topic name must be in the same format as required by PubSub&apos;s
    /// PublishRequest.name, e.g. projects/my-project/topics/my-topic.
    /// </summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

/// <summary>
/// By default, if a job does not complete successfully,
/// meaning that an acknowledgement is not received from the handler,
/// then it will be retried with exponential backoff according to the settings
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderRetryConfig
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("maxBackoffDuration")]
    public string? MaxBackoffDuration { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&apos;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// </summary>
    [JsonPropertyName("minBackoffDuration")]
    public string? MinBackoffDuration { get; set; }

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    [JsonPropertyName("retryCount")]
    public double? RetryCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProvider
{
    /// <summary>
    /// App Engine HTTP target.
    /// If the job providers a App Engine HTTP target the cron will
    /// send a request to the service instance
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineHttpTarget")]
    public V1beta2JobStatusAtProviderAppEngineHttpTarget? AppEngineHttpTarget { get; set; }

    /// <summary>
    /// The deadline for job attempts. If the request handler does not respond by this deadline then the request is
    /// cancelled and the attempt is marked as a DEADLINE_EXCEEDED failure. The failed attempt can be viewed in
    /// execution logs. Cloud Scheduler will retry the job according to the RetryConfig.
    /// The allowed duration for this deadline is:
    /// </summary>
    [JsonPropertyName("attemptDeadline")]
    public string? AttemptDeadline { get; set; }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// HTTP target.
    /// If the job providers a http_target the cron will
    /// send a request to the targeted url
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpTarget")]
    public V1beta2JobStatusAtProviderHttpTarget? HttpTarget { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/jobs/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Sets the job to a paused state. Jobs default to being enabled when this property is not set.</summary>
    [JsonPropertyName("paused")]
    public bool? Paused { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Pub/Sub target
    /// If the job providers a Pub/Sub target the cron will publish
    /// a message to the provided topic
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pubsubTarget")]
    public V1beta2JobStatusAtProviderPubsubTarget? PubsubTarget { get; set; }

    /// <summary>Region where the scheduler job resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// By default, if a job does not complete successfully,
    /// meaning that an acknowledgement is not received from the handler,
    /// then it will be retried with exponential backoff according to the settings
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryConfig")]
    public V1beta2JobStatusAtProviderRetryConfig? RetryConfig { get; set; }

    /// <summary>Describes the schedule on which the job will be executed.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>State of the job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2JobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API. A scheduled job that can publish a PubSub message or an HTTP request every X interval of time, using a crontab format string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2JobSpec>, IStatus<V1beta2JobStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Job";
    public const string KubeGroup = "cloudscheduler.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudscheduler.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public required V1beta2JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta2JobStatus? Status { get; set; }
}