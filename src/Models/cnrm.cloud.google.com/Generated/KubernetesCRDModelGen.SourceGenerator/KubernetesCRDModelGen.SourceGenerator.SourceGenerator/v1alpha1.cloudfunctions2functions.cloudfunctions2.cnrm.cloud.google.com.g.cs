#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfunctions2.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudFunctions2FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudFunctions2Function>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudFunctions2FunctionList";
    public const string KubeGroup = "cloudfunctions2.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudfunctions2functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfunctions2.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudFunctions2FunctionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudFunctions2Function objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudFunctions2Function> Items { get; set; }
}

/// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecBuildConfigSourceRepoSource
{
    /// <summary>Regex matching branches to build.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Only trigger a build if the revision regex does
    /// NOT match the revision regex.
    /// </summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>
    /// Immutable. ID of the project that owns the Cloud Source Repository. If omitted, the
    /// project ID requesting the build is assumed.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>If provided, get the source from this location in Google Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecBuildConfigSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object. If the generation
    /// is omitted, the latest generation will be used.
    /// </summary>
    [JsonPropertyName("generation")]
    public int? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>The location of the function source code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecBuildConfigSource
{
    /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
    [JsonPropertyName("repoSource")]
    public V1alpha1CloudFunctions2FunctionSpecBuildConfigSourceRepoSource? RepoSource { get; set; }

    /// <summary>If provided, get the source from this location in Google Cloud Storage.</summary>
    [JsonPropertyName("storageSource")]
    public V1alpha1CloudFunctions2FunctionSpecBuildConfigSourceStorageSource? StorageSource { get; set; }
}

/// <summary>
/// Describes the Build step of the function that builds a container
/// from the given source.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecBuildConfig
{
    /// <summary>
    /// The Cloud Build name of the latest successful
    /// deployment of the function.
    /// </summary>
    [JsonPropertyName("build")]
    public string? Build { get; set; }

    /// <summary>User managed repository created in Artifact Registry optionally with a customer managed encryption key.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &quot;function&quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>User-provided build-time environment variables for the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The location of the function source code.</summary>
    [JsonPropertyName("source")]
    public V1alpha1CloudFunctions2FunctionSpecBuildConfigSource? Source { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecEventTriggerEventFilters
{
    /// <summary>
    /// &apos;Required. The name of a CloudEvents attribute.
    /// Currently, only a subset of attributes are supported for filtering. Use the &apos;gcloud eventarc providers describe&apos; command to learn more about events and their attributes.
    /// Do not filter for the &apos;type&apos; attribute here, as this is already achieved by the resource&apos;s &apos;event_type&apos; attribute.
    /// </summary>
    [JsonPropertyName("attribute")]
    public required string Attribute { get; set; }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of
    /// the filter. If not specified, only events that have an exact key-value
    /// pair specified in the filter are matched.
    /// The only allowed value is &apos;match-path-pattern&apos;.
    /// [See documentation on path patterns here](https://cloud.google.com/eventarc/docs/path-patterns)&apos;.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Required. The value for the attribute.
    /// If the operator field is set as &apos;match-path-pattern&apos;, this value can be a path pattern instead of an exact value.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// An Eventarc trigger managed by Google Cloud Functions that fires events in
/// response to a condition in another service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecEventTrigger
{
    /// <summary>Criteria used to filter events.</summary>
    [JsonPropertyName("eventFilters")]
    public IList<V1alpha1CloudFunctions2FunctionSpecEventTriggerEventFilters>? EventFilters { get; set; }

    /// <summary>Required. The type of event to observe.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }

    /// <summary>
    /// Describes the retry policy in case of function&apos;s execution failure.
    /// Retried execution is charged as any other execution. Possible values: [&quot;RETRY_POLICY_UNSPECIFIED&quot;, &quot;RETRY_POLICY_DO_NOT_RETRY&quot;, &quot;RETRY_POLICY_RETRY&quot;].
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public string? RetryPolicy { get; set; }

    /// <summary>The email of the service account for this function.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Output only. The resource name of the Eventarc trigger.</summary>
    [JsonPropertyName("trigger")]
    public string? Trigger { get; set; }

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    [JsonPropertyName("triggerRegion")]
    public string? TriggerRegion { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecServiceConfigSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Project identifier (preferrably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public required string Secret { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is recommended to use a numeric version for secret environment variables as any updates to the secret value is not reflected until new instances start.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecServiceConfigSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mountPath as &apos;/etc/secrets&apos; and path as secret_foo would mount the secret value file at /etc/secrets/secret_foo.</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecServiceConfigSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mountPath as /etc/secrets would mount the secret value files under the /etc/secrets directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount path: /etc/secrets.</summary>
    [JsonPropertyName("mountPath")]
    public required string MountPath { get; set; }

    /// <summary>Project identifier (preferrably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public required string Secret { get; set; }

    /// <summary>List of secret versions to mount for this secret. If empty, the latest version of the secret will be made available in a file named after the secret under the mount point.&apos;.</summary>
    [JsonPropertyName("versions")]
    public IList<V1alpha1CloudFunctions2FunctionSpecServiceConfigSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>Describes the Service being deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpecServiceConfig
{
    /// <summary>Whether 100% of traffic is routed to the latest revision. Defaults to true.</summary>
    [JsonPropertyName("allTrafficOnLatestRevision")]
    public bool? AllTrafficOnLatestRevision { get; set; }

    /// <summary>The number of CPUs used in a single container instance. Default value is calculated from available memory.</summary>
    [JsonPropertyName("availableCpu")]
    public string? AvailableCpu { get; set; }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    [JsonPropertyName("availableMemory")]
    public string? AvailableMemory { get; set; }

    /// <summary>Environment variables that shall be available during function execution.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>URIs of the Service deployed.</summary>
    [JsonPropertyName("gcfUri")]
    public string? GcfUri { get; set; }

    /// <summary>Available ingress settings. Defaults to &quot;ALLOW_ALL&quot; if unspecified. Default value: &quot;ALLOW_ALL&quot; Possible values: [&quot;ALLOW_ALL&quot;, &quot;ALLOW_INTERNAL_ONLY&quot;, &quot;ALLOW_INTERNAL_AND_GCLB&quot;].</summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("maxInstanceCount")]
    public int? MaxInstanceCount { get; set; }

    /// <summary>Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public int? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("minInstanceCount")]
    public int? MinInstanceCount { get; set; }

    /// <summary>Secret environment variables configuration.</summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1alpha1CloudFunctions2FunctionSpecServiceConfigSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>Secret volumes configuration.</summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1alpha1CloudFunctions2FunctionSpecServiceConfigSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>Name of the service associated with a Function.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The email of the service account for this function.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>URI of the Service deployed.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>The Serverless VPC Access connector that this cloud function can connect to.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>Available egress settings. Possible values: [&quot;VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED&quot;, &quot;PRIVATE_RANGES_ONLY&quot;, &quot;ALL_TRAFFIC&quot;].</summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionSpec
{
    /// <summary>
    /// Describes the Build step of the function that builds a container
    /// from the given source.
    /// </summary>
    [JsonPropertyName("buildConfig")]
    public V1alpha1CloudFunctions2FunctionSpecBuildConfig? BuildConfig { get; set; }

    /// <summary>User-provided description of a function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// An Eventarc trigger managed by Google Cloud Functions that fires events in
    /// response to a condition in another service.
    /// </summary>
    [JsonPropertyName("eventTrigger")]
    public V1alpha1CloudFunctions2FunctionSpecEventTrigger? EventTrigger { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Immutable. The location of this cloud function.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudFunctions2FunctionSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Describes the Service being deployed.</summary>
    [JsonPropertyName("serviceConfig")]
    public V1alpha1CloudFunctions2FunctionSpecServiceConfig? ServiceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudFunctions2FunctionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudFunctions2FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>The environment the function is hosted on.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Describes the current state of the function.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The last update timestamp of a Cloud Function.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The deployed url for the function.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudFunctions2Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudFunctions2FunctionSpec>, IStatus<V1alpha1CloudFunctions2FunctionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudFunctions2Function";
    public const string KubeGroup = "cloudfunctions2.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudfunctions2functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfunctions2.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudFunctions2Function";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1CloudFunctions2FunctionSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1CloudFunctions2FunctionStatus? Status { get; set; }
}