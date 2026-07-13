#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary>VertexAIDeploymentResourcePool is the Schema for the VertexAIDeploymentResourcePool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIDeploymentResourcePoolList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIDeploymentResourcePool>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIDeploymentResourcePoolList";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaideploymentresourcepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIDeploymentResourcePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAIDeploymentResourcePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAIDeploymentResourcePool> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesAutoscalingMetricSpecs
{
    /// <summary>
    /// Required. The resource metric name.
    ///  Supported metrics:
    /// 
    ///  * For Online Prediction:
    ///  * `aiplatform.googleapis.com/prediction/online/accelerator/duty_cycle`
    ///  * `aiplatform.googleapis.com/prediction/online/cpu/utilization`
    ///  * `aiplatform.googleapis.com/prediction/online/request_count`
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Optional. The Cloud Monitoring monitored resource labels as key value pairs used for metrics filtering. See Cloud Monitoring Labels https://cloud.google.com/monitoring/api/v3/metric-model#generic-label-info</summary>
    [JsonPropertyName("monitoredResourceLabels")]
    public IDictionary<string, string>? MonitoredResourceLabels { get; set; }

    /// <summary>The target resource utilization in percentage (1% - 100%) for the given metric; once the real usage deviates from the target by a certain percentage, the machine replicas change. The default value is 60 (representing 60%) if not provided.</summary>
    [JsonPropertyName("target")]
    public int? Target { get; set; }
}

/// <summary>Optional. Immutable. If set, use DWS resource to schedule the deployment workload. reference: (https://cloud.google.com/blog/products/compute/introducing-dynamic-workload-scheduler)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesFlexStart
{
    /// <summary>The max duration of the deployment is max_runtime_duration. The deployment will be terminated after the duration. The max_runtime_duration can be set up to 7 days.</summary>
    [JsonPropertyName("maxRuntimeDuration")]
    public string? MaxRuntimeDuration { get; set; }
}

