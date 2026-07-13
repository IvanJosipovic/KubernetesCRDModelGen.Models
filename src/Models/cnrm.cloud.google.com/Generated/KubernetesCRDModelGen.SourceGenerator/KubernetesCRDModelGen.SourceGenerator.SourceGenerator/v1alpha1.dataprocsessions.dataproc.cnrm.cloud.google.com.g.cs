#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
/// <summary>DataprocSession is the Schema for the DataprocSession API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocSessionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataprocSession>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocSessionList";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocsessions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataprocSessionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataprocSession objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataprocSession> Items { get; set; }
}

/// <summary>Optional. The Cloud KMS key to use for encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfigKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Service account that used to execute workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfigServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. A Cloud Storage bucket used to stage workload dependencies, config files, and store workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running, and then create and manage project-level, per-location staging and temporary buckets. **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfigStagingBucketRef
{
    /// <summary>A reference to an externally-managed StorageBucket resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a StorageBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a StorageBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Execution configuration for a workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfig
{
    /// <summary>Optional. Applies to sessions only. The duration to keep the session alive while it&apos;s idling. Exceeding this threshold causes the session to terminate. This field cannot be set on a batch workload. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). Defaults to 1 hour if not set. If both `ttl` and `idle_ttl` are specified for an interactive session, the conditions are treated as `OR` conditions: the workload will be terminated when it has been idle for `idle_ttl` or when `ttl` has been exceeded, whichever occurs first.</summary>
    [JsonPropertyName("idleTTL")]
    public string? IdleTTL { get; set; }

    /// <summary>Optional. The Cloud KMS key to use for encryption.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Optional. Tags used for network traffic control.</summary>
    [JsonPropertyName("networkTags")]
    public IList<string>? NetworkTags { get; set; }

    /// <summary>Optional. Network URI to connect workload to.</summary>
    [JsonPropertyName("networkURI")]
    public string? NetworkURI { get; set; }

    /// <summary>Optional. Service account that used to execute workload.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. A Cloud Storage bucket used to stage workload dependencies, config files, and store workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running, and then create and manage project-level, per-location staging and temporary buckets. **This field requires a Cloud Storage bucket name, not a `gs://...` URI to a Cloud Storage bucket.**</summary>
    [JsonPropertyName("stagingBucketRef")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfigStagingBucketRef? StagingBucketRef { get; set; }

    /// <summary>Optional. Subnetwork URI to connect workload to.</summary>
    [JsonPropertyName("subnetworkURI")]
    public string? SubnetworkURI { get; set; }

    /// <summary>Optional. The duration after which the workload will be terminated, specified as the JSON representation for [Duration](https://protobuf.dev/programming-guides/proto3/#json). When the workload exceeds this duration, it will be unconditionally terminated without waiting for ongoing work to finish. If `ttl` is not specified for a batch workload, the workload will be allowed to run until it exits naturally (or run forever without exiting). If `ttl` is not specified for an interactive session, it defaults to 24 hours. If `ttl` is not specified for a batch that uses 2.1+ runtime version, it defaults to 4 hours. Minimum value is 10 minutes; maximum value is 14 days. If both `ttl` and `idle_ttl` are specified (for an interactive session), the conditions are treated as `OR` conditions: the workload will be terminated when it has been idle for `idle_ttl` or when `ttl` has been exceeded, whichever occurs first.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>
/// Optional. Resource name of an existing Dataproc Cluster to act as a Spark
///  History Server for the workload.
/// 
///  Example:
/// 
///  * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>A reference to an externally managed DataprocCluster resource. Should be in the format &quot;projects/{{projectID}}/regions/{{region}}/clusters/{{clusterName}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataprocCluster resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataprocCluster resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfig
{
    /// <summary>
    /// Optional. Resource name of an existing Dataproc Cluster to act as a Spark
    ///  History Server for the workload.
    /// 
    ///  Example:
    /// 
    ///  * `projects/[project_id]/regions/[region]/clusters/[cluster_name]`
    /// </summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }
}

/// <summary>Optional. Peripherals configuration that workload has access to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfigPeripheralsConfig
{
    /// <summary>
    /// Optional. Resource name of an existing Dataproc Metastore service.
    /// 
    ///  Example:
    /// 
    ///  * `projects/[project_id]/locations/[region]/services/[service_id]`
    /// </summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }

    /// <summary>Optional. The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigPeripheralsConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>Optional. Environment configuration for the session execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecEnvironmentConfig
{
    /// <summary>Optional. Execution configuration for a workload.</summary>
    [JsonPropertyName("executionConfig")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigExecutionConfig? ExecutionConfig { get; set; }

    /// <summary>Optional. Peripherals configuration that workload has access to.</summary>
    [JsonPropertyName("peripheralsConfig")]
    public V1alpha1DataprocSessionSpecEnvironmentConfigPeripheralsConfig? PeripheralsConfig { get; set; }
}

/// <summary>Optional. Jupyter session config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecJupyterSession
{
    /// <summary>Optional. Display name, shown in the Jupyter kernelspec card.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. Kernel</summary>
    [JsonPropertyName("kernel")]
    public string? Kernel { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Autotuning configuration of the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecRuntimeConfigAutotuningConfig
{
    /// <summary>Optional. Scenarios for which tunings are applied.</summary>
    [JsonPropertyName("scenarios")]
    public IList<string>? Scenarios { get; set; }
}

/// <summary>Optional. Configuration for PyPi repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecRuntimeConfigRepositoryConfigPypiRepositoryConfig
{
    /// <summary>Optional. PyPi repository address</summary>
    [JsonPropertyName("pypiRepository")]
    public string? PypiRepository { get; set; }
}

/// <summary>Optional. Dependency repository configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecRuntimeConfigRepositoryConfig
{
    /// <summary>Optional. Configuration for PyPi repository.</summary>
    [JsonPropertyName("pypiRepositoryConfig")]
    public V1alpha1DataprocSessionSpecRuntimeConfigRepositoryConfigPypiRepositoryConfig? PypiRepositoryConfig { get; set; }
}

/// <summary>Optional. Runtime configuration for the session execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpecRuntimeConfig
{
    /// <summary>Optional. Autotuning configuration of the workload.</summary>
    [JsonPropertyName("autotuningConfig")]
    public V1alpha1DataprocSessionSpecRuntimeConfigAutotuningConfig? AutotuningConfig { get; set; }

    /// <summary>Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.</summary>
    [JsonPropertyName("cohort")]
    public string? Cohort { get; set; }

    /// <summary>Optional. Optional custom container image for the job runtime environment. If not specified, a default container image will be used.</summary>
    [JsonPropertyName("containerImage")]
    public string? ContainerImage { get; set; }

    /// <summary>Optional. A mapping of property names to values, which are used to configure workload execution.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Optional. Dependency repository configuration.</summary>
    [JsonPropertyName("repositoryConfig")]
    public V1alpha1DataprocSessionSpecRuntimeConfigRepositoryConfig? RepositoryConfig { get; set; }

    /// <summary>Optional. Version of the batch runtime.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>DataprocSessionSpec defines the desired state of DataprocSession</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionSpec
{
    /// <summary>Optional. Environment configuration for the session execution.</summary>
    [JsonPropertyName("environmentConfig")]
    public V1alpha1DataprocSessionSpecEnvironmentConfig? EnvironmentConfig { get; set; }

    /// <summary>Optional. Jupyter session config.</summary>
    [JsonPropertyName("jupyterSession")]
    public V1alpha1DataprocSessionSpecJupyterSession? JupyterSession { get; set; }

    /// <summary>Optional. The labels to associate with the session. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be empty, but, if present, must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a session.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataprocSessionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DataprocSession name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Runtime configuration for the session execution.</summary>
    [JsonPropertyName("runtimeConfig")]
    public V1alpha1DataprocSessionSpecRuntimeConfig? RuntimeConfig { get; set; }

    /// <summary>
    /// Optional. The session template used by the session.
    /// 
    ///  Only resource names, including project ID and location, are valid.
    /// 
    ///  Example:
    ///  * `https://www.googleapis.com/compute/v1/projects/[project_id]/locations/[dataproc_region]/sessionTemplates/[template_id]`
    ///  * `projects/[project_id]/locations/[dataproc_region]/sessionTemplates/[template_id]`
    /// 
    ///  The template must be in the same project and Dataproc region as the
    ///  session.
    /// </summary>
    [JsonPropertyName("sessionTemplate")]
    public string? SessionTemplate { get; set; }

    /// <summary>Optional. The email address of the user who owns the session.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatusConditions
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

/// <summary>
/// Output only. Approximate workload resource usage, calculated when
///  the workload completes (see [Dataproc Serverless pricing]
///  (https://cloud.google.com/dataproc-serverless/pricing)).
/// 
///  **Note:** This metric calculation may change in the future, for
///  example, to capture cumulative workload resource
///  consumption during workload execution (see the
///  [Dataproc Serverless release notes]
///  (https://cloud.google.com/dataproc-serverless/docs/release-notes)
///  for announcements, changes, fixes
///  and other Dataproc developments).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatusObservedStateRuntimeInfoApproximateUsage
{
    /// <summary>Optional. Accelerator type being used, if any</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Optional. Accelerator usage in (`milliAccelerator` x `seconds`) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliAcceleratorSeconds")]
    public long? MilliAcceleratorSeconds { get; set; }

    /// <summary>Optional. DCU (Dataproc Compute Units) usage in (`milliDCU` x `seconds`) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliDcuSeconds")]
    public long? MilliDcuSeconds { get; set; }

    /// <summary>Optional. Shuffle storage usage in (`GB` x `seconds`) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("shuffleStorageGBSeconds")]
    public long? ShuffleStorageGBSeconds { get; set; }
}

/// <summary>Output only. Snapshot of current workload resource usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatusObservedStateRuntimeInfoCurrentUsage
{
    /// <summary>Optional. Accelerator type being used, if any</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Optional. Milli (one-thousandth) accelerator. (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing))</summary>
    [JsonPropertyName("milliAccelerator")]
    public long? MilliAccelerator { get; set; }

    /// <summary>Optional. Milli (one-thousandth) Dataproc Compute Units (DCUs) (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliDcu")]
    public long? MilliDcu { get; set; }

    /// <summary>Optional. Milli (one-thousandth) Dataproc Compute Units (DCUs) charged at premium tier (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing)).</summary>
    [JsonPropertyName("milliDcuPremium")]
    public long? MilliDcuPremium { get; set; }

    /// <summary>Optional. Shuffle Storage in gigabytes (GB). (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing))</summary>
    [JsonPropertyName("shuffleStorageGB")]
    public long? ShuffleStorageGB { get; set; }

    /// <summary>Optional. Shuffle Storage in gigabytes (GB) charged at premium tier. (see [Dataproc Serverless pricing] (https://cloud.google.com/dataproc-serverless/pricing))</summary>
    [JsonPropertyName("shuffleStorageGBPremium")]
    public long? ShuffleStorageGBPremium { get; set; }

    /// <summary>Optional. The timestamp of the usage snapshot.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }
}

/// <summary>Output only. Runtime information about session execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatusObservedStateRuntimeInfo
{
    /// <summary>
    /// Output only. Approximate workload resource usage, calculated when
    ///  the workload completes (see [Dataproc Serverless pricing]
    ///  (https://cloud.google.com/dataproc-serverless/pricing)).
    /// 
    ///  **Note:** This metric calculation may change in the future, for
    ///  example, to capture cumulative workload resource
    ///  consumption during workload execution (see the
    ///  [Dataproc Serverless release notes]
    ///  (https://cloud.google.com/dataproc-serverless/docs/release-notes)
    ///  for announcements, changes, fixes
    ///  and other Dataproc developments).
    /// </summary>
    [JsonPropertyName("approximateUsage")]
    public V1alpha1DataprocSessionStatusObservedStateRuntimeInfoApproximateUsage? ApproximateUsage { get; set; }

    /// <summary>Output only. Snapshot of current workload resource usage.</summary>
    [JsonPropertyName("currentUsage")]
    public V1alpha1DataprocSessionStatusObservedStateRuntimeInfoCurrentUsage? CurrentUsage { get; set; }

    /// <summary>Output only. A URI pointing to the location of the diagnostics tarball.</summary>
    [JsonPropertyName("diagnosticOutputURI")]
    public string? DiagnosticOutputURI { get; set; }

    /// <summary>Output only. Map of remote access endpoints (such as web interfaces and APIs) to their URIs.</summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }

    /// <summary>Output only. A URI pointing to the location of the stdout and stderr of the workload.</summary>
    [JsonPropertyName("outputURI")]
    public string? OutputURI { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatusObservedStateStateHistory
{
    /// <summary>Output only. The state of the session at this point in the session history.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Details about the state at this point in the session history.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The time when the session entered the historical state.</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatusObservedState
{
    /// <summary>Output only. The time when the session was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The email address of the user who created the session.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. Runtime information about session execution.</summary>
    [JsonPropertyName("runtimeInfo")]
    public V1alpha1DataprocSessionStatusObservedStateRuntimeInfo? RuntimeInfo { get; set; }

    /// <summary>Output only. A state of the session.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Historical state information for the session.</summary>
    [JsonPropertyName("stateHistory")]
    public IList<V1alpha1DataprocSessionStatusObservedStateStateHistory>? StateHistory { get; set; }

    /// <summary>Output only. Session state details, such as the failure description if the state is `FAILED`.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The time when the session entered the current state.</summary>
    [JsonPropertyName("stateTime")]
    public string? StateTime { get; set; }

    /// <summary>Output only. A session UUID (Unique Universal Identifier). The service generates this value when it creates the session.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>DataprocSessionStatus defines the config connector machine state of DataprocSession</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataprocSessionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataprocSessionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataprocSession resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataprocSessionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataprocSession is the Schema for the DataprocSession API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataprocSession : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataprocSessionSpec>, IStatus<V1alpha1DataprocSessionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataprocSession";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocsessions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataprocSession";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataprocSessionSpec defines the desired state of DataprocSession</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DataprocSessionSpec Spec { get; set; }

    /// <summary>DataprocSessionStatus defines the config connector machine state of DataprocSession</summary>
    [JsonPropertyName("status")]
    public V1alpha1DataprocSessionStatus? Status { get; set; }
}