/// <summary>Optional. Immutable. Configuration controlling how this resource pool consumes reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesMachineSpecReservationAffinity
{
    /// <summary>Optional. Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, use `compute.googleapis.com/reservation-name` as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. Specifies the reservation affinity type.</summary>
    [JsonPropertyName("reservationAffinityType")]
    public string? ReservationAffinityType { get; set; }

    /// <summary>Optional. Corresponds to the label values of a reservation resource. This must be the full resource name of the reservation.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Required. Immutable. The specification of a single machine being used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesMachineSpec
{
    /// <summary>The number of accelerators to attach to the machine.</summary>
    [JsonPropertyName("acceleratorCount")]
    public int? AcceleratorCount { get; set; }

    /// <summary>Immutable. The type of accelerator(s) that may be attached to the machine as per [accelerator_count][google.cloud.aiplatform.v1beta1.MachineSpec.accelerator_count].</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>
    /// Optional. Immutable. The Nvidia GPU partition size.
    /// 
    ///  When specified, the requested accelerators will be partitioned into
    ///  smaller GPU partitions. For example, if the request is for 8 units of
    ///  NVIDIA A100 GPUs, and gpu_partition_size=&quot;1g.10gb&quot;, the service will
    ///  create 8 * 7 = 56 partitioned MIG instances.
    /// 
    ///  The partition size must be a value supported by the requested accelerator.
    ///  Refer to
    ///  [Nvidia GPU
    ///  Partitioning](https://cloud.google.com/kubernetes-engine/docs/how-to/gpus-multi#multi-instance_gpu_partitions)
    ///  for the available partition sizes.
    /// 
    ///  If set, the accelerator_count should be set to 1.
    /// </summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>
    /// Immutable. The type of the machine.
    /// 
    ///  See the [list of machine types supported for
    ///  prediction](https://cloud.google.com/vertex-ai/docs/predictions/configure-compute#machine-types)
    /// 
    ///  See the [list of machine types supported for custom
    ///  training](https://cloud.google.com/vertex-ai/docs/training/configure-compute#machine-types).
    /// 
    ///  For [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] this
    ///  field is optional, and the default value is `n1-standard-2`. For
    ///  [BatchPredictionJob][google.cloud.aiplatform.v1beta1.BatchPredictionJob] or
    ///  as part of [WorkerPoolSpec][google.cloud.aiplatform.v1beta1.WorkerPoolSpec]
    ///  this field is required.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Optional. Immutable. The number of nodes per replica for multihost GPU deployments.</summary>
    [JsonPropertyName("multihostGpuNodeCount")]
    public int? MultihostGpuNodeCount { get; set; }

    /// <summary>Optional. Immutable. Configuration controlling how this resource pool consumes reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesMachineSpecReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>Immutable. The topology of the TPUs. Corresponds to the TPU topologies available from GKE. (Example: tpu_topology: &quot;2x2x1&quot;).</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }
}

/// <summary>Required. The underlying DedicatedResources that the DeploymentResourcePool uses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResources
{
    /// <summary>
    /// Immutable. The metric specifications that overrides a resource
    ///  utilization metric (CPU utilization, accelerator&apos;s duty cycle, and so on)
    ///  target value (default to 60 if not set). At most one entry is allowed per
    ///  metric.
    /// 
    ///  If
    ///  [machine_spec.accelerator_count][google.cloud.aiplatform.v1beta1.MachineSpec.accelerator_count]
    ///  is above 0, the autoscaling will be based on both CPU utilization and
    ///  accelerator&apos;s duty cycle metrics and scale up when either metrics exceeds
    ///  its target value while scale down if both metrics are under their target
    ///  value. The default target value is 60 for both metrics.
    /// 
    ///  If
    ///  [machine_spec.accelerator_count][google.cloud.aiplatform.v1beta1.MachineSpec.accelerator_count]
    ///  is 0, the autoscaling will be based on CPU utilization metric only with
    ///  default target value 60 if not explicitly set.
    /// 
    ///  For example, in the case of Online Prediction, if you want to override
    ///  target CPU utilization to 80, you should set
    ///  [autoscaling_metric_specs.metric_name][google.cloud.aiplatform.v1beta1.AutoscalingMetricSpec.metric_name]
    ///  to `aiplatform.googleapis.com/prediction/online/cpu/utilization` and
    ///  [autoscaling_metric_specs.target][google.cloud.aiplatform.v1beta1.AutoscalingMetricSpec.target]
    ///  to `80`.
    /// </summary>
    [JsonPropertyName("autoscalingMetricSpecs")]
    public IList<V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesAutoscalingMetricSpecs>? AutoscalingMetricSpecs { get; set; }

    /// <summary>Optional. Immutable. If set, use DWS resource to schedule the deployment workload. reference: (https://cloud.google.com/blog/products/compute/introducing-dynamic-workload-scheduler)</summary>
    [JsonPropertyName("flexStart")]
    public V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesFlexStart? FlexStart { get; set; }

    /// <summary>Required. Immutable. The specification of a single machine being used.</summary>
    [JsonPropertyName("machineSpec")]
    public V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResourcesMachineSpec? MachineSpec { get; set; }

    /// <summary>
    /// Immutable. The maximum number of replicas that may be deployed on when the
    ///  traffic against it increases. If the requested value is too large, the
    ///  deployment will error, but if deployment succeeds then the ability to scale
    ///  to that many replicas is guaranteed (barring service outages). If traffic
    ///  increases beyond what its replicas at maximum may handle, a portion of the
    ///  traffic will be dropped. If this value is not provided, will use
    ///  [min_replica_count][google.cloud.aiplatform.v1beta1.DedicatedResources.min_replica_count]
    ///  as the default value.
    /// 
    ///  The value of this field impacts the charge against Vertex CPU and GPU
    ///  quotas. Specifically, you will be charged for (max_replica_count *
    ///  number of cores in the selected machine type) and (max_replica_count *
    ///  number of GPUs per replica in the selected machine type).
    /// </summary>
    [JsonPropertyName("maxReplicaCount")]
    public int? MaxReplicaCount { get; set; }

    /// <summary>
    /// Required. Immutable. The minimum number of machine replicas that will be
    ///  always deployed on. This value must be greater than or equal to 1.
    /// 
    ///  If traffic increases, it may dynamically be deployed onto more replicas,
    ///  and as traffic decreases, some of these extra replicas may be freed.
    /// </summary>
    [JsonPropertyName("minReplicaCount")]
    public int? MinReplicaCount { get; set; }

    /// <summary>Optional. Number of required available replicas for the deployment to succeed. This field is only needed when partial deployment/mutation is desired. If set, the deploy/mutate operation will succeed once available_replica_count reaches required_replica_count, and the rest of the replicas will be retried. If not set, the default required_replica_count will be min_replica_count.</summary>
    [JsonPropertyName("requiredReplicaCount")]
    public int? RequiredReplicaCount { get; set; }

    /// <summary>Optional. If true, schedule the deployment workload on [spot VMs](https://cloud.google.com/kubernetes-engine/docs/concepts/spot-vms).</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}

/// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecEncryptionSpecKmsKeyRef
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

/// <summary>Customer-managed encryption key spec for a DeploymentResourcePool. If set, this DeploymentResourcePool will be secured by this key. Endpoints and the DeploymentResourcePool they deploy in need to have the same EncryptionSpec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public required V1alpha1VertexAIDeploymentResourcePoolSpecEncryptionSpecKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecProjectRef
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

/// <summary>The service account that the DeploymentResourcePool&apos;s container(s) run as.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpecServiceAccountRef
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

/// <summary>VertexAIDeploymentResourcePoolSpec defines the desired state of VertexAIDeploymentResourcePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolSpec
{
    /// <summary>Required. The underlying DedicatedResources that the DeploymentResourcePool uses.</summary>
    [JsonPropertyName("dedicatedResources")]
    public V1alpha1VertexAIDeploymentResourcePoolSpecDedicatedResources? DedicatedResources { get; set; }

    /// <summary>If the DeploymentResourcePool is deployed with custom-trained Models or AutoML Tabular Models, the container(s) of the DeploymentResourcePool will send `stderr` and `stdout` streams to Cloud Logging by default.</summary>
    [JsonPropertyName("disableContainerLogging")]
    public bool? DisableContainerLogging { get; set; }

    /// <summary>Customer-managed encryption key spec for a DeploymentResourcePool. If set, this DeploymentResourcePool will be secured by this key. Endpoints and the DeploymentResourcePool they deploy in need to have the same EncryptionSpec.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAIDeploymentResourcePoolSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VertexAIDeploymentResourcePoolSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VertexAIDeploymentResourcePool name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The service account that the DeploymentResourcePool&apos;s container(s) run as.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1VertexAIDeploymentResourcePoolSpecServiceAccountRef? ServiceAccountRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolStatusObservedState
{
    /// <summary>Output only. Timestamp when this DeploymentResourcePool was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzi")]
    public bool? SatisfiesPzi { get; set; }

    /// <summary>Output only. Reserved for future use.</summary>
    [JsonPropertyName("satisfiesPzs")]
    public bool? SatisfiesPzs { get; set; }
}

/// <summary>VertexAIDeploymentResourcePoolStatus defines the config connector machine state of VertexAIDeploymentResourcePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDeploymentResourcePoolStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIDeploymentResourcePoolStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIDeploymentResourcePool resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIDeploymentResourcePoolStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIDeploymentResourcePool is the Schema for the VertexAIDeploymentResourcePool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIDeploymentResourcePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIDeploymentResourcePoolSpec>, IStatus<V1alpha1VertexAIDeploymentResourcePoolStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIDeploymentResourcePool";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaideploymentresourcepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIDeploymentResourcePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIDeploymentResourcePoolSpec defines the desired state of VertexAIDeploymentResourcePool</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAIDeploymentResourcePoolSpec Spec { get; set; }

    /// <summary>VertexAIDeploymentResourcePoolStatus defines the config connector machine state of VertexAIDeploymentResourcePool</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIDeploymentResourcePoolStatus? Status { get; set; }
}